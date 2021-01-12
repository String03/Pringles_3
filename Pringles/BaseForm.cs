using Pringles.DAL.Singletons;
using Pringles.EE;
using Pringles.Utilities.Consts;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pringles
{
    /// <summary>
    /// Formulario base del sistema.
    /// </summary>
    public class BaseForm : Form
    {
        public BaseForm()
        {
            this.Icon = Properties.Resources.Icon;
        }

        /// <summary>
        /// Retorna el rol del usuario actual.
        /// </summary>
        /// <returns></returns>
        protected Rol ObtenerRolActualUsuario() 
        {
            return CurrentUser.GetCurrentInstance().Rol;
        }

        /// <summary>
        /// Revisa si un usuario tiene permiso. En caso de no tener
        /// muestra mensaje y cierra el formulario.
        /// </summary>
        protected virtual void RevisarRol()
        {
            if (!TieneAcceso())
            {
                MessageBox.Show("No cuenta con el permiso para esta vista");
                Close();
            }
        }

        /// <summary>
        /// Retorna si el usuario tiene accesos en la pantalla actual.
        /// </summary>
        /// <returns></returns>
        protected bool TieneAcceso()
        {
            var rolesPermitidos = GetRolesPermitidos();
            return TieneAcceso(rolesPermitidos);
        }

        /// <summary>
        /// Retorna si el usuario tiene accesos en la pantalla actual.
        /// </summary>
        /// <param name="rolesPermitidos">Roles a evaluar.</param>
        /// <returns></returns>
        protected bool TieneAcceso(IEnumerable<int> rolesPermitidos)
        {
            Rol rolUsuario = ObtenerRolActualUsuario();
            if (rolesPermitidos == null)
                return false;
            return rolesPermitidos.Any(c => c == rolUsuario.Codigo_Rol);
        }

        /// <summary>
        /// Retorna los roles que estan permitidos en este formulario.
        /// </summary>
        /// <returns></returns>
        protected virtual IEnumerable<int> GetRolesPermitidos()
        {
            return new int[] { UserRoles.ADMIN };
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
