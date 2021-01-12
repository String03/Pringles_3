using Pringles.BLL;
using Pringles.DAL;
using Pringles.DAL.Singletons;
using Pringles.EE;
using Pringles.Utilities.Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pringles.Utilities.Extensions;
using Pringles.DAL.Validators;

namespace Pringles
{
    public partial class FormularioAutor : BaseForm
    {
        private readonly AutorBLL autorBLL;

        public event EventHandler DatosAutorActualizados;

        public FormularioAutor() : base()
        {
            RevisarRol();
            InitializeComponent();
            autorBLL = new AutorBLL(new Repository<Autor>());
            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            grillaAutor.DataSource = null;
            grillaAutor.DataSource = autorBLL.ListarAutores().ToList();
        }

        private void AplicarAccion(Autor autor, Action<Autor> action)
        {
            if (!autor.ValidarAutor())
            {
                MessageBox.Show(this, "Datos no validos");
                return;
            }
            try
            {
                action.Invoke(autor);
                RefrescarGrilla();
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error agregando datos a la base de datos");
            }
        }

        private Autor LeerAutor()
        {
            return new Autor
            {
                Nombres = txt_nombre_autor.Text.Trim(),
                Apellido = txt_apellido_autor.Text.Trim()
            };
        }

        private Autor SeleccionarAutor()
        {
            try
            {
                var autor = grillaAutor.SelectedRows[0].DataBoundItem as Autor;
                return autor;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private void LimpiarFormulario()
        {
            txt_nombre_autor.Text = string.Empty;
            txt_apellido_autor.Text = string.Empty;
        }

        private void FormularioAutor_Load(object sender, EventArgs e)
        {

        }

        private void btn_alta_autor_Click(object sender, EventArgs e)
        {
            var autor = LeerAutor();
            if (!autor.ValidarAutor())
            {
                MessageBox.Show(this, "Datos no validos");
                return;
            }
            AplicarAccion(autor, autorBLL.GuardarAutorNuevo);
            //autorBLL.GuardarAutorNuevo(autor);
            LimpiarFormulario();
            RefrescarGrilla();
            DatosAutorActualizados?.Invoke(this, new EventArgs());
        }

        private void btn_baja_autor_Click(object sender, EventArgs e)
        {
            var autor = SeleccionarAutor();
            if (autor == null)
            {
                MessageBox.Show(this, "Debe seleccionar un autor");
            }

            autorBLL.EliminarAutor(autor);
            RefrescarGrilla();
            DatosAutorActualizados?.Invoke(this, new EventArgs());
        }

        private void btn_modificacion_autor_Click(object sender, EventArgs e)
        {
            var autor = SeleccionarAutor();
            if (autor == null)
            {
                MessageBox.Show(this, "Error", "No se selecciono metodo a editar");
                return;
            }
            autor.Nombres = txt_nombre_autor.Text.Trim();
            autor.Apellido = txt_apellido_autor.Text.Trim();

            AplicarAccion(autor, autorBLL.ModificarAutor);
            DatosAutorActualizados?.Invoke(this, new EventArgs());
        }

        protected override IEnumerable<int> GetRolesPermitidos()
        {
            return new int[] { UserRoles.ADMIN, UserRoles.CAJERO, UserRoles.GERENTE_ALMACEN, UserRoles.GERENTE_TECNOLOGIA };
        }
    }
}
