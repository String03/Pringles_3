using Pringles.EE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pringles
{
    public partial class GrillaGenericaCriterioLibro : GrillaGenerica
    {
        protected Libro libroSeleccionado = new Libro();
        public Libro LibroSeleccionado { get { return libroSeleccionado; } }

        public GrillaGenericaCriterioLibro(Libro libro)
        {
            InitializeComponent();
            this.libroSeleccionado = libro;
        }
    }
}
