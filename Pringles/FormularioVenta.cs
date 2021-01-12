using Pringles.Contracts.Repositories;
using Pringles.Contracts.TextBuilders;
using Pringles.Contracts.UnitsOfWorks;
using Pringles.DAL;
using Pringles.DAL.Lists;
using Pringles.DAL.Singletons;
using Pringles.DAL.TextBuilders;
using Pringles.DAL.UnitsOfWorks;
using Pringles.EE;
using Pringles.Utilities.Consts;
using Pringles.Utilities.Serializador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pringles
{
    public partial class FormularioVenta : BaseForm
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ILibroRepository _libroRepository;
        private readonly IRegistroCajaRepository _registroCajaRepository;
        private readonly IDetalleDescuentoRepository _descuentoRepository;
        private readonly IAutorRepository _autorRepository;
        private readonly IGeneroRepository _generoRepository;
        private readonly IList<DetalleOrden> _articulos;
        private readonly IFacturaRepository _facturas;


        private Cliente instanciaCliente;
        private Libro instanciaLibro;
        private DetalleDescuento instanciaDescuento;
        private RegistroCaja registroCaja;

        public FormularioVenta() : base()
        {
            RevisarRol();
            InitializeComponent();
            _clienteRepository = new ClienteRepository();
            _libroRepository = new LibroRepository();
            _articulos = new ArticuloList();
            _registroCajaRepository = new RegistroCajaRepository();
            _descuentoRepository = new DetalleDescuentoRepository();
            _autorRepository = new AutorRepository();
            _generoRepository = new GeneroRepository();
            _facturas = new FacturaRepository();
        }

        private void RefrescarMonto()
        {
            decimal? totalVenta = ObtenerMontoVenta();
            lbl_total_venta.Text = (totalVenta ?? 0.00m).ToString("0.00", CultureInfo.InvariantCulture);
        }

        private decimal? ObtenerMontoVenta()
        {
            return _articulos
                .Select(libro => libro.MontoTotal)
                .Sum();
        }

        private void txt_dni_clilente_venta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscarCliente();
        }

        private void BuscarCliente()
        {
            string dni = txt_dni_clilente_venta.Text;

            if (string.IsNullOrEmpty(dni) || !txt_dni_clilente_venta.MaskFull)
            {
                MessageBox.Show(this, "DNI Incorrecto");
                return;
            }

            LimpiarDni();

            var cliente = _clienteRepository.BuscarClientePorDni(dni);

            if (cliente == null)
            {
                MessageBox.Show(this, "Cliente no encontrado");
                LimpiarCliente();
                return;
            }

            AsignarCliente(cliente);
        }

        private void BuscarLibro()
        {
            string isbn = txt_libro_venta.Text;
            LimpiarIsbn();

            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show(this, "ISBN Vacio");
                return;
            }

            var libro = _libroRepository.BuscarLibroPorISBN(isbn);

            if (libro == null)
            {
                MessageBox.Show(this, "Libro no encontrado");
                LimpiarLibro();
                return;
            }

            AsignarLibro(libro);
        }

        private void LimpiarMontos()
        {
            LimpiarMontoEfectivo();
            LimpiarMontoTarjeta();
        }

        private void LimpiarDescuento()
        {
            instanciaDescuento = null;
            ActualizarDescuentosLibros();
            RefrescarMensajeDescuento();
        }

        private void LimpiarMontoEfectivo()
        {
            txt_monto_efectivo.Text = string.Empty;
        }

        private void LimpiarMontoTarjeta()
        {
            txt_monto_tarjeta.Text = string.Empty;
        }

        private void LimpiarCliente()
        {
            grp_grupo_cliente.Visible = false;
            lbl_dni_cliente.Text = string.Empty;
            lbl_nombre_cliente.Text = string.Empty;
            instanciaCliente = null;
        }

        private void LimpiarLibro()
        {
            grp_libro_venta.Visible = false;
            nud_cantidad_libro_venta.Value = 1;
            lbl_precio_libro.Text = string.Empty;
            lbl_titulo_libro.Text = string.Empty;
            instanciaLibro = null;
        }

        private void AsignarCliente(Cliente cliente)
        {
            instanciaCliente = cliente;
            lbl_dni_cliente.Text = instanciaCliente.Dni;
            lbl_nombre_cliente.Text = instanciaCliente.NombreCompleto;
            grp_grupo_cliente.Visible = true;
        }

        private void AsignarLibro(Libro libro)
        {
            instanciaLibro = libro;
            nud_cantidad_libro_venta.Value = 1;
            lbl_titulo_libro.Text = instanciaLibro.Titulo;
            lbl_precio_libro.Text = instanciaLibro.Monto_Unitario.ToString("0.00");
            grp_libro_venta.Visible = true;
        }

        private void AgregarLibro()
        {
            if (instanciaLibro == null)
            {
                MessageBox.Show(this, "No hay libro cargado");
                return;
            }

            if (instanciaLibro.Prohibido)
            {
                MessageBox.Show(this, "Este libro esta prohibido");
                return;
            }

            if (instanciaLibro.Restringido && instanciaCliente == null)
            {
                MessageBox.Show(this, "Este libro esta restringido, debe de ser un cliente inscrito para poder comprarlo");
                return;
            }

            int cantidadSeleccionada = Convert.ToInt32(nud_cantidad_libro_venta.Value);

            if (instanciaLibro.Cantidad_Stock < cantidadSeleccionada)
            {
                MessageBox.Show("No hay suficientes para esta cantidad.");
                return;
            }

            DetalleOrden articulo = CrearArticulo();
            _articulos.Add(articulo);
            LimpiarLibro();
            RefrescarVenta();
        }

        private void RefrescarGrillaVenta()
        {
            grillaVenta.DataSource = null;
            grillaVenta.DataSource = _articulos.ToList();

            grillaVenta.Columns[nameof(DetalleOrden.Detalle_Descuento_Fk)].Visible = false;
            grillaVenta.Columns[nameof(DetalleOrden.Libro)].Visible = false;
            grillaVenta.Columns[nameof(DetalleOrden.Libro_Fk)].Visible = false;
            grillaVenta.Columns[nameof(DetalleOrden.Orden_Fk)].Visible = false;
            grillaVenta.Columns[nameof(DetalleOrden.Id)].Visible = false;
            grillaVenta.Columns[nameof(DetalleOrden.Registro_Caja_Fk)].Visible = false;
            grillaVenta.Columns[nameof(DetalleOrden.Libro)].Visible = false;
        }

        private void LimpiarDni()
        {
            txt_dni_clilente_venta.Text = string.Empty;
        }

        private void LimpiarIsbn()
        {
            txt_libro_venta.Text = string.Empty;
        }

        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
            RefrescarVenta();
        }

        private void btn_agregar_libro_Click(object sender, EventArgs e)
        {
            AgregarLibro();
        }

        private DetalleOrden CrearArticulo()
        {
            return new DetalleOrden
            {
                Libro_Fk = instanciaLibro.Id,
                Precio_Unitario = instanciaLibro.Monto_Unitario,
                Descuento = null,
                Cantidad = Convert.ToInt32(nud_cantidad_libro_venta.Value),
                Registro_Caja_Fk = CurrentCaja.GetInstance().Caja.Id,
                Libro = instanciaLibro,
                Detalle_Descuento_Fk = null
            };
        }

        private void btn_cancelar_libro_Click(object sender, EventArgs e)
        {
            LimpiarLibro();
        }

        private void btn_buscar_libro_Click(object sender, EventArgs e)
        {
            BuscarLibro();
        }

        private void txt_libro_venta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscarLibro();
        }

        private void btn_cancelar_cliente_Click(object sender, EventArgs e)
        {
            LimpiarCliente();
            LimpiarDescuento();
            RefrescarVenta();
        }

        private void FormularioVenta_Load(object sender, EventArgs e)
        {
            lbl_nombre_usuario.Text = CurrentUser.GetCurrentInstance().Usuario.NombreCompleto;
            int idCaja = CurrentCaja.GetInstance()?.Caja?.Id ?? 0;
            registroCaja = _registroCajaRepository.BuscarCajaVigente(idCaja);

            lbl_autor_mas_vendido.Text = _autorRepository.BuscarAutorMasVendido()?.ToString() ?? "Ninguno";
            lbl_genero_mas_vendido.Text = _generoRepository.BuscarGeneroMasVendido()?.ToString() ?? "Ninguno";

            if (registroCaja == null)
            {
                MessageBox.Show(this, "La caja se encuentra cerrada.");
                return;
            }

            RefrescarVenta();
            RefrescarMensajeDescuento();
        }

        private void RefrescarVenta()
        {
            RefrescarGrillaVenta();
            RefrescarMonto();
            RefrescarDescuento();
        }

        private void RefrescarDescuento()
        {
            grv_descuentos.DataSource = null;
            if (instanciaCliente == null)
                return;

            var descuentos = _descuentoRepository.BuscarDescuentosVigentes();

            Expression<Func<DetalleDescuento, bool>> expression = (x) =>
                ((x.Aplica_Genero ?? false) && _articulos.Any(a => a.Libro.Genero_Fk == (x.Genero_Fk ?? 0)))

              || ((x.Aplica_Autor ?? false) && _articulos.Any(a => a.Libro.Autores.Any(b => b.Id == (x.Autor_Fk ?? 0))));

            grv_descuentos.DataSource = descuentos.Where(expression).ToList();

            grv_descuentos.Columns[nameof(DetalleDescuento.Id)].Visible = false;
            grv_descuentos.Columns[nameof(DetalleDescuento.Autor_Fk)].Visible = false;
            grv_descuentos.Columns[nameof(DetalleDescuento.Genero_Fk)].Visible = false;
            grv_descuentos.Columns[nameof(DetalleDescuento.Aplica_Autor)].Visible = false;
            grv_descuentos.Columns[nameof(DetalleDescuento.Aplica_Genero)].Visible = false;
            grv_descuentos.Columns[nameof(DetalleDescuento.Genero)].Visible = false;
            grv_descuentos.Columns[nameof(DetalleDescuento.Autor)].Visible = false;
            grv_descuentos.Columns[nameof(DetalleDescuento.Fecha_Reg)].Visible = false;
            grv_descuentos.Columns[nameof(DetalleDescuento.Fecha_Fin)].Visible = false;
            grv_descuentos.Columns[nameof(DetalleDescuento.Descuento)].Visible = false;

            grv_descuentos.Columns[nameof(DetalleDescuento.FechaVencimientoStr)].HeaderText = "Fecha Vence";
            grv_descuentos.Columns[nameof(DetalleDescuento.DescuentoStr)].HeaderText = "% Descuento";
        }

        private void btn_eliminar_articulo_Click(object sender, EventArgs e)
        {
            var articulo = SeleccionarArticulo();

            if (articulo == null)
            {
                MessageBox.Show(this, "Debe de seleccionar un articulo");
                return;
            }

            _articulos.Remove(articulo);

            RefrescarVenta();
        }

        private DetalleOrden SeleccionarArticulo()
        {
            try
            {
                return grillaVenta.SelectedRows[0].DataBoundItem as DetalleOrden;
            }
            catch
            {
                return null;
            }
        }

        private void btn_alta_venta_Click(object sender, EventArgs e)
        {
            if ((!ValidarFormatoMonto(txt_monto_efectivo.Text) && !string.IsNullOrEmpty(txt_monto_efectivo.Text)))  
            {
                MessageBox.Show("Formato no valido para efectivo");
                return;
            }

            if ((!ValidarFormatoMonto(txt_monto_tarjeta.Text) && !string.IsNullOrEmpty(txt_monto_tarjeta.Text)))
            {
                MessageBox.Show("Formato no valido para tarjeta");
                return;
            }

            if (registroCaja == null)
            {
                MessageBox.Show(this, "La caja se encuentra cerrada.");
                return;
            }

            if (_articulos.Count() == 0)
            {
                MessageBox.Show(this, "No hay articulos");
                return;
            }

            if (_articulos.Any(a => a.Libro.Prohibido))
            {
                MessageBox.Show(this, "Esta venta contiene libro prohibido");
                return;
            }

            if (_articulos.Any(a => a.Libro.Restringido) && instanciaCliente == null)
            {
                MessageBox.Show(this, "Este libro esta restringido, debe de ser un cliente inscrito para poder comprarlo");
                return;
            }

            decimal montoTotal = ObtenerMontoVenta() ?? 0;
            bool pagarTarjeta = ch_tarjeta_credito_forma_pago.Checked;
            bool pagarEfectivo = ch_efectivo_forma_pago.Checked;

            if (montoTotal <= 0)
            {
                MessageBox.Show("No hay venta a realizar");
                return;
            }

            if (!(pagarEfectivo || pagarTarjeta))
            {
                MessageBox.Show(this, "Debe elegir un metodo de pago");
                return;
            }

            decimal montoTarjeta = 0, montoEfectivo = 0, devuelta = 0;

            if (pagarTarjeta)
            {
                if (!decimal.TryParse(txt_monto_tarjeta.Text,NumberStyles.Number,CultureInfo.InvariantCulture, out montoTarjeta))
                {
                    MessageBox.Show(this, "Monto no valido");
                    return;
                }
            }
            if (pagarEfectivo)
            {
                if (!decimal.TryParse(txt_monto_efectivo.Text, NumberStyles.Number,CultureInfo.InvariantCulture, out montoEfectivo))
                {
                    MessageBox.Show(this, "Monto no valido");
                    return;
                }
            }

            if (!ValidarMontosVenta(pagarEfectivo, pagarTarjeta, montoEfectivo, montoTarjeta))
            {
                MessageBox.Show(this, "No se puede realizar la venta bajo estos montos, por favor actualizar");
                return;
            }

            if (pagarEfectivo && !pagarTarjeta)
            {
                if (montoEfectivo > montoTotal)
                {
                    devuelta = montoEfectivo - montoTotal;
                }
            }

            try
            {
                IVentaUnitOfWork uow = new VentaUnitOfWork();

                Caja caja = CurrentCaja.GetInstance().Caja;
                Usuario usuario = CurrentUser.GetCurrentInstance().Usuario;

                Orden orden = new Orden
                {
                    Caja_Fk = caja.Id,
                    Caja = caja,
                    Cambio_Dinero = devuelta,
                    DetallesOrdenes = _articulos,
                    Monto_Pago_Efectivo = montoEfectivo,
                    Monto_Pago_Tarjeta = montoTarjeta,
                    Pago_Efectivo = pagarEfectivo,
                    Pago_Tarjeta = pagarTarjeta,
                    Cliente = instanciaCliente,
                    Cliente_Fk = instanciaCliente?.Id,
                    Usuario = usuario,
                    Usuario_Fk = usuario.Id
                };

                uow.RealizarVenta(orden, _articulos, registroCaja);
                MessageBox.Show(this, "Venta realizada");
                string factura = FabricarFacturaObjeto(orden);
                
                if (factura != null)
                {
                    _facturas.GuardarFactura(orden.Id,factura);
                }
                if (devuelta > 0)
                {
                    MessageBox.Show(this, $"Devuelta: {devuelta.ToString("0.00", CultureInfo.InvariantCulture)}");
                }
                _articulos.Clear();
                LimpiarCliente();
                LimpiarLibro();
                LimpiarMontos();
                DesmarcarFormasPago();
                RefrescarVenta();
                RefrescarMensajeDescuento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string FabricarFactura()
        {
            if (MessageBox.Show(this, "Desea crear factura?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Text File | *.txt";
                    sfd.ShowDialog();
                    string filename = sfd.FileName;
                    using (var stream = new FileStream(filename, FileMode.OpenOrCreate))
                    {
                        IGeneradorFactura generadorFactura = new GeneradorFactura();
                        StreamWriter sw = new StreamWriter(stream);
                        string factura = generadorFactura.CrearFactura(_articulos);
                        sw.WriteLine(factura);
                        sw.Close();
                        return factura;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Ocurrio un error generando factura");
                    return null;
                }
            }
            return null;
        }


        private string FabricarFacturaObjeto(Orden orden)
        {
            if (MessageBox.Show(this, "Desea crear factura?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Text File | *.txt";
                    sfd.ShowDialog();
                    string filename = sfd.FileName;
                    using (var stream = new FileStream(filename, FileMode.OpenOrCreate))
                    {
                        IGeneradorFactura generadorFactura = new GeneradorFactura();
                        StreamWriter sw = new StreamWriter(stream);
                        FacturaXML factura = generadorFactura.CrearFacturaObjeto(orden,_articulos);
                        string xml = SerializadorXml.CrearXml(factura);
                        sw.WriteLine(xml);
                        sw.Close();
                        return xml;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Ocurrio un error mostrar factura");
                    return null;
                }
            }
            return null;
        }


        private void DesmarcarFormasPago()
        {
            ch_efectivo_forma_pago.Checked = false;
            ch_tarjeta_credito_forma_pago.Checked = false;
        }

        private bool ValidarMontosVenta(bool pagarEfectivo, bool pagarTarjeta, decimal montoEfectivo, decimal montoTarjeta)
        {
            decimal montoVenta = ObtenerMontoVenta() ?? 0;

            if (montoTarjeta + montoEfectivo < montoVenta)
                return false;

            if (montoEfectivo < 0.0m || montoTarjeta < 0.0m)
            {
                return false;
            }

            if (pagarEfectivo && !pagarTarjeta)
            {
                return montoEfectivo >= montoVenta;
            }

            if ((pagarTarjeta && !pagarEfectivo) || (pagarEfectivo && pagarTarjeta))
            {
                return (montoTarjeta + montoEfectivo) == montoVenta;
            }

            return false;
        }

        private void ch_efectivo_forma_pago_CheckedChanged(object sender, EventArgs e)
        {
            txt_monto_efectivo.Visible = ch_efectivo_forma_pago.Checked;
        }

        private void ch_tarjeta_credito_forma_pago_CheckedChanged(object sender, EventArgs e)
        {
            txt_monto_tarjeta.Visible = ch_tarjeta_credito_forma_pago.Checked;
        }

        private void btn_seleccionar_descuento_Click(object sender, EventArgs e)
        {
            AsignarDescuento();
        }

        private void AsignarDescuento()
        {
            DetalleDescuento detalleDescuento = SeleccionarDescuento();
            if (detalleDescuento == null)
            {
                MessageBox.Show(this, "Debe seleccionar descuento aplicar");
                return;
            }
            instanciaDescuento = detalleDescuento;
            RefrescarMensajeDescuento();
            ActualizarDescuentosLibros();
        }

        private void ActualizarDescuentosLibros()
        {
            foreach (var articulo in _articulos)
            {
                articulo.Descuento = null;
                articulo.Detalle_Descuento_Fk = null;
            }

            if (instanciaDescuento == null)
            {
                RefrescarVenta();
                return;
            }

            foreach (var articulo in _articulos)
            {
                //if(instanciaDescuento.Aplica_Genero != null ? instanciaDescuento)


                if (instanciaDescuento.Aplica_Genero ?? false)
                {
                    if (articulo.Libro.Genero_Fk == instanciaDescuento.Genero_Fk)
                    {
                        articulo.Descuento = instanciaDescuento.Descuento;
                        articulo.Detalle_Descuento_Fk = instanciaDescuento.Id;
                    }
                }
                else if (instanciaDescuento.Aplica_Autor ?? false)
                {
                    if (articulo.Libro.Autores.Any(a => a.Id == instanciaDescuento.Autor_Fk))
                    {
                        articulo.Descuento = instanciaDescuento.Descuento;
                        articulo.Detalle_Descuento_Fk = instanciaDescuento.Id;
                    }
                }
            }

            RefrescarVenta();
        }

        private void RefrescarMensajeDescuento()
        {
            if (instanciaDescuento == null)
            {
                OcultarMensajeDescuento();
            }
            else
            {
                ActualizarMensajeDescuento();
            }
        }

        private void ActualizarMensajeDescuento()
        {
            lbl_desc_descuento.Visible = true;
            lbl_descuento.Text = instanciaDescuento.Descripcion;
            lbl_descuento.Visible = true;
            btn_eliminar_descuento.Visible = true;
        }

        private void OcultarMensajeDescuento()
        {
            lbl_desc_descuento.Visible = false;
            lbl_descuento.Text = string.Empty;
            lbl_descuento.Visible = false;
            btn_eliminar_descuento.Visible = false;
        }

        private DetalleDescuento SeleccionarDescuento()
        {
            try
            {
                return grv_descuentos.SelectedRows[0].DataBoundItem as DetalleDescuento;
            }
            catch
            {
                return null;
            }
        }

        private void grv_descuentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AsignarDescuento();
        }

        private void btn_eliminar_descuento_Click(object sender, EventArgs e)
        {
            LimpiarDescuento();
        }

        private void btn_descuentos_autor_Click(object sender, EventArgs e)
        {
            var data = _descuentoRepository.BuscarDescuentosVigentes();

            Expression<Func<DetalleDescuento, bool>> expression = d => d.Aplica_Autor ?? false;

            var grilla = new GrillaGenerica();
            grilla.GrillaRefrescada += (o, s) =>
            {
                s.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => c.Visible = false);

                s.Columns[nameof(DetalleDescuento.Descripcion)].Visible = true;
                s.Columns[nameof(DetalleDescuento.Descuento)].Visible = true;
            };

            grilla.RefrescarGrilla(data, expression);
            grilla.ShowDialog(this);
        }

        private void btn_descuentos_generos_Click(object sender, EventArgs e)
        {
            var data = _descuentoRepository.BuscarDescuentosVigentes();

            Expression<Func<DetalleDescuento, bool>> expression = d => d.Aplica_Genero ?? false;

            var grilla = new GrillaGenerica();
            grilla.GrillaRefrescada += (o, s) =>
            {
                s.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => c.Visible = false);

                s.Columns[nameof(DetalleDescuento.Descripcion)].Visible = true;
                s.Columns[nameof(DetalleDescuento.Descuento)].Visible = true;
            };
            grilla.RefrescarGrilla(data, expression);
            grilla.ShowDialog(this);
        }

        protected override IEnumerable<int> GetRolesPermitidos()
        {
            return new int[] { UserRoles.ADMIN,UserRoles.CAJERO, UserRoles.GERENTE_TECNOLOGIA, UserRoles.GERENTE_VENTAS };
        }

        private void btn_mostrar_factura_Click(object sender, EventArgs e)
        {
            var data = _facturas.ListarFactura();

        

            var grilla = new FormularioGrillaFactura();
            grilla.GrillaRefrescada += (o, s) =>
            {
                s.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => c.Visible = false);

                s.Columns[nameof(FacturaDTO.id)].Visible = true;
                s.Columns[nameof(FacturaDTO.fecha_reg)].Visible = true;
              
                s.Columns[nameof(FacturaDTO.nombres)].Visible = true;
                s.Columns[nameof(FacturaDTO.apellido)].Visible = true;

            };
            
            grilla.RefrescarGrilla(data.AsQueryable());
            grilla.ShowDialog(this);
        }

        private void txt_monto_efectivo_Leave(object sender, EventArgs e)
        {
            try
            {
                var monto = txt_monto_efectivo.Text;
                if (!ValidarFormatoMonto(monto))
                {
                    MessageBox.Show("Divisa no válida");
                    txt_monto_efectivo.Text = string.Empty;
                    return;
                }

                decimal montoDecimal = decimal.Parse(monto, CultureInfo.InvariantCulture);
                txt_monto_efectivo.Text = montoDecimal.ToString("0.00", CultureInfo.InvariantCulture);
            }
            catch 
            {
                MessageBox.Show("Divisa no válida");
                txt_monto_efectivo.Text = string.Empty;
                return;

            }
        }

        private bool ValidarFormatoMonto(string monto)
        {
            Regex regex;
            regex = new Regex(@"^[0-9]+(\.\d{1,2}){0,1}$"); //regex that matches disallowed text
            return regex.IsMatch(monto);
        }

        private void txt_monto_tarjeta_Leave(object sender, EventArgs e)
        {
            try
            {
                var monto = txt_monto_tarjeta.Text;
                if (!ValidarFormatoMonto(monto))
                {
                    MessageBox.Show("Divisa no válida");
                    txt_monto_tarjeta.Text = string.Empty;
                    return;
                }

                decimal montoDecimal = decimal.Parse(monto, CultureInfo.InvariantCulture);
                txt_monto_tarjeta.Text = montoDecimal.ToString("0.00", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Divisa no válida");
                txt_monto_tarjeta.Text = string.Empty;
                return;

            }
        }
    }
}
