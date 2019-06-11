namespace Esclavo
{
    partial class EsclavoForm
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
            this.txtPublica = new System.Windows.Forms.TextBox();
            this.txtPrivada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnImportarTDES = new System.Windows.Forms.Button();
            this.txtLlaveTDES = new System.Windows.Forms.TextBox();
            this.btnDesencriptarTDES = new System.Windows.Forms.Button();
            this.txtTDESDesencriptado = new System.Windows.Forms.TextBox();
            this.txtTextoEncriptar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.txtTextoEncriptado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportarTextoEncriptado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Claves RSA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPublica
            // 
            this.txtPublica.Location = new System.Drawing.Point(421, 45);
            this.txtPublica.Name = "txtPublica";
            this.txtPublica.ReadOnly = true;
            this.txtPublica.Size = new System.Drawing.Size(100, 20);
            this.txtPublica.TabIndex = 1;
            // 
            // txtPrivada
            // 
            this.txtPrivada.Location = new System.Drawing.Point(421, 80);
            this.txtPrivada.Name = "txtPrivada";
            this.txtPrivada.ReadOnly = true;
            this.txtPrivada.Size = new System.Drawing.Size(100, 20);
            this.txtPrivada.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Llave publica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Llave privada";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(537, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exportar clave publica";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnImportarTDES
            // 
            this.btnImportarTDES.Location = new System.Drawing.Point(27, 154);
            this.btnImportarTDES.Name = "btnImportarTDES";
            this.btnImportarTDES.Size = new System.Drawing.Size(117, 23);
            this.btnImportarTDES.TabIndex = 6;
            this.btnImportarTDES.Text = "Importar llaves TDES";
            this.btnImportarTDES.UseVisualStyleBackColor = true;
            this.btnImportarTDES.Click += new System.EventHandler(this.btnImportarTDES_Click);
            // 
            // txtLlaveTDES
            // 
            this.txtLlaveTDES.Location = new System.Drawing.Point(234, 157);
            this.txtLlaveTDES.Name = "txtLlaveTDES";
            this.txtLlaveTDES.ReadOnly = true;
            this.txtLlaveTDES.Size = new System.Drawing.Size(100, 20);
            this.txtLlaveTDES.TabIndex = 7;
            // 
            // btnDesencriptarTDES
            // 
            this.btnDesencriptarTDES.Enabled = false;
            this.btnDesencriptarTDES.Location = new System.Drawing.Point(27, 210);
            this.btnDesencriptarTDES.Name = "btnDesencriptarTDES";
            this.btnDesencriptarTDES.Size = new System.Drawing.Size(145, 23);
            this.btnDesencriptarTDES.TabIndex = 8;
            this.btnDesencriptarTDES.Text = "Desencriptar llave TDES";
            this.btnDesencriptarTDES.UseVisualStyleBackColor = true;
            this.btnDesencriptarTDES.Click += new System.EventHandler(this.btnDesencriptarTDES_Click);
            // 
            // txtTDESDesencriptado
            // 
            this.txtTDESDesencriptado.Location = new System.Drawing.Point(234, 213);
            this.txtTDESDesencriptado.Name = "txtTDESDesencriptado";
            this.txtTDESDesencriptado.ReadOnly = true;
            this.txtTDESDesencriptado.Size = new System.Drawing.Size(100, 20);
            this.txtTDESDesencriptado.TabIndex = 9;
            // 
            // txtTextoEncriptar
            // 
            this.txtTextoEncriptar.Location = new System.Drawing.Point(405, 270);
            this.txtTextoEncriptar.Name = "txtTextoEncriptar";
            this.txtTextoEncriptar.Size = new System.Drawing.Size(100, 20);
            this.txtTextoEncriptar.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingresa el texto a encriptar";
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(304, 314);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(104, 23);
            this.btnEncriptar.TabIndex = 12;
            this.btnEncriptar.Text = "Encriptar texto";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // txtTextoEncriptado
            // 
            this.txtTextoEncriptado.Location = new System.Drawing.Point(215, 358);
            this.txtTextoEncriptado.Name = "txtTextoEncriptado";
            this.txtTextoEncriptado.Size = new System.Drawing.Size(290, 20);
            this.txtTextoEncriptado.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Texto Encriptado";
            // 
            // btnExportarTextoEncriptado
            // 
            this.btnExportarTextoEncriptado.Location = new System.Drawing.Point(303, 394);
            this.btnExportarTextoEncriptado.Name = "btnExportarTextoEncriptado";
            this.btnExportarTextoEncriptado.Size = new System.Drawing.Size(105, 23);
            this.btnExportarTextoEncriptado.TabIndex = 15;
            this.btnExportarTextoEncriptado.Text = "EXPORTAR";
            this.btnExportarTextoEncriptado.UseVisualStyleBackColor = true;
            this.btnExportarTextoEncriptado.Click += new System.EventHandler(this.btnExportarTextoEncriptado_Click);
            // 
            // EsclavoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportarTextoEncriptado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTextoEncriptado);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTextoEncriptar);
            this.Controls.Add(this.txtTDESDesencriptado);
            this.Controls.Add(this.btnDesencriptarTDES);
            this.Controls.Add(this.txtLlaveTDES);
            this.Controls.Add(this.btnImportarTDES);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrivada);
            this.Controls.Add(this.txtPublica);
            this.Controls.Add(this.button1);
            this.Name = "EsclavoForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPublica;
        private System.Windows.Forms.TextBox txtPrivada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnImportarTDES;
        private System.Windows.Forms.TextBox txtLlaveTDES;
        private System.Windows.Forms.Button btnDesencriptarTDES;
        private System.Windows.Forms.TextBox txtTDESDesencriptado;
        private System.Windows.Forms.TextBox txtTextoEncriptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.TextBox txtTextoEncriptado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExportarTextoEncriptado;
    }
}

