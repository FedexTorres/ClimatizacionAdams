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
    public partial class FormDocumento : Form
    {
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
    }
}
