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
    public partial class FormPaquete : Form
    {
        public FormPaquete()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            ProductoBLL productoBLL = new ProductoBLL();

            lPaquete1.Text = productoBLL.Paquete(1, 2, 7, 8, 12, 14).ToString("c");
            lPaquete2.Text = productoBLL.Paquete(1, 3, 7, 9, 12, 14).ToString("c");
            lPaquete3.Text = productoBLL.Paquete(2, 5, 8, 10, 13, 14).ToString("c");
            lPaquete4.Text = productoBLL.Paquete(2, 6, 8, 11, 13, 14).ToString("c");
        }


        private void bAccion_Click(object sender, EventArgs e)
        {

            Actualizar();
        }


        private void bAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.ShowDialog();
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dProducto.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dProducto.SelectedRows[0];
                    int idproducto = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);

                    EditarProducto editarProducto = new EditarProducto(idproducto);
                    editarProducto.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecccione un producto para editar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar los comandos. " + ex.Message);
            }
        }

        private void FormPaquete_Load(object sender, EventArgs e)
        {
            ProductoBLL productoBLL = new ProductoBLL();

            dProducto.DataSource = productoBLL.VerTodosLosProductos();
            dProducto.Columns[2].DefaultCellStyle.Format = "c";
        }
    }
}
