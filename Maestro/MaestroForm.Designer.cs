﻿namespace Maestro
{
    partial class MaestroForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnCrearTDES = new System.Windows.Forms.Button();
            this.txtTDES = new System.Windows.Forms.TextBox();
            this.txtLlavePublica = new System.Windows.Forms.TextBox();
            this.txtLlavePrivada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLlavePublicaEsclavo = new System.Windows.Forms.TextBox();
            this.btnEncriptarTDES = new System.Windows.Forms.Button();
            this.txtTDESEncriptado = new System.Windows.Forms.TextBox();
            this.btnImportarTexto = new System.Windows.Forms.Button();
            this.txtTextoEncriptado = new System.Windows.Forms.TextBox();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTextoOriginal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Claves RSA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnImportar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnImportar.Location = new System.Drawing.Point(21, 115);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(178, 36);
            this.btnImportar.TabIndex = 5;
            this.btnImportar.Text = "Importar clave publica esclavo";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnCrearTDES
            // 
            this.btnCrearTDES.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCrearTDES.Enabled = false;
            this.btnCrearTDES.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnCrearTDES.Location = new System.Drawing.Point(21, 165);
            this.btnCrearTDES.Name = "btnCrearTDES";
            this.btnCrearTDES.Size = new System.Drawing.Size(140, 37);
            this.btnCrearTDES.TabIndex = 6;
            this.btnCrearTDES.Text = "Generar Clave TDES";
            this.btnCrearTDES.UseVisualStyleBackColor = false;
            this.btnCrearTDES.Click += new System.EventHandler(this.btnCrearTDES_Click);
            // 
            // txtTDES
            // 
            this.txtTDES.Location = new System.Drawing.Point(244, 174);
            this.txtTDES.Name = "txtTDES";
            this.txtTDES.ReadOnly = true;
            this.txtTDES.Size = new System.Drawing.Size(463, 20);
            this.txtTDES.TabIndex = 7;
            // 
            // txtLlavePublica
            // 
            this.txtLlavePublica.Location = new System.Drawing.Point(244, 31);
            this.txtLlavePublica.Name = "txtLlavePublica";
            this.txtLlavePublica.ReadOnly = true;
            this.txtLlavePublica.Size = new System.Drawing.Size(424, 20);
            this.txtLlavePublica.TabIndex = 8;
            // 
            // txtLlavePrivada
            // 
            this.txtLlavePrivada.Location = new System.Drawing.Point(244, 57);
            this.txtLlavePrivada.Name = "txtLlavePrivada";
            this.txtLlavePrivada.ReadOnly = true;
            this.txtLlavePrivada.Size = new System.Drawing.Size(424, 20);
            this.txtLlavePrivada.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Clave publica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Clave privada";
            // 
            // txtLlavePublicaEsclavo
            // 
            this.txtLlavePublicaEsclavo.Location = new System.Drawing.Point(244, 124);
            this.txtLlavePublicaEsclavo.Name = "txtLlavePublicaEsclavo";
            this.txtLlavePublicaEsclavo.ReadOnly = true;
            this.txtLlavePublicaEsclavo.Size = new System.Drawing.Size(463, 20);
            this.txtLlavePublicaEsclavo.TabIndex = 12;
            // 
            // btnEncriptarTDES
            // 
            this.btnEncriptarTDES.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEncriptarTDES.Enabled = false;
            this.btnEncriptarTDES.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnEncriptarTDES.Location = new System.Drawing.Point(21, 219);
            this.btnEncriptarTDES.Name = "btnEncriptarTDES";
            this.btnEncriptarTDES.Size = new System.Drawing.Size(140, 32);
            this.btnEncriptarTDES.TabIndex = 13;
            this.btnEncriptarTDES.Text = "Encriptar llave TDES";
            this.btnEncriptarTDES.UseVisualStyleBackColor = false;
            this.btnEncriptarTDES.Click += new System.EventHandler(this.btnEncriptarTDES_Click);
            // 
            // txtTDESEncriptado
            // 
            this.txtTDESEncriptado.Location = new System.Drawing.Point(244, 226);
            this.txtTDESEncriptado.Name = "txtTDESEncriptado";
            this.txtTDESEncriptado.ReadOnly = true;
            this.txtTDESEncriptado.Size = new System.Drawing.Size(463, 20);
            this.txtTDESEncriptado.TabIndex = 14;
            // 
            // btnImportarTexto
            // 
            this.btnImportarTexto.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnImportarTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnImportarTexto.Location = new System.Drawing.Point(167, 283);
            this.btnImportarTexto.Name = "btnImportarTexto";
            this.btnImportarTexto.Size = new System.Drawing.Size(157, 34);
            this.btnImportarTexto.TabIndex = 15;
            this.btnImportarTexto.Text = "Importar texto encriptado";
            this.btnImportarTexto.UseVisualStyleBackColor = false;
            this.btnImportarTexto.Click += new System.EventHandler(this.btnImportarTexto_Click);
            // 
            // txtTextoEncriptado
            // 
            this.txtTextoEncriptado.Location = new System.Drawing.Point(330, 291);
            this.txtTextoEncriptado.Name = "txtTextoEncriptado";
            this.txtTextoEncriptado.ReadOnly = true;
            this.txtTextoEncriptado.Size = new System.Drawing.Size(338, 20);
            this.txtTextoEncriptado.TabIndex = 16;
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDesencriptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic);
            this.btnDesencriptar.Location = new System.Drawing.Point(167, 323);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(157, 45);
            this.btnDesencriptar.TabIndex = 17;
            this.btnDesencriptar.Text = "DESENCRIPTAR";
            this.btnDesencriptar.UseVisualStyleBackColor = false;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(226, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Texto Original";
            // 
            // txtTextoOriginal
            // 
            this.txtTextoOriginal.Location = new System.Drawing.Point(330, 378);
            this.txtTextoOriginal.Name = "txtTextoOriginal";
            this.txtTextoOriginal.Size = new System.Drawing.Size(338, 20);
            this.txtTextoOriginal.TabIndex = 19;
            // 
            // MaestroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTextoOriginal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.txtTextoEncriptado);
            this.Controls.Add(this.btnImportarTexto);
            this.Controls.Add(this.txtTDESEncriptado);
            this.Controls.Add(this.btnEncriptarTDES);
            this.Controls.Add(this.txtLlavePublicaEsclavo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLlavePrivada);
            this.Controls.Add(this.txtLlavePublica);
            this.Controls.Add(this.txtTDES);
            this.Controls.Add(this.btnCrearTDES);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "MaestroForm";
            this.Text = "Maestro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnCrearTDES;
        private System.Windows.Forms.TextBox txtTDES;
        private System.Windows.Forms.TextBox txtLlavePublica;
        private System.Windows.Forms.TextBox txtLlavePrivada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLlavePublicaEsclavo;
        private System.Windows.Forms.Button btnEncriptarTDES;
        private System.Windows.Forms.TextBox txtTDESEncriptado;
        private System.Windows.Forms.Button btnImportarTexto;
        private System.Windows.Forms.TextBox txtTextoEncriptado;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTextoOriginal;
    }
}

