using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginLinkto
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            if (!IsPostBack)
            {
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetExpires(DateTime.Now.AddDays(-1));
                Response.Cache.SetNoStore();

                if (Session["admin"] != null)
                {
                    lbl_mensaje.Text += Session["admin"].ToString();

                }

               else
                {
                    Response.Redirect("/LoginF.aspx");

                }
            }
        }

        protected void btn_session_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("/LoginF.aspx");
        }
    }
}