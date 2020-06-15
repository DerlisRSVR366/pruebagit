using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using CapaDatos;
using CapaNegocio;
using System.Text;
using System.Security.Cryptography;

namespace LoginLinkto
{
    public partial class LoginF : System.Web.UI.Page
    {
        int contador = 1;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;


            Session["con"] = Session["Contador"];
        }
        public  void ingresar()
        {

            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Ingrese su Nombre de Usuario";
                return;
            }
            if (string.IsNullOrEmpty(txt_contra.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Ingrese la clave";
                return;
            }
            //validar los perfiles de usuario por la capa negocio
            bool existe = LogicaUsuario.autentificarNombre(txt_nombre.Text);
            {//seccion de codigo fuente
                if (existe)
                {
                    bool validar = LogicaUsuario.Autentificar(txt_nombre.Text,GetMD5(txt_contra.Text));
                    if (validar)
                    {



                        //instancio mi tabla como objeto
                        Tbl_Usuarios usuario = new Tbl_Usuarios();
                        usuario = LogicaUsuario.AutentificarLogin(txt_nombre.Text, GetMD5(txt_contra.Text));
                        //valido si es usuario o administrador
                        int tusuario = usuario.Tusu_id;
                        if (tusuario == 1)
                        {
                            Session["Admin"] = txt_nombre.Text;
                            Response.Redirect("/Administrador.aspx");
                        }
                        if (tusuario == 2)
                        {
                            Session["Usu"] = txt_nombre.Text;
                            Response.Redirect("/usu.aspx");
                        }
                    }
                    else
                    {
                        lbl_contador.Text = (contador + (Convert.ToInt32(Session["con"]))).ToString();
                        Session["contantiguo"] = lbl_contador.Text.ToString();
                        if (Convert.ToInt32(Session["contador"]) < 3)
                        {
                            Session["contador"] = Convert.ToInt32(Session["contador"]) + 1;
                            lbl_contador.Text = Convert.ToInt32(Session["contador"]).ToString();
                        }
                        else
                        {
                            lbl_contador.Text = "Ha sobrepasado el numero de intentos";
                            btn_ingresar.Enabled = false;
                        }

                    }

                }
                else
                {
                    //mensaje de error
                    lbl_mensaje.Visible = true;
                    lbl_mensaje.Text = "El usuario no existe";
                    return;
                }
            }

        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        protected void btn_olvido_Click(object sender, EventArgs e)
        {
            lbl_contra.Visible = false;
            lbl_mensaje.Visible = false;
            txt_contra.Visible = false;
            btn_ingresar.Visible = false;
            btn_enviar.Visible = true;
            lbl_contador.Visible = false;
            btn_crear.Visible = false;
            cb_emails.Visible = true;

        }

        protected void btn_crear_Click(object sender, EventArgs e)
        {
            Response.Redirect("/CrearUsuario.aspx");
        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(cb_emails.SelectedItem.Value);

            if (string.IsNullOrEmpty(txt_nombre.Text) || valor==0)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Ingrese su Usuario";
            }
            else
            {
                if (valor == 1)
                {


                    string emaildestino = LogicaUsuario.ConsultaCorreo(txt_nombre.Text);
                    string contra = LogicaUsuario.ConsultaMD5(txt_nombre.Text);
                    bool s = LogicaUsuario.EnviarGmail(emaildestino, contra);

                    if (s)
                    {
                        lbl_mensaje.Visible = true;
                        lbl_mensaje.Text = "Su contraseña ha sido enviada al correo vinculada con el usuario";
                    }
                    else
                    {
                        lbl_mensaje.Visible = true;
                        lbl_mensaje.Text = "No se ha podido enviar el Email";

                    }
                }
                if (valor == 3)
                {


                    string emaildestino = LogicaUsuario.ConsultaCorreo(txt_nombre.Text);
                    string contra = LogicaUsuario.ConsultaMD5(txt_nombre.Text);
                   bool s=LogicaUsuario.EnviarOutlook(emaildestino, contra);
                    if (s)
                    {
                        lbl_mensaje.Visible = true;
                        lbl_mensaje.Text = "Su contraseña ha sido enviada al correo vinculada con el usuario";
                    }
                    else
                    {
                        lbl_mensaje.Visible = true;
                        lbl_mensaje.Text = "No se ha podido enviar el Email";

                    }

                }
                if (valor == 2)
                {


                    string emaildestino = LogicaUsuario.ConsultaCorreo(txt_nombre.Text);
                    string contra = LogicaUsuario.ConsultaMD5(txt_nombre.Text);
                   bool s=LogicaUsuario.EnviarYahoo(emaildestino, contra);

                    if (s)
                    {
                        lbl_mensaje.Visible = true;
                        lbl_mensaje.Text = "Su contraseña ha sido enviada al correo vinculada con el usuario";
                    }
                    else
                    {
                        lbl_mensaje.Visible = true;
                        lbl_mensaje.Text = "No se ha podido enviar el Email";

                    }
                }
            }
            
        

        }

        protected void cb_emails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}