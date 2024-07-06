using ClimatizacionAdams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimatizacionIU
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        ClienteBLL cliente = new ClienteBLL();


        private void bBuscarCli_Click(object sender, EventArgs e)
        {
            string nom = tNomClienBuscador.Text;

            dClientes.DataSource = null;
            dClientes.DataSource = cliente.ObtenerCliente(nom);
            dClientes.Columns["Id"].Visible = false;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            dClientes.DataSource = cliente.TraerClientes();
            dClientes.Columns["Id"].Visible = false;
        }

        private void bAgregarCli_Click(object sender, EventArgs e)
        {
            AgregarCliente agregarCliente = new AgregarCliente();
            agregarCliente.ShowDialog();
        }
    }
}
