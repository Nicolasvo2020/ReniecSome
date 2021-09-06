using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ClienteASPNET
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            reniecsome.wsReniecSoapClient servicio = new reniecsome.wsReniecSoapClient();
            DataSet ds = servicio.WSlistado();
            gvDatosDNI.DataSource = ds.Tables[0];
            gvDatosDNI.DataBind();
            
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            // Llamar al servicio a traves de un objeto
            reniecsome.wsReniecSoapClient servicio = new reniecsome.wsReniecSoapClient();
            // Leer DNI
            string dni = txtDNI.Text.Trim();
            // Consultar el servicio y poner los datos sobre linea
            gvDatosDNI.DataSource = servicio.BuscarDNI(dni);
            gvDatosDNI.DataBind();
        }

        protected void btnDireccion_Click(object sender, EventArgs e)
        {
            // Llamar al servicio a traves de un objeto
            reniecsome.wsReniecSoapClient servicio = new reniecsome.wsReniecSoapClient();
            // Leer DNI
            DataSet ds = servicio.BuscarDireccion(TextDireccion.Text.Trim());
            // Consultar el servicio y poner los datos sobre linea
            gvDatosDNI.DataSource = ds.Tables[0];
            gvDatosDNI.DataBind();
        }
    }
}