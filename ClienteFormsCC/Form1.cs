using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClienteFormsCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Llamar al servicio a traves de un objeto
            ServiceReferenceED.wsReniecSoapClient servicio = new ServiceReferenceED.wsReniecSoapClient();
            // Leer DNI
            DataSet ds = servicio.BuscarDNI(txtDNI.Text.Trim());
            // Consultar el servicio y poner los datos sobre linea
            GVDatosDNI.DataSource = ds.Tables[0];
            GVDatosDNI.Refresh();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
