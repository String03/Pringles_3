using Pringles.Contracts.Repositories;
using Pringles.DAL;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pringles
{
    public partial class FormularioRecibirLibros : BaseForm
    {
        private readonly ILibroRepository libroRepository;
        private readonly ICompraRepository compraRepository;

        public FormularioRecibirLibros()
        {
            InitializeComponent();
            libroRepository = new LibroRepository();
            compraRepository = new CompraRepository();
            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            grillaLibrosRecibidos.DataSource = null;
            grillaLibrosRecibidos.DataSource = libroRepository.BuscarComprasPendientes().ToList();
            //ConfigurarGrilla(grillaLibrosRecibidos);
        }

        private void ConfigurarGrilla(DataGridView grillaLibrosRecibidos)
        {
            grillaLibrosRecibidos.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => c.Visible = false);

            var titulo = grillaLibrosRecibidos.Columns[nameof(ComprasPendientesDTO.titulo)];
            titulo.Visible = true;
            titulo.HeaderText = "Titulo";
            titulo.DisplayIndex = 0;

            var razonSocial = grillaLibrosRecibidos.Columns[nameof(ComprasPendientesDTO.razon_social)];
            razonSocial.Visible = true;
            razonSocial.HeaderText = "Razon Social";
            razonSocial.DisplayIndex = 0;
        }

        private void btn_libros_recibidos_Click(object sender, EventArgs e)
        {
            ComprasPendientesDTO compraPendiente = SeleccionarCompraPendiente();

            if (compraPendiente == null)
            {
                MessageBox.Show(this, "Debe de seleccionar una compra pendiente");
                return;
            }

            RecibirCompra(compraPendiente);
            RefrescarGrilla();
        }

        private void RecibirCompra(ComprasPendientesDTO compraPendiente)
        {
            Compra compra = compraRepository.Find(compraPendiente.id);
            compra.Recibido = true;
            compra.Fecha_de_Recepcion = DateTime.Now;
            compraRepository.Update(compra);
        }

        private ComprasPendientesDTO SeleccionarCompraPendiente()
        {
            try
            {
                return grillaLibrosRecibidos.SelectedRows[0].DataBoundItem as ComprasPendientesDTO;
            }
            catch
            {
                return null;
            }
        }

        private void FormularioRecibirLibros_Load(object sender, EventArgs e)
        {

        }
    }
}
