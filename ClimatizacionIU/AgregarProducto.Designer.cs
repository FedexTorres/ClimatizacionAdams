namespace ClimatizacionIU
{
    partial class AgregarProducto
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
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tNombrePro = new System.Windows.Forms.TextBox();
            this.tCodigo = new System.Windows.Forms.TextBox();
            this.tPrecio = new System.Windows.Forms.TextBox();
            this.tMetrosCan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.bCancelar.FlatAppearance.BorderSize = 0;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point(83, 236);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(83, 34);
            this.bCancelar.TabIndex = 0;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.bAgregar.FlatAppearance.BorderSize = 0;
            this.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ForeColor = System.Drawing.Color.White;
            this.bAgregar.Location = new System.Drawing.Point(229, 236);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(83, 34);
            this.bAgregar.TabIndex = 1;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo Ansal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Metros/Cantidad";
            // 
            // tNombrePro
            // 
            this.tNombrePro.Location = new System.Drawing.Point(58, 65);
            this.tNombrePro.Name = "tNombrePro";
            this.tNombrePro.Size = new System.Drawing.Size(100, 20);
            this.tNombrePro.TabIndex = 6;
            // 
            // tCodigo
            // 
            this.tCodigo.Location = new System.Drawing.Point(229, 65);
            this.tCodigo.Name = "tCodigo";
            this.tCodigo.Size = new System.Drawing.Size(100, 20);
            this.tCodigo.TabIndex = 7;
            this.tCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tCodigo_KeyPress);
            // 
            // tPrecio
            // 
            this.tPrecio.Location = new System.Drawing.Point(58, 159);
            this.tPrecio.Name = "tPrecio";
            this.tPrecio.Size = new System.Drawing.Size(100, 20);
            this.tPrecio.TabIndex = 8;
            this.tPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPrecio_KeyPress);
            // 
            // tMetrosCan
            // 
            this.tMetrosCan.Location = new System.Drawing.Point(229, 159);
            this.tMetrosCan.Name = "tMetrosCan";
            this.tMetrosCan.Size = new System.Drawing.Size(100, 20);
            this.tMetrosCan.TabIndex = 9;
            this.tMetrosCan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tMetrosCan_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 10);
            this.panel1.TabIndex = 10;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(393, 302);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tMetrosCan);
            this.Controls.Add(this.tPrecio);
            this.Controls.Add(this.tCodigo);
            this.Controls.Add(this.tNombrePro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tNombrePro;
        private System.Windows.Forms.TextBox tCodigo;
        private System.Windows.Forms.TextBox tPrecio;
        private System.Windows.Forms.TextBox tMetrosCan;
        private System.Windows.Forms.Panel panel1;
    }
}