using Pringles.Contracts.Repositories;
using Pringles.DAL;
using Pringles.DAL.Singletons;
using Pringles.EE;
using Pringles.Utilities.Exceptions;
using Pringles.Utilities.Consts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pringles
{
    public partial class FormularioCaja : BaseForm
    {
        private readonly IRegistroCajaRepository _registroCajaRepository;

        private Caja _cajaActual;
        private Usuario _usuarioActual;

        public FormularioCaja() : base()
        {
            RevisarRol();
            InitializeComponent();
            _registroCajaRepository = new RegistroCajaRepository();
            _cajaActual = CurrentCaja.GetInstance().Caja;
            _usuarioActual = CurrentUser.GetCurrentInstance().Usuario;

            if (_cajaActual == null || _usuarioActual == null)
            {
                MessageBox.Show("No se puede realizar esta operacion.");
                Dispose();
            }
        }

        private void btn_inicializar_caja_Click(object sender, EventArgs e)
        {
            try
            {
                decimal montoInicio;

                if (!decimal.TryParse(txt_inicia_caja.Text, out montoInicio))
                {
                    MessageBox.Show("Monto no valido");
                    return;
                }

                _registroCajaRepository.InicializarRegistroCaja(montoInicio, _usuarioActual.Id, _cajaActual.Id);

                txt_inicia_caja.Text = string.Empty;

                MessageBox.Show($"Se ha creado registro de la caja {_cajaActual.Descripcion}");
            }
            catch (CajaAbiertaException)
            {
                MessageBox.Show("Esta caja se encuentra abierta.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error creando el registro de caja");
            }
        }

        private void btn_cerrar_caja_Click(object sender, EventArgs e)
        {
            try
            {
                _registroCajaRepository.CerrarCaja(_cajaActual.Id);
                MessageBox.Show($"Se ha realizado el cierre de la caja {_cajaActual.Descripcion}");
            }
            catch (CajaCerradaException)
            {
                MessageBox.Show("Esta caja se encuentra cerrada.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error creando el registro de caja");
            }
        }

        private void FormularioCaja_Load(object sender, EventArgs e)
        {

        }

        protected override IEnumerable<int> GetRolesPermitidos()
        {
            return new int[] { UserRoles.ADMIN, UserRoles.GERENTE_VENTAS, UserRoles.GERENTE_TECNOLOGIA };
        }
    }
}
