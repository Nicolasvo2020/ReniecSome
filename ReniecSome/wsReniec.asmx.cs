using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


using System.Data; //Acceder a buffer de memoria
using System.Data.SqlClient; // Acceder a SQL server
using System.Configuration; // Acceder a los archivos mde configuración 

namespace ReniecSome
{
    /// <summary>
    /// Descripción breve de wsReniec
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsReniec : System.Web.Services.WebService
    {

        // acceder a la cadena de Conexión web.config
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        [WebMethod(Description = "Consultar con el DNI del usuario ")]


        public DataSet BuscarDNI(string dni)
        {
            //llamar al procedimiento almacenado
            SqlCommand comando = new SqlCommand("spBuscarDNI", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            // Enviar el DNi al Procedimiento Almacenado
            comando.Parameters.AddWithValue("@DNI", dni);
            // Traer los datos del procedimiento almacenado 
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            //Volcado de datos del gestor SQl al web Services
            adapter.Fill(data);
            // Devolver los valores al web Services
            return data;
        }
        [WebMethod(Description = "Consultar por Direccion")]

        public DataSet BuscarDireccion(string direccion)
        {
            //llamar al procedimiento almacenado
            SqlCommand comando = new SqlCommand("spBuscarDireccion", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            // Enviar el DNi al Procedimiento Almacenado
            comando.Parameters.AddWithValue("@Direccion", direccion);
            // Traer los datos del procedimiento almacenado 
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            //Volcado de datos del gestor SQl al web Services
            adapter.Fill(data);
            // Devolver los valores al web Services
            return data;
        }
        [WebMethod(Description = "Listar")]
        public DataSet WSlistado()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TCiudadano", conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        /*
        [WebMethod(Description = "Insertar Ciudadano")]
               
        public DataSet AgregaCiudadano(string dni, string ape, string nom, DateTime fn, string dir, string gen)
        {
            //llamar al procedimiento almacenado
            SqlCommand comando1 = new SqlCommand("spAgregaCiudadano", conexion);
            comando1.CommandType = CommandType.StoredProcedure;
            // Enviar los campos Procedimiento Almacenado
            SqlParameter sqlParameter = comando1.Parameters.AddWithValue("@dni", dni, "@ape", ape, "@nom", nom, "@fn", fn, "@dir", dir, "@gen", gen);
            // Traer los datos del procedimiento almacenado 
            SqlDataAdapter adapter = new SqlDataAdapter(comando1);
            DataSet data = new DataSet();
            //Volcado de datos del gestor SQl al web Services
            adapter.Fill(data);
            // Devolver los valores al web Services
            return data;
        }*/
    }
}
