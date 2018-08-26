﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ProyectoGerencia.BusinessLogic
{
    public class EmailService
    {
        public void SendEmail(string pEmail, string pCode, string Directory)
        {
            // Command line argument must the the SMTP host.
            SmtpClient client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential("it.pluricode@gmail.com", "Pluricode1331"),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Timeout = 30000
            };

            // Specify the e-mail sender.
            string from = "it.pluricode@gmail.com";

            // Set destinations for the e-mail message.
            string to = pEmail;


            // Specify the message content.
            string body = $"Este correo fue enviado automáticamente para activar su cuenta.\n\n" +
                $"Su código de confirmación es: {pCode}\n\n" +
                $"Ingreselo en el siguiente link para activar su cuenta, y a su vez cree su contraseña.\n\n" +
                $"Link para activar su cuenta: localhost:50420/{Directory}?c={new Encriptacion().Encriptar(pEmail)}";

            // Specify the subject
            string subject = "Confirmacion de la cuenta del proyecto de Gerencia";

            //We send the email
            client.Send(from, to, subject, body);
        }

        public void SendEmail(string pEmail, string Directory)
        {
            // Command line argument must the the SMTP host.
            SmtpClient client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential("it.pluricode@gmail.com", "Pluricode1331"),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Timeout = 30000
            };

            // Specify the e-mail sender.
            string from = "it.pluricode@gmail.com";

            // Set destinations for the e-mail message.
            string to = pEmail;


            // Specify the message content.
            string body = $"Este correo fue enviado automáticamente para activar su cuenta.\n\n" +
                $"Ingreselo en el siguiente link para activar su cuenta, y a su vez cree su contraseña.\n\n" +
                $"Link para activar su cuenta: localhost:50420/{Directory}?c={new Encriptacion().Encriptar(pEmail)}";

            // Specify the subject
            string subject = "Confirmacion de la cuenta del proyecto de Gerencia";

            //We send the email
            client.Send(from, to, subject, body);
        }
        
        public void Facturas(string pEmail)
        {
            // Command line argument must the the SMTP host.
            SmtpClient client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential("it.pluricode@gmail.com", "Pluricode1331"),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Timeout = 30000
            };

            // Specify the e-mail sender.
            string from = "it.pluricode@gmail.com";

            // Set destinations for the e-mail message.
            string to = pEmail;


            // Specify the message content.
            string body = $"Se le informa que se ha realizado el pago de sus impuestos satisfactoriamente.\n\n" +
                $"Le recomendamos que esté atento a su correo electrónico. En los siguientes minutos PayPal le estará informando acerca de su pago por la plataforma y consigo le mostrará la factura electrónica referente al pago.\n\n" +
                $"Gracias por realizar sus pagos con nosotros.";

            // Specify the subject
            string subject = "Confirmacion de pago del proyecto de Gerencia";

            //We send the email
            client.Send(from, to, subject, body);
        }
        

    }
}