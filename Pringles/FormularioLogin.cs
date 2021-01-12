using Pringles.Contracts.Repositories;
using Pringles.DAL;
using Pringles.DAL.Singletons;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pringles
{
    public partial class FormularioLogin : BaseForm
    {
        private readonly ISeguridadRepository _seguridadRepository;
        private readonly IRolesRepository _rolesRepository;
        private readonly ICajaRepository _cajaRepository;

        public FormularioLogin() : base()
        {
            InitializeComponent();
            _seguridadRepository = new SeguridadRepository();
            _rolesRepository = new RolesRepository();
            _cajaRepository = new CajaRepository();

#if DEBUG
            txt_usuario_login.Text = "ADMIN";
            txt_contrasenia_login.Text = "ADMIN";
#endif
        }

        private void btn_aceptar_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (_seguridadRepository.AuthenticateUser(txt_usuario_login.Text.Trim(), txt_contrasenia_login.Text))
            {
                var user = _seguridadRepository.GetAll().First(c => string.Compare(txt_usuario_login.Text.Trim(), c.Nombre_Usuario) == 0);
                CurrentUser.GetCurrentInstance().SetRole(user);
                CurrentUser.GetCurrentInstance().SetUser(user);
                
                if (user.Caja_Fk != null)
                {
                    string hostname = System.Environment.MachineName;
                    var caja = _cajaRepository.BuscarCajaPorNombre(hostname);
                    CurrentCaja.GetInstance().SetCaja(caja);
                    //No se puede cambiar la referencia de la caja
                    //CurrentCaja.GetInstance().Caja = new EE.Caja();
                }
                Hide();
                new FormularioPringles().ShowDialog(this);
                Dispose();
            }
            else
            {
                MessageBox.Show(this, "Usuario y/o contrasena incorrectos");
            }
        }

        private void FormularioLogin_Load(object sender, EventArgs e)
        {

            if (!_cajaRepository.RevisarRegistrosCaja())
            {
                MessageBox.Show(this, "Primer login, creando caja por defecto.");
                try
                {
                    _cajaRepository.CrearCajaDefault();
                }
                catch
                {
                    MessageBox.Show(this, "Error creando usuario por defecto.");
                    Dispose();
                }
            }

            if (!_rolesRepository.CheckRolesExists())
            {
                MessageBox.Show(this, "Primer login, rol por defecto.");
                try
                {
                    _rolesRepository.CreateDefaultRole();
                }
                catch
                {
                    MessageBox.Show(this, "Error creando rol por defecto.");
                    Dispose();
                }
            }

            if (!_seguridadRepository.CheckUserExists())
            {
                MessageBox.Show(this, "Primer login, creando usuario ADMIN por defecto");
                try
                {
                    _seguridadRepository.CreateDefaultAdmin();
                }
                catch
                {
                    MessageBox.Show(this, "Error creando usuario por defecto.");
                    Dispose();
                }
            }
        }

        private void txt_usuario_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void txt_contrasenia_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }
    }
}
