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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoBLL producto = new ProductoBLL();

                string nombre = tNombrePro.Text;
                string codigo = tCodigo.Text;
                string precio = tPrecio.Text;
                string cantidad = tMetrosCan.Text;

                bool respuesta = producto.ProductoAgregado(nombre, codigo, precio, cantidad);

                if (respuesta == true)
                {
                    MessageBox.Show("Producto agregado exitosamente");
                    this.Close();
                }
                else if (respuesta == false)
                {
                    MessageBox.Show("Fallo al agregar un producto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void tCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tMetrosCan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
