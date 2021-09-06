using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteASPEdward
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            // Llamar al servicio a traves de un objeto
            ServiceEdward.wsReniecSoapClient servicio = new ServiceEdward.wsReniecSoapClient();
            // Leer DNI
            string dni = txtDNI.Text.Trim();
            // Consultar el servicio y poner los datos sobre linea
            gvDatosDNI.DataSource = servicio.BuscarDNI(dni);
            gvDatosDNI.DataBind();
        }
    }
}