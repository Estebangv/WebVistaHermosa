﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webpruebas.JI
{
    public partial class cambiarEstado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //mandar el estado a la base de datos
        }

        protected void btnCancelarJI_Click(object sender, EventArgs e)
        {
            Response.Redirect("autorizarPermiso.aspx");
        }
    }
}