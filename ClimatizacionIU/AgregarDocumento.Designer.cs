namespace ClimatizacionIU
{
    partial class AgregarDocumento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cClientesTraidos = new System.Windows.Forms.ComboBox();
            this.dFechaDocumento = new System.Windows.Forms.DateTimePicker();
            this.tMontoTotal = new System.Windows.Forms.TextBox();
            this.tMontoMano = new System.Windows.Forms.TextBox();
            this.tMontoMateria = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tLugar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 72);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(84, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(338, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cTipoDocumento
            // 
            this.cTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cTipoDocumento.FormattingEnabled = true;
            this.cTipoDocumento.Location = new System.Drawing.Point(212, 57);
            this.cTipoDocumento.Name = "cTipoDocumento";
            this.cTipoDocumento.Size = new System.Drawing.Size(241, 21);
            this.cTipoDocumento.TabIndex = 1;
            // 
            // cClientesTraidos
            // 
            this.cClientesTraidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cClientesTraidos.FormattingEnabled = true;
            this.cClientesTraidos.Location = new System.Drawing.Point(212, 101);
            this.cClientesTraidos.Name = "cClientesTraidos";
            this.cClientesTraidos.Size = new System.Drawing.Size(241, 21);
            this.cClientesTraidos.TabIndex = 2;
            // 
            // dFechaDocumento
            // 
            this.dFechaDocumento.Location = new System.Drawing.Point(212, 145);
            this.dFechaDocumento.Name = "dFechaDocumento";
            this.dFechaDocumento.Size = new System.Drawing.Size(241, 20);
            this.dFechaDocumento.TabIndex = 3;
            // 
            // tMontoTotal
            // 
            this.tMontoTotal.Location = new System.Drawing.Point(212, 231);
            this.tMontoTotal.Name = "tMontoTotal";
            this.tMontoTotal.Size = new System.Drawing.Size(124, 20);
            this.tMontoTotal.TabIndex = 4;
            this.tMontoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tMontoTotal_KeyPress);
            // 
            // tMontoMano
            // 
            this.tMontoMano.Location = new System.Drawing.Point(212, 274);
            this.tMontoMano.Name = "tMontoMano";
            this.tMontoMano.Size = new System.Drawing.Size(124, 20);
            this.tMontoMano.TabIndex = 5;
            this.tMontoMano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tMontoMano_KeyPress);
            // 
            // tMontoMateria
            // 
            this.tMontoMateria.Location = new System.Drawing.Point(212, 317);
            this.tMontoMateria.Name = "tMontoMateria";
            this.tMontoMateria.Size = new System.Drawing.Size(124, 20);
            this.tMontoMateria.TabIndex = 6;
            this.tMontoMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tMontoMateria_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 10);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Monto Total (Opcional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto Mano de Obra (Opcional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Monto Materiales (Opcional)";
            // 
            // tLugar
            // 
            this.tLugar.Location = new System.Drawing.Point(212, 188);
            this.tLugar.Name = "tLugar";
            this.tLugar.Size = new System.Drawing.Size(241, 20);
            this.tLugar.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lugar (Opcional)";
            // 
            // AgregarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(512, 495);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tMontoMateria);
            this.Controls.Add(this.tMontoMano);
            this.Controls.Add(this.tLugar);
            this.Controls.Add(this.tMontoTotal);
            this.Controls.Add(this.dFechaDocumento);
            this.Controls.Add(this.cClientesTraidos);
            this.Controls.Add(this.cTipoDocumento);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarDocumento";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cTipoDocumento;
        private System.Windows.Forms.ComboBox cClientesTraidos;
        private System.Windows.Forms.DateTimePicker dFechaDocumento;
        private System.Windows.Forms.TextBox tMontoTotal;
        private System.Windows.Forms.TextBox tMontoMano;
        private System.Windows.Forms.TextBox tMontoMateria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tLugar;
        private System.Windows.Forms.Label label7;
    }
}