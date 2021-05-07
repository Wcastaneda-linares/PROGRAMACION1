using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASES_DE_DATOS.CLASES
{
    class ClsCorreo
    {
        public string correo { get; set; }
        public string cuerpo { get; set; }
        public string nombre { get; set; }
        public string asunto { get; set; }
        public string password { get; set; }
        public int puerto { get; set; }
        public string smtp { get; set; }
        public List<string> destinatarios { get; set; }


        public static bool Send(ClsCorreo correo)
        {
            try
            {
                SmtpClient cliente = new SmtpClient(correo.smtp, correo.puerto);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(correo.correo, correo.nombre);
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Body = correo.cuerpo;
                mail.Subject = correo.asunto;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                foreach (var destinatario in correo.destinatarios)
                {
                    if (!string.IsNullOrWhiteSpace(destinatario))
                    {
                        mail.To.Add(destinatario);
                    }
                }


                cliente.Credentials = new NetworkCredential(correo.correo, correo.password);
                cliente.EnableSsl = true;
                cliente.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

    }
}
