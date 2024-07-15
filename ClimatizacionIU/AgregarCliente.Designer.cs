namespace ClimatizacionIU
{
    partial class AgregarCliente
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
            this.bCancelarCli = new System.Windows.Forms.Button();
            this.bConfirmarCli = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tNomCliente = new System.Windows.Forms.TextBox();
            this.tDireCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancelarCli
            // 
            this.bCancelarCli.BackColor = System.Drawing.Color.RoyalBlue;
            this.bCancelarCli.FlatAppearance.BorderSize = 0;
            this.bCancelarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelarCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelarCli.ForeColor = System.Drawing.Color.White;
            this.bCancelarCli.Location = new System.Drawing.Point(48, 190);
            this.bCancelarCli.Name = "bCancelarCli";
            this.bCancelarCli.Size = new System.Drawing.Size(75, 23);
            this.bCancelarCli.TabIndex = 0;
            this.bCancelarCli.Text = "Cancelar";
            this.bCancelarCli.UseVisualStyleBackColor = false;
            this.bCancelarCli.Click += new System.EventHandler(this.bCancelarCli_Click);
            // 
            // bConfirmarCli
            // 
            this.bConfirmarCli.BackColor = System.Drawing.Color.RoyalBlue;
            this.bConfirmarCli.FlatAppearance.BorderSize = 0;
            this.bConfirmarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfirmarCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmarCli.ForeColor = System.Drawing.Color.White;
            this.bConfirmarCli.Location = new System.Drawing.Point(251, 190);
            this.bConfirmarCli.Name = "bConfirmarCli";
            this.bConfirmarCli.Size = new System.Drawing.Size(75, 23);
            this.bConfirmarCli.TabIndex = 1;
            this.bConfirmarCli.Text = "Confirmar";
            this.bConfirmarCli.UseVisualStyleBackColor = false;
            this.bConfirmarCli.Click += new System.EventHandler(this.bConfirmarCli_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 10);
            this.panel1.TabIndex = 2;
            // 
            // tNomCliente
            // 
            this.tNomCliente.Location = new System.Drawing.Point(101, 77);
            this.tNomCliente.Name = "tNomCliente";
            this.tNomCliente.Size = new System.Drawing.Size(167, 20);
            this.tNomCliente.TabIndex = 3;
            // 
            // tDireCliente
            // 
            this.tDireCliente.Location = new System.Drawing.Point(101, 133);
            this.tDireCliente.Name = "tDireCliente";
            this.tDireCliente.Size = new System.Drawing.Size(167, 20);
            this.tDireCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion de Cliente";
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(377, 263);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tDireCliente);
            this.Controls.Add(this.tNomCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bConfirmarCli);
            this.Controls.Add(this.bCancelarCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelarCli;
        private System.Windows.Forms.Button bConfirmarCli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tNomCliente;
        private System.Windows.Forms.TextBox tDireCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}