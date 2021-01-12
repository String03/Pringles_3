using Pringles.Contracts.Repositories;
using Pringles.DAL;
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
    public partial class FormularioAgregarTelefono : BaseForm
    {
        private ITelefonoRepository telefonoRepository = new TelefonoRepository();
        private ITelefonoClienteRepository telefonoClienteRepository = new TelefonoClienteRepository();

        private int _cliente_id;
        public FormularioAgregarTelefono(int cliente_id)
        {
            InitializeComponent();
            this._cliente_id = cliente_id;
            RefrescarGrillaTelefono(cliente_id);

        }

        private void RefrescarGrillaTelefono(int cliente_id)
        {
            grillaTelefonoCliente.DataSource = null;
            grillaTelefonoCliente.DataSource = telefonoRepository.BuscarTelefonoCliente(cliente_id);
        }

        private void FormularioAgregarTelefono_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_telefono_Click(object sender, EventArgs e)
        {
            RefrescarBuscarTelefono(txt_buscar_telefono.Text);

        }

        private void RefrescarBuscarTelefono(string v)
        {
            grillaTelefono.DataSource = null;
            grillaTelefono.DataSource = telefonoRepository.BuscarTelefono(v);
        }

        private void btn_relacionar_cliente_con_telefono_Click(object sender, EventArgs e)
        {
            var telefono = (TelefonoDTO)grillaTelefono.SelectedRows[0].DataBoundItem;
            if (telefono == null)
            {
                MessageBox.Show(this, "Debe seleccionar un teléfono");
                return;
            }

            var telefonoCliente = new TelefonoCliente
            {
                Cliente_fk = this._cliente_id,
                Telefono_fk = telefono.Id
            };

            if (telefonoClienteRepository.BuscarTelefonoCliente(telefonoCliente.Cliente_fk,telefonoCliente.Telefono_fk) != null)
            {
                MessageBox.Show("El cliente tiene este teléfono agregado");
                return;
            }

            telefonoClienteRepository.Save(telefonoCliente);
            RefrescarGrillaTelefono(this._cliente_id);
        }

        private void btn_quitar_relacion_Click(object sender, EventArgs e)
        {
            var telefono = (TelefonoClienteDTO)grillaTelefonoCliente.SelectedRows[0].DataBoundItem;
            if (telefono == null)
            {
                MessageBox.Show(this, "Debe seleccionar un teléfono");
                return;
            }

            var telefonoCliente = new TelefonoCliente
            {
                Id = telefono.Id
            };

           

            telefonoClienteRepository.Delete(telefonoCliente);
            RefrescarGrillaTelefono(this._cliente_id);
        }
    }   }
