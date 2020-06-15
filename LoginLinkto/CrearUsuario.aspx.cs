using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaDatos;
using System.Text;
using System.Security.Cryptography;

namespace LoginLinkto
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
        protected void btn_crear_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            LogicaUsuario logicaUsuario = new LogicaUsuario();
            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_telefono.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_direccion.Text) || string.IsNullOrEmpty(txt_correo.Text) || string.IsNullOrEmpty(txt_contra.Text) ||
                string.IsNullOrEmpty(txt_apellido.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Llene todos los campos";
            }
            else
            {
                Tbl_Usuarios usuario = new Tbl_Usuarios();
                usuario.usu_nombre = txt_nombre.Text;
                usuario.usu_apellido = txt_apellido.Text;
                usuario.usu_nomlogin = txt_usuario.Text;
                usuario.usu_contrasena = GetMD5(txt_contra.Text);
                usuario.usu_correo = txt_correo.Text;
                usuario.usu_direccion = txt_direccion.Text;
                usuario.usu_telefono = txt_telefono.Text;
                usuario.usu_cedula = txt_cedula.Text;
                LogicaUsuario.save(usuario);
                Response.Redirect("/LoginF.aspx");
            }

          
        }
    }
}