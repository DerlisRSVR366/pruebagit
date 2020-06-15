using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginLinkto
{
    public partial class Login : System.Web.UI.Page
    {
        string nombre = "Steven";
        string contra = "1234";

        string nombre2 = "Raul";
        string contra2 = "12345";
        int contador=1;
        int c = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            if (!IsPostBack)
            {
                Session["contador"] = 1;
            }
              
                   
                
            
        
           
        }
        //numero de intentos usando variables de session y tiempo de espera de session
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (txt_nombre.Text == "" || txt_contra.Text == "")
            {

                string script = string.Format("alert('Ingrese todos los campos');", nombre);
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
            else
            {

                if (nombre == txt_nombre.Text && contra == txt_contra.Text)
                {
                    Session["Admin"] = txt_nombre.Text;
                    Session["contantiguo"] = null;
                    Session["contador"] = null;
                    Session["con"] = null;
                    lbl_contador.Text = (contador + (Convert.ToInt32(Session["con"]))).ToString();
                    lbl_contador.Text = Convert.ToInt32(Session["contador"]).ToString();
                    Response.Redirect("/Adin.aspx");
                }
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
                    Button1.Enabled = false;
                }

            }
        }
        //intentos errores validaciones  y 
    }
}   