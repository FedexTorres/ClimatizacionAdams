using ClimatizacionAdams;
using ClimatizacionBE;
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
    public partial class AgregarDocumento : Form
    {
        private DocumentoBLL documentoBLL = new DocumentoBLL();
        public AgregarDocumento()
        {
            InitializeComponent();

            cClientesTraidos.DataSource = documentoBLL.TraerListClientes();
            cTipoDocumento.DataSource = documentoBLL.LosTipos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TipoDocumentoBE tipo = (TipoDocumentoBE)cTipoDocumento.SelectedItem;
                ClienteBE cliente = (ClienteBE)cClientesTraidos.SelectedItem;
                DateTime fecha = dFechaDocumento.Value;
                string lugar = tLugar.Text;
                string montoTotal = tMontoTotal.Text;
                string montoMano = tMontoMano.Text;
                string montoMaterial = tMontoMateria.Text;
                string archivo = tNombreArchivo.Text;

                bool resultado = documentoBLL.DocumentoNuevo(tipo, cliente, fecha, lugar, montoTotal, montoMano, montoMaterial, archivo);

                if (resultado)
                {
                    MessageBox.Show("Documento Agregado exitosamente");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void tMontoTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tMontoMano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tMontoMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
