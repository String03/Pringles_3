using Pringles.BLL;
using Pringles.DAL;
using Pringles.DAL.Validators;
using Pringles.EE;
using Pringles.Utilities;
using Pringles.Utilities.Consts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Pringles
{
    public partial class FormularioUsuario : BaseForm
    {
        private readonly UsuarioBLL usuarioBLL;
        private readonly RolBLL _rolBLL;

        public FormularioUsuario() : base()
        {
            RevisarRol();
            InitializeComponent();
            usuarioBLL = new UsuarioBLL(new Repository<Usuario>());
            _rolBLL = new RolBLL(new RolesRepository());
            RefrescarGrilla();
            CargarRoles();
        }

        private Usuario LeerUsuario()
        {
            return new Usuario
            {
                Codigo_Empleado = txt_codigo_empleado_usuario.Text.Trim(),
                Nombres = txt_nombres_usuario.Text.Trim(),
                Apellido = txt_apellido_usuario.Text.Trim(),
                Nombre_Usuario = txt_nombre_del_usuario_usuario.Text.Trim(),
                Contrasenia = MD5PasswordHash.HashPassword(txt_contrasenia_usuario.Text),
                Rol_Id = Convert.ToInt32(cbo_rol_usuario.SelectedValue)
            };
        }

        private void AplicarAccion(Usuario usuario, Action<Usuario> action)
        {
            if (!usuario.ValidarUsuario())
            {
                MessageBox.Show(this, "Datos no validos");
                return;
            }
            try
            {
                action.Invoke(usuario);
                RefrescarGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Error agregando datos a la base de datos");
            }
        }

        private Usuario SeleccionarUsuario()
        {
            try
            {
                var usuario = grillaUsuario.SelectedRows[0].DataBoundItem as Usuario;
                return usuario;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private void RefrescarGrilla()
        {
            grillaUsuario.DataSource = null;
            grillaUsuario.DataSource = usuarioBLL.ListarUsuarios().ToList();

            grillaUsuario.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => c.Visible = false);

            var nombreUsuario = grillaUsuario.Columns[nameof(Usuario.Nombre_Usuario)];
            nombreUsuario.Visible = true;
            nombreUsuario.HeaderText = "Nombre del Usuario";

            var codigoEmpleado = grillaUsuario.Columns[nameof(Usuario.Codigo_Empleado)];
            codigoEmpleado.Visible = true;
            codigoEmpleado.HeaderText = "Código del Empleado";

            var nombreCompleto = grillaUsuario.Columns[nameof(Usuario.NombreCompleto)];
            nombreCompleto.Visible = true;
            nombreCompleto.HeaderText = "Nombre completo";

        }

        private void FormularioUsuario_Load(object sender, EventArgs e)
        {

        }

        private void CargarRoles()
        {
            var dataSource = _rolBLL.ListarRoles().ToList();
            cbo_rol_usuario.DataSource = dataSource;
            cbo_rol_usuario.ValueMember = "Id";
            cbo_rol_usuario.DisplayMember = "Descripcion";
        }

        private void LimpiarFormulario()
        {
            txt_codigo_empleado_usuario.Text = string.Empty;
            txt_nombres_usuario.Text = string.Empty;
            txt_apellido_usuario.Text = string.Empty;
            txt_nombre_del_usuario_usuario.Text = string.Empty;
            txt_contrasenia_usuario.Text = string.Empty;
        }

        private void btn_alta_usuario_Click(object sender, EventArgs e)
        {
            var usuario = LeerUsuario();
            if (!usuario.ValidarUsuario())
            {
                MessageBox.Show(this, "Datos no validos");
                return;
            }

            AplicarAccion(usuario, usuarioBLL.GuardarUsuarioNuevo);
            LimpiarFormulario();
            RefrescarGrilla();
        }


        private void btn_baja_usuario_Click(object sender, EventArgs e)
        {
            var usuario = SeleccionarUsuario();
            if (usuario == null)
            {
                MessageBox.Show(this, "Debe seleccionar un usuario");
            }
            usuarioBLL.EliminarUsuario(usuario);
            RefrescarGrilla();
        }

        private void btn_modificacion_usuario_Click(object sender, EventArgs e)
        {
            var usuario = SeleccionarUsuario();
            if (usuario == null)
            {
                MessageBox.Show(this, "Error", "No se seleccionó método a editar");
                return;
            }
            usuario.Nombres = txt_nombres_usuario.Text.Trim();
            usuario.Apellido = txt_apellido_usuario.Text.Trim();
            usuario.Nombre_Usuario = txt_nombre_del_usuario_usuario.Text.Trim();
            usuario.Codigo_Empleado = txt_codigo_empleado_usuario.Text.Trim();
            usuario.Rol_Id = Convert.ToInt32(cbo_rol_usuario.SelectedValue);

            AplicarAccion(usuario, usuarioBLL.ModificarUsuario);
        }

        protected override IEnumerable<int> GetRolesPermitidos()
        {
            return new int[] { UserRoles.ADMIN, UserRoles.GERENTE_TECNOLOGIA };
        }

        private void grillaUsuario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var usuario = SeleccionarUsuario();
            if (usuario == null)
                return;
            txt_nombres_usuario.Text = usuario.Nombres;
            txt_apellido_usuario.Text = usuario.Apellido;
            txt_nombre_del_usuario_usuario.Text = usuario.Nombre_Usuario;
            txt_codigo_empleado_usuario.Text = usuario.Codigo_Empleado;
            cbo_rol_usuario.SelectedValue = usuario.Rol_Id;
        }
    }
}
