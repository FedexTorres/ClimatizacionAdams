namespace ClimatizacionIU
{
    partial class EditarProducto
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
            this.tMetrosCan = new System.Windows.Forms.TextBox();
            this.tPrecio = new System.Windows.Forms.TextBox();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.tNombrePro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // tMetrosCan
            // 
            this.tMetrosCan.Location = new System.Drawing.Point(227, 160);
            this.tMetrosCan.Name = "tMetrosCan";
            this.tMetrosCan.Size = new System.Drawing.Size(100, 20);
            this.tMetrosCan.TabIndex = 19;
            // 
            // tPrecio
            // 
            this.tPrecio.Location = new System.Drawing.Point(56, 160);
            this.tPrecio.Name = "tPrecio";
            this.tPrecio.Size = new System.Drawing.Size(100, 20);
            this.tPrecio.TabIndex = 18;
            // 
            // tCodigo
            // 
            this.tCodigo.Location = new System.Drawing.Point(227, 66);
            this.tCodigo.Name = "tCodigo";
            this.tCodigo.Size = new System.Drawing.Size(100, 20);
            this.tCodigo.TabIndex = 17;
            // 
            // tNombrePro
            // 
            this.tNombrePro.Location = new System.Drawing.Point(56, 66);
            this.tNombrePro.Name = "tNombrePro";
            this.tNombrePro.Size = new System.Drawing.Size(100, 20);
            this.tNombrePro.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Metros/Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo Ansal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre Producto";
            // 
            // bConfirmar
            // 
            this.bConfirmar.Location = new System.Drawing.Point(227, 237);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 11;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(81, 237);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 10;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(393, 10);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(393, 302);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tMetrosCan);
            this.Controls.Add(this.tPrecio);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.tNombrePro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.bCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProducto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tMetrosCan;
        private System.Windows.Forms.TextBox tPrecio;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.TextBox tNombrePro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}