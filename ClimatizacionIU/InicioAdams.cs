using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimatizacionIU
{
    public partial class InicioAdams : Form
    {
        public InicioAdams()
        {
            InitializeComponent();
            SidePanel.Height = bPaquete.Height;
            SidePanel.Top = bPaquete.Top;
            //openChildFormInPanel(new FormPaquete());


            //Form modificable
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }



        //Codigo para mover el form desde el panelMovediso
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelMovediso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //......................//



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        //Manejo de Form dentro del panel
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Anchor =  AnchorStyles.Top;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //.......................//
        private void InicioAdams_Load(object sender, EventArgs e)
        {

        }

        private void bPaquete_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bPaquete.Height;
            SidePanel.Top = bPaquete.Top;
            ActivateButton(sender);
            openChildFormInPanel(new FormPaquete());
        }

        private void bClie_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bClie.Height;
            SidePanel.Top = bClie.Top;
            ActivateButton(sender);
            openChildFormInPanel(new FormCliente());
        }

        private void bPresupuestos_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bPresupuestos.Height;
            SidePanel.Top = bPresupuestos.Top;
            ActivateButton(sender);
            openChildFormInPanel(new FormDocumento());
        }


        //...................//
        //Manejo de botones de lado//
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                SidePanel.BringToFront();
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.SystemColors.ControlDark;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        //....................//



    }
}
