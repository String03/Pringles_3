using Pringles.EE;
using System;
using System.Windows.Forms;
using Pringles.DAL.Validators;
using Pringles.BLL;
using Pringles.DAL;
using System.Linq;

namespace Pringles
{
    public partial class FormularioGenero : BaseForm
    {
        private readonly GeneroBLL generoBLL;

        public event EventHandler DatosGeneroActualizados;

        public FormularioGenero() : base()
        {
            InitializeComponent();
            generoBLL = new GeneroBLL(new Repository<Genero>());
            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            grillaGenero.DataSource = null;
            grillaGenero.DataSource = generoBLL.ListarGeneros().ToList();
        }

        private void btn_alta_genero_Click(object sender, EventArgs e)
        {
            var genero = LeerGenero();
            if (!genero.ValidarGenero())
            {
                MessageBox.Show(this, "Datos no validos");
                return;
            }

            AplicarAccion(genero, generoBLL.AltaGenero);
            DatosGeneroActualizados?.Invoke(this, new EventArgs());
        }

        private void btn_baja_genero_Click(object sender, EventArgs e)
        {
            var genero = SeleccionarGenero();
            if (genero == null)
            {
                MessageBox.Show(this, "Debe seleccionar un genero");
                return;
            }

            generoBLL.BajaGenero(genero);
            RefrescarGrilla();
            DatosGeneroActualizados?.Invoke(this, new EventArgs());
        }

        private void btn_modificacion_genero_Click(object sender, EventArgs e)
        {
            var genero = SeleccionarGenero();
            if (genero == null)
            {
                MessageBox.Show(this, "Error", "No se selecciono metodo a editar");
                return;
            }
            genero.Nombre = txt_nombre_genero.Text.Trim();

            AplicarAccion(genero, generoBLL.ModificarGenero);
            DatosGeneroActualizados?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Aplica una accion de a un genero.
        /// </summary>
        /// <param name="genero">Genero a utilizar.</param>
        /// <param name="action">Accion a aplicar.</param>
        private void AplicarAccion(Genero genero, Action<Genero> action)
        {
            if (!genero.ValidarGenero())
            {
                MessageBox.Show(this, "Datos no validos");
                return;
            }
            try
            {
                action.Invoke(genero);
                RefrescarGrilla();
            }
            catch
            {
                MessageBox.Show(this, "Error agregando datos a la base de datos");
            }
        }

        private Genero LeerGenero()
        {
            return new Genero
            {
                Nombre = txt_nombre_genero.Text.Trim()
            };
        }

        /// <summary>
        /// Retorna el genero seleccionado de la grilla.
        /// Retorna null si no se pudo leer un genero.
        /// </summary>
        /// <returns></returns>
        private Genero SeleccionarGenero()
        {
            try
            {
                var genero = grillaGenero.SelectedRows[0].DataBoundItem as Genero;
                return genero;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void FormularioGenero_Load(object sender, EventArgs e)
        {

        }
    }
}
