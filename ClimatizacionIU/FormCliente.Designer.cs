﻿namespace ClimatizacionIU
{
    partial class FormCliente
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
            this.bBuscarPresu = new System.Windows.Forms.Button();
            this.dClientes = new System.Windows.Forms.DataGridView();
            this.bAgregarCli = new System.Windows.Forms.Button();
            this.tNomClienBuscador = new System.Windows.Forms.TextBox();
            this.bBuscarCli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // bBuscarPresu
            // 
            this.bBuscarPresu.Location = new System.Drawing.Point(507, 276);
            this.bBuscarPresu.Name = "bBuscarPresu";
            this.bBuscarPresu.Size = new System.Drawing.Size(105, 37);
            this.bBuscarPresu.TabIndex = 15;
            this.bBuscarPresu.Text = "Buscar Presupuestos";
            this.bBuscarPresu.UseVisualStyleBackColor = true;
            // 
            // dClientes
            // 
            this.dClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dClientes.Location = new System.Drawing.Point(144, 110);
            this.dClientes.Name = "dClientes";
            this.dClientes.ReadOnly = true;
            this.dClientes.Size = new System.Drawing.Size(468, 150);
            this.dClientes.TabIndex = 14;
            // 
            // bAgregarCli
            // 
            this.bAgregarCli.Location = new System.Drawing.Point(507, 34);
            this.bAgregarCli.Name = "bAgregarCli";
            this.bAgregarCli.Size = new System.Drawing.Size(105, 23);
            this.bAgregarCli.TabIndex = 13;
            this.bAgregarCli.Text = "Agregar Cliente";
            this.bAgregarCli.UseVisualStyleBackColor = true;
            this.bAgregarCli.Click += new System.EventHandler(this.bAgregarCli_Click);
            // 
            // tNomClienBuscador
            // 
            this.tNomClienBuscador.Location = new System.Drawing.Point(144, 37);
            this.tNomClienBuscador.Name = "tNomClienBuscador";
            this.tNomClienBuscador.Size = new System.Drawing.Size(210, 20);
            this.tNomClienBuscador.TabIndex = 12;
            // 
            // bBuscarCli
            // 
            this.bBuscarCli.Location = new System.Drawing.Point(395, 34);
            this.bBuscarCli.Name = "bBuscarCli";
            this.bBuscarCli.Size = new System.Drawing.Size(75, 23);
            this.bBuscarCli.TabIndex = 11;
            this.bBuscarCli.Text = "Buscar";
            this.bBuscarCli.UseVisualStyleBackColor = true;
            this.bBuscarCli.Click += new System.EventHandler(this.bBuscarCli_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 341);
            this.Controls.Add(this.bBuscarPresu);
            this.Controls.Add(this.dClientes);
            this.Controls.Add(this.bAgregarCli);
            this.Controls.Add(this.tNomClienBuscador);
            this.Controls.Add(this.bBuscarCli);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuscarPresu;
        private System.Windows.Forms.DataGridView dClientes;
        private System.Windows.Forms.Button bAgregarCli;
        private System.Windows.Forms.TextBox tNomClienBuscador;
        private System.Windows.Forms.Button bBuscarCli;
    }
}