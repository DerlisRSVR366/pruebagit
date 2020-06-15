using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginLinkto
{
    public partial class usu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            if (!IsPostBack)
            {
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddDays(-1));
            Response.Cache.SetNoStore();

                if (Session["Usu"] != null)
            {

                lbl_usuario.Text += Session["Usu"].ToString();

            }
            else
            {
                Response.Redirect("/LoginF.aspx");
            }
            
                txt_primer.Attributes.Add("onkeypress", ("javascript:return SoloNumeros(event);"));
                txt_segundo.Attributes.Add("onkeypress", ("javascript:return SoloNumeros(event);"));
             
            }
        }

       

        protected void btn_restar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_primer.Text) || string.IsNullOrEmpty(txt_segundo.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Llene todos los campos";
            }
            else
            {

                double a = Convert.ToDouble(txt_primer.Text);
                double b = Convert.ToDouble(txt_segundo.Text);

                double numTotal = a - b;
                numTotal = Math.Round(numTotal, 2);
                lbl_mensaje.Visible = false;
                lbl_respuesta.Text = numTotal.ToString();
            }
        }

        //suma
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_primer.Text) || string.IsNullOrEmpty(txt_segundo.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Llene todos los campos";
            }
            else {

                double a = Convert.ToDouble(txt_primer.Text);
                double b = Convert.ToDouble(txt_segundo.Text);

                double numTotal = a + b;
                numTotal = Math.Round(numTotal,2);
                numTotal = Math.Round(numTotal, 2);
                lbl_mensaje.Visible = false;
                lbl_respuesta.Text = numTotal.ToString();
            }
        }

        protected void btn_multi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_primer.Text) || string.IsNullOrEmpty(txt_segundo.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Llene todos los campos";
            }
            else
            {

                double a = Convert.ToDouble(txt_primer.Text);
                double b = Convert.ToDouble(txt_segundo.Text);

                double numTotal = a * b;
                numTotal = Math.Round(numTotal, 2);
                lbl_mensaje.Visible = false;
                lbl_respuesta.Text = numTotal.ToString();
            }
        }

        protected void btn_dividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_primer.Text) || string.IsNullOrEmpty(txt_segundo.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Llene todos los campos";
            }
            else
            {
                if (txt_segundo.Text == "0")
                {
                    lbl_mensaje.Visible = true;
                    lbl_mensaje.Text = "El segundo numero no puede ser 0";
                }
                else
                {



                    double a = Convert.ToDouble(txt_primer.Text);
                    double b = Convert.ToDouble(txt_segundo.Text);

                    double numTotal = a / b;
                    numTotal = Math.Round(numTotal, 2);
                    lbl_mensaje.Visible = false;
                    lbl_respuesta.Text = numTotal.ToString();
                }
            }
        }

        protected void btn_potenciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_primer.Text) || string.IsNullOrEmpty(txt_segundo.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Llene todos los campos";
            }
            else
            {

                double a = Convert.ToDouble(txt_primer.Text);
                double b = Convert.ToDouble(txt_segundo.Text);

                double numTotal = Math.Pow(a,b);
                numTotal = Math.Round(numTotal, 2);
                lbl_mensaje.Visible = false;
                lbl_respuesta.Text = numTotal.ToString();
            }
        }

        protected void btn_radicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_primer.Text) || string.IsNullOrEmpty(txt_segundo.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Llene todos los campos";
            }
            else
            {
                if (txt_segundo.Text == "0")
                {
                    lbl_mensaje.Visible = true;
                    lbl_mensaje.Text = "El segundo numero no puede ser 0";
                }
                else
                {

                    double a = Convert.ToDouble(txt_primer.Text);
                    double b = Convert.ToDouble(txt_segundo.Text);

                    double numTotal = Math.Pow(a, Convert.ToDouble(1/b));
                    numTotal = Math.Round(numTotal, 2);
                    lbl_mensaje.Visible = false;
                    lbl_respuesta.Text = numTotal.ToString();
                }
            }
        }

        protected void btn_cerrar_Click(object sender, EventArgs e)
        {
            Session["Usu"] = null;
            Response.Redirect("/LoginF.aspx");
        }
    }
}