using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoHPC.Models
{
    public class coneccion : Controller
    {
        public static string dda = "Data source = SQL5104.site4now.net; Initial catalog = db_a7376a_dbhpc; user id = db_a7376a_dbhpc_admin; password = 12345678hotel;";
        public static SqlConnection con = new SqlConnection(dda);

        public static void abrir()
        {
            con.Open();
        }

        public static void cerrar()
        {
            con.Close();
        }

        public static void Reiniciar()
        {
            cerrar();
            abrir();
        }

        public static SqlDataReader Consulta_Reader(string _consulta)
        {
            abrir();
            SqlCommand consulta = new SqlCommand(_consulta, con);
            SqlDataReader Leer = consulta.ExecuteReader();
            return Leer;
        }

    }
}
