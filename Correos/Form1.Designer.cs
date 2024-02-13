namespace Correos
{
    partial class Form1
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
            this.listBoxCorreos = new System.Windows.Forms.ListBox();
            this.btnCrearCorreo = new System.Windows.Forms.Button();
            this.btnActualizarFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo Electronico";
            // 
            // listBoxCorreos
            // 
            this.listBoxCorreos.FormattingEnabled = true;
            this.listBoxCorreos.ItemHeight = 20;
            this.listBoxCorreos.Location = new System.Drawing.Point(92, 171);
            this.listBoxCorreos.Name = "listBoxCorreos";
            this.listBoxCorreos.Size = new System.Drawing.Size(563, 304);
            this.listBoxCorreos.TabIndex = 1;
            this.listBoxCorreos.SelectedIndexChanged += new System.EventHandler(this.listBoxCorreos_SelectedIndexChanged_1);
            // 
            // btnCrearCorreo
            // 
            this.btnCrearCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCorreo.Location = new System.Drawing.Point(92, 93);
            this.btnCrearCorreo.Name = "btnCrearCorreo";
            this.btnCrearCorreo.Size = new System.Drawing.Size(167, 52);
            this.btnCrearCorreo.TabIndex = 2;
            this.btnCrearCorreo.Text = "Crear Correo";
            this.btnCrearCorreo.UseVisualStyleBackColor = true;
            this.btnCrearCorreo.Click += new System.EventHandler(this.btnCrearCorreo_Click_1);
            // 
            // btnActualizarFeed
            // 
            this.btnActualizarFeed.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarFeed.Location = new System.Drawing.Point(451, 92);
            this.btnActualizarFeed.Name = "btnActualizarFeed";
            this.btnActualizarFeed.Size = new System.Drawing.Size(163, 53);
            this.btnActualizarFeed.TabIndex = 3;
            this.btnActualizarFeed.Text = "Actualizar";
            this.btnActualizarFeed.UseVisualStyleBackColor = true;
            this.btnActualizarFeed.Click += new System.EventHandler(this.btnActualizarFeed_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 540);
            this.Controls.Add(this.btnActualizarFeed);
            this.Controls.Add(this.btnCrearCorreo);
            this.Controls.Add(this.listBoxCorreos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCorreos;
        private System.Windows.Forms.Button btnCrearCorreo;
        private System.Windows.Forms.Button btnActualizarFeed;
    }
}

