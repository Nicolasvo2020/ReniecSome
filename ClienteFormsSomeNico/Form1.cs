using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteFormsSomeNico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            srFormsSomeNico.wsReniecSoapClient servicio = new srFormsSomeNico.wsReniecSoapClient();
            DataSet ds = servicio.WSlistado();
            GVDatosCiudadano.DataSource = ds.Tables[0];
            GVDatosCiudadano.Refresh();
        }

        private void btnConsultarDir_Click(object sender, EventArgs e)
        {
            srFormsSomeNico.wsReniecSoapClient servicio = new srFormsSomeNico.wsReniecSoapClient();
            DataSet ds = servicio.BuscarDireccion(txtDireccion.Text.Trim());
            GVDatosCiudadano.DataSource = ds.Tables[0];
            GVDatosCiudadano.Refresh();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            srFormsSomeNico.wsReniecSoapClient servicio = new srFormsSomeNico.wsReniecSoapClient();
            DataSet ds = servicio.BuscarDNI(txtDNI.Text.Trim());
            GVDatosCiudadano.DataSource = ds.Tables[0];
            GVDatosCiudadano.Refresh();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            srFormsSomeNico.wsReniecSoapClient servicio = new srFormsSomeNico.wsReniecSoapClient();
            DataSet ds = servicio.WSlistado();
            GVDatosCiudadano.DataSource = ds.Tables[0];
            GVDatosCiudadano.Refresh();
        }
    }
}
