using ClimatizacionAdams;
using ClimatizacionBLL;
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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void bCancelarCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bConfirmarCli_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteBLL cliente = new ClienteBLL();

                string nombre = tNomCliente.Text;
                string codigo = tDireCliente.Text;

                bool respuesta = cliente.ClienteAgregado(nombre, codigo);

                if (respuesta == true)
                {
                    MessageBox.Show("Cliente agregado exitosamente");
                    this.Close();
                }
                else if (respuesta == false)
                {
                    MessageBox.Show("Fallo al agregar un cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
