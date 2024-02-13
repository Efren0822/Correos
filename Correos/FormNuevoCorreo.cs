using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Correos
{
    public partial class FormNuevoCorreo : Form
    {
        public FormNuevoCorreo()
        {
            InitializeComponent();
        }

        private void FormNuevoCorreo_Load(object sender, EventArgs e)
        {

        }
        public void PreencherDestinatario(string destinatario)
        {
           
            txtDestinatario.Text = destinatario;
        }

        public void PreencherAsunto(string asunto)
        {
            
            txtAsunto.Text = asunto;
        }
        private void FormNuevoCorreo_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCerrarVentana_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarCorreo_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587; 
                smtpClient.Credentials = new NetworkCredential("ejercicios.uttt@gmail.com", "ltxb dtmi wjgh xilv");
                smtpClient.EnableSsl = true;

                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("ejercicios.uttt@gmail.com");
                correo.To.Add(txtDestinatario.Text);
                correo.Subject = txtAsunto.Text;
                correo.Body = txtCuerpo.Text;

                smtpClient.Send(correo);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
