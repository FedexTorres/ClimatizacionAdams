namespace ClimatizacionIU
{
    partial class ModificarRuta
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
            this.tRuta = new System.Windows.Forms.TextBox();
            this.bExaminar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tRuta
            // 
            this.tRuta.Location = new System.Drawing.Point(68, 75);
            this.tRuta.Name = "tRuta";
            this.tRuta.ReadOnly = true;
            this.tRuta.Size = new System.Drawing.Size(244, 20);
            this.tRuta.TabIndex = 0;
            // 
            // bExaminar
            // 
            this.bExaminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.bExaminar.FlatAppearance.BorderSize = 0;
            this.bExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExaminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExaminar.ForeColor = System.Drawing.Color.White;
            this.bExaminar.Location = new System.Drawing.Point(318, 68);
            this.bExaminar.Name = "bExaminar";
            this.bExaminar.Size = new System.Drawing.Size(91, 32);
            this.bExaminar.TabIndex = 1;
            this.bExaminar.Text = "Examinar";
            this.bExaminar.UseVisualStyleBackColor = false;
            this.bExaminar.Click += new System.EventHandler(this.bExaminar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.bCancelar.FlatAppearance.BorderSize = 0;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point(85, 143);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(103, 37);
            this.bCancelar.TabIndex = 1;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.bGuardar.FlatAppearance.BorderSize = 0;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.ForeColor = System.Drawing.Color.White;
            this.bGuardar.Location = new System.Drawing.Point(318, 143);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(91, 37);
            this.bGuardar.TabIndex = 1;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 10);
            this.panel1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ModificarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(496, 209);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bExaminar);
            this.Controls.Add(this.tRuta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarRuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarRuta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tRuta;
        private System.Windows.Forms.Button bExaminar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}