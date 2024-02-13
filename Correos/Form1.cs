using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;


namespace Correos
{
    public partial class Form1 : Form
    {
        private List<string> listaCorreos = new List<string>();
        public Form1()
        {
            InitializeComponent();
            ActualizarListaCorreos();
        }

         private void ActualizarListaCorreos()
        {
            listaCorreos.Clear();
            using(var client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate("ejercicios.uttt@gmail.com", "ltxb dtmi wjgh xilv");

                var inbox=client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                var mensajes = inbox.Search(SearchQuery.All);

                foreach(var uniqueID in mensajes)
                {
                    var mensaje = inbox.GetMessage(uniqueID);
                    listaCorreos.Add(mensaje.Subject);
                }
                listaCorreos.Reverse();
                client.Disconnect(true);
            }

            MostrarCorreosEnLista();
        }

        private void MostrarCorreosEnLista()
        {
            listBoxCorreos.DataSource = null;
            listBoxCorreos.DataSource = listaCorreos;
        }

        

        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxCorreos.ClearSelected();
        }

        private void btnCrearCorreo_Click_1(object sender, EventArgs e)
        {
            FormNuevoCorreo formNuevoCorreo = new FormNuevoCorreo();
            formNuevoCorreo.ShowDialog();
            ActualizarListaCorreos();
        }

        private void btnActualizarFeed_Click_1(object sender, EventArgs e)
        {
            ActualizarListaCorreos();
        }

        private void listBoxCorreos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxCorreos.SelectedIndex >= 0)
            {
                
                string asuntoSeleccionado = listaCorreos[listBoxCorreos.SelectedIndex];
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate("ejercicios.uttt@gmail.com", "ltxb dtmi wjgh xilv");
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    var mensajes = inbox.Search(SearchQuery.SubjectContains(asuntoSeleccionado));
                    var uniqueId = mensajes.FirstOrDefault();
                    if (uniqueId != null)
                    {
                        var mensaje = inbox.GetMessage(uniqueId);
                        client.Disconnect(true);
                        FormVerCorreo formvercorreo = new FormVerCorreo(mensaje);
                        formvercorreo.ShowDialog();
                    }
                }
            }
            listBoxCorreos.ClearSelected();
        }
    }
}
