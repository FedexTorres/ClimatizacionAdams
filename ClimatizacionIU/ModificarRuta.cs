using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class ModificarRuta : Form
    {
        Documento documento = new Documento();
        DocumentoBLL documentoBLL = new DocumentoBLL();
        private string documentoEditable;
        public ModificarRuta(string docu)
        {
            InitializeComponent();
            documentoEditable = docu;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\megaf\\Desktop\\Trabajo de casa\\Archivos\\PDF";
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tRuta.Text = openFileDialog1.FileName;
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            byte[] archivo = null;
            Stream stream = openFileDialog1.OpenFile();
            MemoryStream memoryStream = new MemoryStream();

            stream.CopyTo(memoryStream);
            archivo = memoryStream.ToArray();

            //agregar
            documento.Codigo = documentoEditable;
            documento.Archivo = archivo;
            documento.Extencion = openFileDialog1.SafeFileName;
            MessageBox.Show(documentoBLL.AgregarRutaBLL(documento));
        }
    }
}
