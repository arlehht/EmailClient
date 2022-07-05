using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;

namespace EmailClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                var msg = new MimeMessage();
                /*
                 foreach (String f in this.listArchivos.Items)
                {
                    builder.Attachments.Add(@"C:UsersJoeyDocumentsparty.ics");
                    message.Body = builder.ToMessageBody();
                }
                 */
                if (rbGmail.Checked == true)
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate(this.txtRemitente.Text, this.txtPassword.Text);
                    msg.From.Add( new MailboxAddress("", txtRemitente.Text));
                    msg.To.Add( new MailboxAddress("", txtDestinatario.Text));
                    msg.Subject = this.txtAsunto.Text;
                    msg.Body = new TextPart("plain")
                    {
                        Text = txtMensaje.Text
                };
                    client.Send(msg);
                    client.Disconnect(true);
                }
                if (rbHotmail.Checked == true)
                {
                    client.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate(this.txtRemitente.Text, this.txtPassword.Text);
                    msg.From.Add(new MailboxAddress("", txtRemitente.Text));
                    msg.To.Add(new MailboxAddress("", txtDestinatario.Text));
                    msg.Subject = this.txtAsunto.Text;
                    msg.Body = new TextPart("plain")
                    {
                        Text = txtMensaje.Text
                    };
                    client.Send(msg);
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }    
        }
        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog()== DialogResult.OK)
            {
                String Archivos = f.FileName;
                this.listArchivos.Items.Add(Archivos);
            }
        }
    }
}