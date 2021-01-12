using Pringles.EE;
using System.Globalization;
using System.Linq;

namespace Pringles
{
    public partial class FormularioDetalleLibro : BaseForm
    {
        private readonly Libro _libro;

        public FormularioDetalleLibro(Libro libro) : base()
        {
            InitializeComponent();

            _libro = libro;
            AgregarDetallesLibro();
        }

        private void AgregarDetallesLibro() 
        {
            lbl_autor.Text = string.Join(",",_libro.Autores.Select(a => a.NombreCompleto));
            lbl_genero.Text = _libro.Genero.Nombre;
            lbl_nombre.Text = _libro.Titulo.ToString();
            lbl_precio.Text = _libro.Monto_Unitario.ToString("0.00", CultureInfo.InvariantCulture);
        }
    }
}
