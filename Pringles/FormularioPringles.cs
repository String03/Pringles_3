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
    public partial class FormularioPringles : BaseForm
    {
        public FormularioPringles() : base()
        {
            InitializeComponent();
        }

        private void aBRIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioInventario formularioInventario = new FormularioInventario();
            formularioInventario.MdiParent = this;
            if (!formularioInventario.IsDisposed)
                formularioInventario.Show();
        }

        private void aBRIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormularioVenta formularioVenta = new FormularioVenta();
            formularioVenta.MdiParent = this;
            if (!formularioVenta.IsDisposed)
                formularioVenta.Show();
        }

        private void aBRIRToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormularioCliente formularioCliente = new FormularioCliente();
            formularioCliente.MdiParent = this;
            if (!formularioCliente.IsDisposed)
                formularioCliente.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aBRIRToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormularioUsuario formularioUsuario = new FormularioUsuario();
            formularioUsuario.MdiParent = this;
            if (!formularioUsuario.IsDisposed)
                formularioUsuario.Show();
        }

        private void aBRIRToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormularioCaja formularioCaja = new FormularioCaja();
            formularioCaja.MdiParent = this;
            if (!formularioCaja.IsDisposed)
                formularioCaja.Show();
        }

        private void aBRIRToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FormularioBuscarLibro formularioBuscarLibro = new FormularioBuscarLibro();
            formularioBuscarLibro.MdiParent = this;
            if (!formularioBuscarLibro.IsDisposed)
                formularioBuscarLibro.Show();
        }

        private void dESCUENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioDescuento formularioDescuento = new FormularioDescuento();
            formularioDescuento.MdiParent = this;
            if (!formularioDescuento.IsDisposed)
                formularioDescuento.Show();
        }

        private void aBRIRToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FormularioProveedor formularioProveedor = new FormularioProveedor();
            formularioProveedor.MdiParent = this;
            if (!formularioProveedor.IsDisposed)
                formularioProveedor.Show();
        }

        private void tIPOTELEFONOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioTipoTelefono formularioTipoTelefono = new FormularioTipoTelefono();
            formularioTipoTelefono.MdiParent = this;
            if (!formularioTipoTelefono.IsDisposed)
            {
                formularioTipoTelefono.Show();
            }
        }

        private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aBRIRToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FormularioTelefono formularioTelefono = new FormularioTelefono();
            formularioTelefono.MdiParent = this;
            if (!formularioTelefono.IsDisposed)
            {
                formularioTelefono.Show();
            }
        }
    }
}
