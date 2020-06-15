using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Linq;
using System.Security.Cryptography;
using System.Net.Mail;

namespace CapaNegocio
{
    public class LogicaUsuario
    {   //instanciar mi data contex
        public static DataClasses1DataContext dc = new DataClasses1DataContext();


        //crear metodo

        public static List<Tbl_Usuarios> obtenerUsuarios()
        {
            var lista = dc.Tbl_Usuarios.Where(usu => usu.usu_estado == 'A');
            return lista.ToList();

        }

            //metodo para verificar credenciales
            public static bool Autentificar(string nombre, string pass)
            {
                    var auto = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == 'A'
                    &  usu.usu_nomlogin.Equals(nombre)
                & usu.usu_contrasena.Equals(pass));

                return auto;
            }
            //crear metodo para verificar el nombre login deber   .  any where single firtsordefault 
            public static Tbl_Usuarios AutentificarLogin(string nombre,string pass)
            {
                var nomlogin= dc.Tbl_Usuarios.Single(usu => usu.usu_estado == 'A' & usu.usu_nomlogin.Equals(nombre) & usu.usu_contrasena.Equals(pass));
                return nomlogin;
            }
            public static bool autenticarced(string ced)
            {
                var autoc = dc.Tbl_Usuarios.Any(usu => usu.usu_cedula.Equals(ced) );
                return autoc;
            }

            public static bool autentificarNombre(string nombre)
            {
                var auton = dc.Tbl_Usuarios.Any(usu => usu.usu_estado == 'A' & usu.usu_nomlogin.Equals(nombre));
                return auton;
            }

    //metodo para guardar datos;
    public static void save(Tbl_Usuarios usuario)
        {
            try
            {
                //guardar datos
                usuario.usu_estado = 'A';
                usuario.usu_fechacreacion = DateTime.Now;
                usuario.Tusu_id = 2;

                dc.Tbl_Usuarios.InsertOnSubmit(usuario);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados </br>"+ex.Message);
               
            }

        }
        public static bool EnviarGmail(string emaildestino, string contras)
        {

            try
            {

           
            string EmailOrigen = "vacarocafuerteraul@gmail.com";
            string contra = "Vacarocafuerteraul366";
            MailMessage mailms = new MailMessage(EmailOrigen,emaildestino,"Recuperación de Contraseña","Esta es su clave:  "+contras);
            mailms.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen,contra);
            mailms.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            smtpClient.Send(mailms);
     
            smtpClient.Dispose();

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public static  bool EnviarYahoo(string emaildestino, string contras)
        {


            try
            {

         

                string EmailOrigen = "raulvacarocafuerte366@yahoo.com";
                string contra = "Vacarocafuerteraul366";
                MailMessage mailms = new MailMessage(EmailOrigen, emaildestino, "Recuperación de Contraseña", "Esta es su clave:  " + contras);
                mailms.IsBodyHtml = true;
                SmtpClient smtpClient = new SmtpClient("smtp.mail.yahoo.com");
                smtpClient.EnableSsl = true;
               
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Host = "smtp.mail.yahoo.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, contra);
                mailms.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                smtpClient.Send(mailms);

                smtpClient.Dispose();

            return true;
        }
            catch (Exception)
            {

                return false;
            }

}



        public static bool EnviarOutlook(string emaildestino, string contras)
        {

            try
            {

           


                string EmailOrigen = "raulvacarocafuerte366@outlook.com";
                string contra = "Vacarocafuerteraul366";
                MailMessage mailms = new MailMessage(EmailOrigen, emaildestino, "Recuperación de Contraseña", "Esta es su clave:  " + contras);
                mailms.IsBodyHtml = true;
                SmtpClient smtpClient = new SmtpClient("smtp.office365.com");
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Host = "smtp.office365.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, contra);
                mailms.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                smtpClient.Send(mailms);

                smtpClient.Dispose();

            return true;
        }
            catch (Exception)
            {

                return false;
            }

}


        public static string ConsultaMD5(string usuario)
        {

            var query = from a in dc.Tbl_Usuarios
                        where a.Tusu_id == 2
                        & a.usu_nomlogin == usuario
                        & a.usu_estado == 'A'
                        select a.usu_contrasena;
            var s= Convert.ToString(query.FirstOrDefault());

            var claveconvertida=ClaveCovertidaMD5(s);
            return claveconvertida;
           
        }
        public static string ConsultaCorreo(string usuario)
        {

            var query = from a in dc.Tbl_Usuarios
                        where a.Tusu_id == 2
                        & a.usu_nomlogin == usuario
                        & a.usu_estado == 'A'
                        select a.usu_correo;

            return Convert.ToString(query.FirstOrDefault());

        }
        public static string ClaveCovertidaMD5(string MD5)
        {
            var query = from a in dc.HashMD5
                        where a.hash_md5 == MD5
                        select a.palabra;
            return Convert.ToString(query.FirstOrDefault());

        }
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++)
                sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }
}
