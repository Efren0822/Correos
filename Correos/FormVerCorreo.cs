using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;

namespace Correos
{

   
    public partial class FormVerCorreo : Form
    {
        private MimeMessage correoActual;
        public FormVerCorreo(MimeMessage correo)
        {
            InitializeComponent();
            correoActual = correo;
            MostrarInformacionCorreo();
        }
        public class Correo
        {
            public string Remitente { get; set; }
            public string Asunto { get; set; }
            public string Cuerpo { get; set; }
        }

        private void MostrarInformacionCorreo()
        {
         
            var remitente = ObtenerRemitente(correoActual);
            var asunto = correoActual.Subject;
            var cuerpo = ObtenerCuerpoMensaje(correoActual);

            lblRemitente.Text = remitente;
            lblAsunto.Text = asunto;
            txtCuerpo.Text = cuerpo;
        }

        private string ObtenerRemitente(MimeMessage mensaje)
        {
            var remitente = mensaje.From;

            if (remitente.Count > 0)
            {
                var primeraDireccion = remitente[0] as MailboxAddress;
                if (primeraDireccion != null)
                {
                    return primeraDireccion.Address;
                }
            }

            return string.Empty;
        }

        private string ObtenerCuerpoMensaje(MimeMessage mensaje)
        {
            
            foreach (var parte in mensaje.BodyParts)
            {
                var textoParte = parte as TextPart;
                if (textoParte != null)
                {
                    return textoParte.Text;
                }
            }

            return string.Empty;
        }


        

        

        private void FormVerCorreo_Load(object sender, EventArgs e)
        {

        }

        

        private void FormVerCorreo_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResponder_Click_1(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(lblRemitente.Text))
            {
                
                FormNuevoCorreo formNuevoCorreo = new FormNuevoCorreo();

                
                formNuevoCorreo.PreencherDestinatario(lblRemitente.Text);
                formNuevoCorreo.PreencherAsunto( lblAsunto.Text);

                formNuevoCorreo.ShowDialog();
            }
            else
            {
                
                MessageBox.Show("No se puede responder. No se encontró un remitente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
