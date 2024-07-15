namespace ClimatizacionIU
{
    partial class FormDocumento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tCodigoBuscar = new System.Windows.Forms.TextBox();
            this.bBuscarCodigo = new System.Windows.Forms.Button();
            this.bAgregarDocumento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dFechaBuscar = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bBuscarFecha = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bVerArchivo = new FontAwesome.Sharp.IconButton();
            this.dDeDocumentos = new System.Windows.Forms.DataGridView();
            this.bModiRuta = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dDeDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tCodigoBuscar
            // 
            this.tCodigoBuscar.Location = new System.Drawing.Point(79, 54);
            this.tCodigoBuscar.Name = "tCodigoBuscar";
            this.tCodigoBuscar.Size = new System.Drawing.Size(147, 20);
            this.tCodigoBuscar.TabIndex = 0;
            // 
            // bBuscarCodigo
            // 
            this.bBuscarCodigo.BackColor = System.Drawing.Color.RoyalBlue;
            this.bBuscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscarCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarCodigo.ForeColor = System.Drawing.Color.White;
            this.bBuscarCodigo.Location = new System.Drawing.Point(269, 46);
            this.bBuscarCodigo.Name = "bBuscarCodigo";
            this.bBuscarCodigo.Size = new System.Drawing.Size(75, 32);
            this.bBuscarCodigo.TabIndex = 1;
            this.bBuscarCodigo.Text = "Buscar";
            this.bBuscarCodigo.UseVisualStyleBackColor = false;
            this.bBuscarCodigo.Click += new System.EventHandler(this.bBuscarCodigo_Click);
            // 
            // bAgregarDocumento
            // 
            this.bAgregarDocumento.BackColor = System.Drawing.Color.RoyalBlue;
            this.bAgregarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregarDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregarDocumento.ForeColor = System.Drawing.Color.White;
            this.bAgregarDocumento.Location = new System.Drawing.Point(636, 28);
            this.bAgregarDocumento.Name = "bAgregarDocumento";
            this.bAgregarDocumento.Size = new System.Drawing.Size(109, 43);
            this.bAgregarDocumento.TabIndex = 2;
            this.bAgregarDocumento.Text = "Nuevo Presupuesto";
            this.bAgregarDocumento.UseVisualStyleBackColor = false;
            this.bAgregarDocumento.Click += new System.EventHandler(this.bAgregarDocumento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por Codigo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dFechaBuscar);
            this.panel1.Controls.Add(this.tCodigoBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bBuscarFecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bBuscarCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 89);
            this.panel1.TabIndex = 4;
            // 
            // dFechaBuscar
            // 
            this.dFechaBuscar.Location = new System.Drawing.Point(397, 54);
            this.dFechaBuscar.Name = "dFechaBuscar";
            this.dFechaBuscar.Size = new System.Drawing.Size(200, 20);
            this.dFechaBuscar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por Fecha";
            // 
            // bBuscarFecha
            // 
            this.bBuscarFecha.BackColor = System.Drawing.Color.RoyalBlue;
            this.bBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscarFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarFecha.ForeColor = System.Drawing.Color.White;
            this.bBuscarFecha.Location = new System.Drawing.Point(655, 46);
            this.bBuscarFecha.Name = "bBuscarFecha";
            this.bBuscarFecha.Size = new System.Drawing.Size(75, 28);
            this.bBuscarFecha.TabIndex = 1;
            this.bBuscarFecha.Text = "Buscar";
            this.bBuscarFecha.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bModiRuta);
            this.panel3.Controls.Add(this.bAgregarDocumento);
            this.panel3.Controls.Add(this.bVerArchivo);
            this.panel3.Controls.Add(this.dDeDocumentos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 243);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // bVerArchivo
            // 
            this.bVerArchivo.BackColor = System.Drawing.Color.RoyalBlue;
            this.bVerArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVerArchivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVerArchivo.ForeColor = System.Drawing.Color.White;
            this.bVerArchivo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bVerArchivo.IconColor = System.Drawing.Color.Black;
            this.bVerArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVerArchivo.Location = new System.Drawing.Point(636, 140);
            this.bVerArchivo.Name = "bVerArchivo";
            this.bVerArchivo.Size = new System.Drawing.Size(109, 43);
            this.bVerArchivo.TabIndex = 1;
            this.bVerArchivo.Text = "Ver Archivo";
            this.bVerArchivo.UseVisualStyleBackColor = false;
            this.bVerArchivo.Click += new System.EventHandler(this.bVerArchivo_Click);
            // 
            // dDeDocumentos
            // 
            this.dDeDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDeDocumentos.Location = new System.Drawing.Point(79, 30);
            this.dDeDocumentos.Name = "dDeDocumentos";
            this.dDeDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dDeDocumentos.Size = new System.Drawing.Size(518, 150);
            this.dDeDocumentos.TabIndex = 0;
            // 
            // bModiRuta
            // 
            this.bModiRuta.BackColor = System.Drawing.Color.RoyalBlue;
            this.bModiRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModiRuta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModiRuta.ForeColor = System.Drawing.Color.White;
            this.bModiRuta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bModiRuta.IconColor = System.Drawing.Color.Black;
            this.bModiRuta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bModiRuta.Location = new System.Drawing.Point(636, 84);
            this.bModiRuta.Name = "bModiRuta";
            this.bModiRuta.Size = new System.Drawing.Size(109, 43);
            this.bModiRuta.TabIndex = 1;
            this.bModiRuta.Text = "Modificar Ruta";
            this.bModiRuta.UseVisualStyleBackColor = false;
            this.bModiRuta.Click += new System.EventHandler(this.bModiRuta_Click);
            // 
            // FormDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 332);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormDocumento";
            this.Text = "FormDocumento";
            this.Load += new System.EventHandler(this.FormDocumento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dDeDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tCodigoBuscar;
        private System.Windows.Forms.Button bBuscarCodigo;
        private System.Windows.Forms.Button bAgregarDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dFechaBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bBuscarFecha;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton bVerArchivo;
        private System.Windows.Forms.DataGridView dDeDocumentos;
        private FontAwesome.Sharp.IconButton bModiRuta;
    }
}