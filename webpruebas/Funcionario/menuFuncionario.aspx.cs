using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webpruebas
{
    public partial class menuFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Session["userName"].ToString().ToUpper();
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            Response.Redirect("/index.aspx");
        }
    }
}