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
    public partial class EditarProducto : Form
    {
        private int produEditable;
        private ProductoBLL productoBLL = new ProductoBLL();

        public EditarProducto(int num)
        {
            InitializeComponent();
            produEditable = num;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            //consulta();
            ProductoBE productoBase = new ProductoBE();
            //ProductoBLL productoBLL = new ProductoBLL();

            productoBLL.TraerProductoBLL(productoBase, produEditable);

            tNombrePro.Text = productoBase.Nombre;
            tCodigo.Text = productoBase.Ansal.ToString();
            tPrecio.Text = productoBase.Precio.ToString();
            tMetrosCan.Text = productoBase.Cantidad.ToString();

        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            try
            {           
                string nombre = tNombrePro.Text;
                string codigo = tCodigo.Text;
                string precio = tPrecio.Text;
                string cantidad = tMetrosCan.Text;

                bool respuesta = productoBLL.ProductoModificado(nombre, codigo, precio, cantidad, produEditable);

                if (respuesta == true)
                {
                    MessageBox.Show("Producto Modificado exitosamente");
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
    }
}
