using Pringles.BLL;
using Pringles.DAL;
using Pringles.EE;
using Pringles.DAL.Validators;
using Pringles.Utilities.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pringles
{
    public partial class FormularioCliente : BaseForm
    {
        private readonly ClienteBLL clienteBLL;

        public FormularioCliente() : base()
        {
            RevisarRol();
            InitializeComponent();
            clienteBLL = new ClienteBLL(new ClienteRepository());
        }

        private bool ValidarEmail(string email)
        {
            string regex = @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])";
            return Regex.IsMatch(email, regex);
            
        }

        private void btn_alta_cliente_Click(object sender, EventArgs e)
        {
            var cliente = LeerCliente();
            if (!cliente.ValidarCliente())
            {
                MessageBox.Show(this, "Datos no validos");
                return;
            }

            if ((Math.Abs((cliente.Fecha_Nacimiento.Date - DateTime.Now.Date).TotalDays) / 365) < 18)
            {
                MessageBox.Show(this, "Cliente menor de edad.");
                return;
            }

            //if (!ValidarEmail(cliente.Email))
            //{
            //    MessageBox.Show("No se respeta el formato de e-mail");
            //    return;
            //}

            cliente.Fecha_Reg = DateTime.Now;
            AplicarAccion(cliente, clienteBLL.AltaCliente);
        }

        private void RefrescarGrilla()
        {
            grillaCliente.DataSource = null;
            grillaCliente.DataSource = clienteBLL.ListarClientes().ToList();

            grillaCliente.Columns[nameof(Cliente.Id)].Visible = false;
            grillaCliente.Columns[nameof(Cliente.Nombres)].Visible = false;
            grillaCliente.Columns[nameof(Cliente.Apellido)].Visible = false;
            grillaCliente.Columns[nameof(Cliente.Fecha_Modificacion)].Visible = false;
            grillaCliente.Columns[nameof(Cliente.Fecha_Reg)].Visible = false;
            grillaCliente.Columns[nameof(Cliente.Activo)].Visible = false;

            var nombreCompleto = grillaCliente.Columns[nameof(Cliente.NombreCompleto)];
            nombreCompleto.HeaderText = "Nombre del Cliente";
            nombreCompleto.DisplayIndex = 0;

            var fechaNacimiento = grillaCliente.Columns[nameof(Cliente.Fecha_Nacimiento)];
            fechaNacimiento.HeaderText = "Fecha de nacimiento";
            fechaNacimiento.DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private Cliente LeerCliente()
        {
            return new Cliente
            {
                Dni = txt_dni_cliente.Text.Trim(),
                Nombres = txt_nombre_cliente.Text.Trim(),
                Apellido = txt_apellido_cliente.Text.Trim(),
                Fecha_Nacimiento = dt_fecha_nacimiento_cliente.Value.Date,
                //Direccion = txt_direccion_cliente.Text.Trim(),
                //Celular = txt_celular_cliente.Text.Trim(),
                //Email = txt_email_cliente.Text.Trim(),
                //Telefono = txt_telefono_cliente.Text.Trim()
            };
        }

        private void btn_modificacion_cliente_Click(object sender, EventArgs e)
        {

            var cliente = SeleccionarCliente();
            if (cliente == null)
            {
                MessageBox.Show(this, "Error", "No se selecciono cliente a editar");
                return;
            }

            //if (!ValidarEmail(txt_email_cliente.Text.Trim()))
            //{
            //    MessageBox.Show("No se respeta el formato de e-mail");
            //    return;
            //}


            cliente.Nombres = txt_nombre_cliente.Text.Trim();
            cliente.Apellido = txt_apellido_cliente.Text.Trim();
            cliente.Fecha_Nacimiento = dt_fecha_nacimiento_cliente.Value.Date;
            //cliente.Direccion = txt_direccion_cliente.Text.Trim();
            //cliente.Celular = txt_celular_cliente.Text.Trim();
            //cliente.Email = txt_email_cliente.Text.Trim();
            //cliente.Telefono = txt_telefono_cliente.Text.Trim();
            cliente.Fecha_Modificacion = DateTime.Now;


            if ((Math.Abs((cliente.Fecha_Nacimiento.Date - DateTime.Now.Date).TotalDays) / 365) < 18)
            {
                MessageBox.Show(this, "Cliente menor de edad.");
                return;
            }

            AplicarAccion(cliente, clienteBLL.ModificarCliente);
        }

        private void btn_baja_cliente_Click(object sender, EventArgs e)
        {
            var cliente = SeleccionarCliente();
            if (cliente == null)
            {
                MessageBox.Show(this, "Error", "No se selecciono cliente a eliminar");
                return;
            }

            DialogResult result = MessageBox.Show(this, "Seguro que desea desvincular el cliente?", "", MessageBoxButtons.YesNo);

            if (!result.HasFlag(DialogResult.Yes))
                return;

            AplicarAccion(cliente, clienteBLL.DesvincularCliente);
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }

        /// <summary>
        /// Aplica una accion de a un genero.
        /// </summary>
        /// <param name="genero">Genero a utilizar.</param>
        /// <param name="action">Accion a aplicar.</param>
        private void AplicarAccion(Cliente cliente, Action<Cliente> action)
        {
            if (!cliente.ValidarCliente())
            {
                MessageBox.Show(this, "Datos no validos");
                return;
            }
            try
            {
                action.Invoke(cliente);
                RefrescarGrilla();
            }
            catch
            {
                MessageBox.Show(this, "Error agregando datos a la base de datos");
            }
        }

        /// <summary>
        /// Retorna el genero seleccionado de la grilla.
        /// Retorna null si no se pudo leer un genero.
        /// </summary>
        /// <returns></returns>
        private Cliente SeleccionarCliente()
        {
            try
            {
                var cliente = grillaCliente.SelectedRows[0].DataBoundItem as Cliente;
                return cliente;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void grillaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cliente = SeleccionarCliente();
            txt_nombre_cliente.Text = cliente.Nombres;
            txt_apellido_cliente.Text = cliente.Apellido;
            dt_fecha_nacimiento_cliente.Value = cliente.Fecha_Nacimiento;
            //txt_direccion_cliente.Text = cliente.Direccion;
            //txt_celular_cliente.Text = cliente.Celular;
            //txt_email_cliente.Text = cliente.Email;
            //txt_telefono_cliente.Text = cliente.Telefono;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = SeleccionarCliente();
            if (cliente == null)
            {
                MessageBox.Show(this, "Debe seleccionar un cliente");
                return;
            }
            FormularioHistorialCliente formulario = new FormularioHistorialCliente(cliente);
            if (!formulario.Disposing)
                formulario.ShowDialog(this);
        }

        private void btn_cliente_mas_compras_Click(object sender, EventArgs e)
        {
            Cliente cliente = clienteBLL.BuscarMejorCliente();
            if (cliente == null)
            {
                MessageBox.Show(this, "No hay registro de mejor cliente");
            }
            else
            {
                MessageBox.Show(this, $"DNI: {cliente.Dni}\nNombre: {cliente.NombreCompleto}");
            }
        }

        protected override IEnumerable<int> GetRolesPermitidos()
        {
            return new int[] { UserRoles.ADMIN, UserRoles.CAJERO, UserRoles.GERENTE_TECNOLOGIA, UserRoles.GERENTE_VENTAS };
        }

        private void btn_agregar_email_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = SeleccionarCliente();
                if (cliente == null)
                {
                    MessageBox.Show(this, "Debe seleccionar un cliente");
                    return;
                }
                FormularioEmail formulario = new FormularioEmail(cliente.Id);
                if (!formulario.Disposing)
                    formulario.ShowDialog(this);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_agregar_direccion_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = SeleccionarCliente();
                if (cliente == null)
                {
                    MessageBox.Show(this, "Debe seleccionar un cliente");
                    return;
                }
                FormularioDireccion formulario = new FormularioDireccion(cliente.Id);
                if (!formulario.Disposing)
                    formulario.ShowDialog(this);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_agregar_telefono_Click(object sender, EventArgs e)
        {
            try
            {
               var cliente = SeleccionarCliente();
               if (cliente == null)
               {
                    MessageBox.Show(this, "Debe seleccionar un cliente");
                    return;
               }
                FormularioAgregarTelefono formulario = new FormularioAgregarTelefono(cliente.Id);
                if (!formulario.Disposing)
                    formulario.ShowDialog(this);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
