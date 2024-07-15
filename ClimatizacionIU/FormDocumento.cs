using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClimatizacionAdams;
using ClimatizacionBE;
using ClimatizacionBLL;

namespace ClimatizacionIU
{
    public partial class FormDocumento : Form
    {
        private DocumentoBLL documentoBLL = new DocumentoBLL();
        public FormDocumento()
        {
            InitializeComponent();
        }

        private void bAgregarDocumento_Click(object sender, EventArgs e)
        {
            AgregarDocumento agregarDocumento = new AgregarDocumento();
            agregarDocumento.ShowDialog();
        }

        private void FormDocumento_Load(object sender, EventArgs e)
        {
            //lDeDocumentos.
        }

        private void bBuscarCodigo_Click(object sender, EventArgs e)
        {
            dDeDocumentos.DataSource = documentoBLL.TodosLosDocumentos(tCodigoBuscar.Text);
            dDeDocumentos.Columns["Tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dDeDocumentos.Columns["Nombre"].HeaderText = "Cliente";
        }

        private void bModiRuta_Click(object sender, EventArgs e)
        {
            try
            {
                if (dDeDocumentos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dDeDocumentos.SelectedRows[0];
                    string iddocumento = filaSeleccionada.Cells["Codigo_Asignado"].Value.ToString();

                    ModificarRuta modificarRuta = new ModificarRuta(iddocumento);
                    modificarRuta.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecccione un producto para editar");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void bVerArchivo_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (dDeDocumentos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dDeDocumentos.SelectedRows[0];
                    string iddocumento = filaSeleccionada.Cells["Codigo_Asignado"].Value.ToString();

                    var lista = documentoBLL.VerDocumento(iddocumento);

                    foreach (Documento item in lista)
                    {
                        //crea carpeta temporal donde se guardan archivos
                        string direccion = AppDomain.CurrentDomain.BaseDirectory;
                        string carpeta = direccion + "/temp/";
                        string ubicacionCompleta = carpeta + item.Extencion;

                        //validacioners
                        if (!Directory.Exists(carpeta))
                        {
                            Directory.CreateDirectory(carpeta);
                        }

                        if (File.Exists(ubicacionCompleta))
                        {
                            File.Delete(ubicacionCompleta);
                        }

                        File.WriteAllBytes(ubicacionCompleta, item.Archivo);
                        Process.Start(ubicacionCompleta);
                        //para que funcione se tiene que configurar el datagrid
                        //para que siempre seleccione la fila completa
                    }
                }
            //}
            //catch (Exception)
            //{
            //    //MessageBox.Show(ex.Message);
            //    throw;
            //}
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
