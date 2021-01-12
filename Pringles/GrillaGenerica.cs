using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pringles
{
    public partial class GrillaGenerica : BaseForm
    {
        public event EventHandler<DataGridView> GrillaRefrescada;
        public event EventHandler<object> LineaSeleccionada;

        public GrillaGenerica()
        {
            InitializeComponent();
        }

        public void RefrescarGrilla<T>(IQueryable<T> datos)
        {
            grv_generico.DataSource = null;
            grv_generico.DataSource = datos.ToList();
            GrillaRefrescada?.Invoke(this, grv_generico);
        }

        public void RefrescarGrilla<T>(IQueryable<T> datos, Expression<Func<T, bool>> expression)
        {
            RefrescarGrilla(datos.Where(expression));
        }

        protected void OnGrillaRefrescada(EventHandler<DataGridView> handler)
        {
            GrillaRefrescada = handler;

            GrillaRefrescada?.Invoke(this, grv_generico);
        }

        protected void grv_generico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object seleccion = grv_generico.SelectedRows[0].DataBoundItem;
            LineaSeleccionada?.Invoke(this, seleccion);
        }

        private void GrillaGenerica_Load(object sender, EventArgs e)
        {

        }
    }
}
