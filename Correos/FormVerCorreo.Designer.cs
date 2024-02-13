namespace Correos
{
    partial class FormVerCorreo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnResponder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "De:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asunto:";
            // 
            // lblRemitente
            // 
            this.lblRemitente.AutoSize = true;
            this.lblRemitente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemitente.Location = new System.Drawing.Point(183, 70);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(272, 25);
            this.lblRemitente.TabIndex = 4;
            this.lblRemitente.Text = "                                                    ";
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpo.Location = new System.Drawing.Point(110, 172);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCuerpo.Size = new System.Drawing.Size(401, 188);
            this.txtCuerpo.TabIndex = 5;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(191, 127);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(272, 25);
            this.lblAsunto.TabIndex = 6;
            this.lblAsunto.Text = "                                                    ";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(110, 385);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(149, 47);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnResponder
            // 
            this.btnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.Location = new System.Drawing.Point(362, 385);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(149, 47);
            this.btnResponder.TabIndex = 8;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click_1);
            // 
            // FormVerCorreo
            // 
            this.ClientSize = new System.Drawing.Size(610, 443);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.txtCuerpo);
            this.Controls.Add(this.lblRemitente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVerCorreo";
            this.Load += new System.EventHandler(this.FormVerCorreo_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnResponder;
    }
}

