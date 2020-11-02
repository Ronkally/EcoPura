using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EcoPuraLibreria
{
    public class Shared
    {
        public static bool Autorizacion(User user)
        {
            //rol 1 = admin
            if (user.Rol != 1)
            {
                return false;
            }
            return true;
        }

        public static bool InvalidString(string s)
        {
            if (String.IsNullOrEmpty(s) || String.IsNullOrWhiteSpace(s))
                return true;

            return false;
        }

        public static void Email(string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("ecopurabot@gmail.com");
                message.To.Add(new MailAddress(DatabaseAccess.GetInfo("Select correo from configuracion where id = 1")));
                message.Subject = "Inventario de Ecopura";
                message.Body = htmlString;

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("ecopurabot@gmail.com", "Ecopur@123");

                smtp.Send(message);
            }
            catch (Exception) { }

        }
    }
}
