namespace Correos
{
    partial class FormNuevoCorreo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creación de Correos";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(227, 68);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(253, 26);
            this.txtDestinatario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destinatario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asunto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Redactar correo";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(227, 127);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(253, 26);
            this.txtAsunto.TabIndex = 5;
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpo.Location = new System.Drawing.Point(86, 225);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(427, 169);
            this.txtCuerpo.TabIndex = 6;
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarVentana.Location = new System.Drawing.Point(92, 422);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(121, 36);
            this.btnCerrarVentana.TabIndex = 7;
            this.btnCerrarVentana.Text = "Cerrar";
            this.btnCerrarVentana.UseVisualStyleBackColor = true;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click_1);
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCorreo.Location = new System.Drawing.Point(361, 422);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(139, 36);
            this.btnEnviarCorreo.TabIndex = 8;
            this.btnEnviarCorreo.Text = "Enviar correo";
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click_1);
            // 
            // FormNuevoCorreo
            // 
            this.ClientSize = new System.Drawing.Size(603, 477);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.txtCuerpo);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.label1);
            this.Name = "FormNuevoCorreo";
            this.Load += new System.EventHandler(this.FormNuevoCorreo_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.Button btnEnviarCorreo;
    }
}

