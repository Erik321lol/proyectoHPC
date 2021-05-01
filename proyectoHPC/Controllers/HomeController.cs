using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyectoHPC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoHPC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
            //agregar,editar,eliminar
            coneccion.abrir();
            //SqlCommand cons = new SqlCommand("Insert Into Cliente(Nombre1, Nombre2, Apellido1, Apellido2, Nit, Telefono, Direccion, Dpi) values ('Erik', 'Adolfo', 'Mendez', 'Guillen', '12345678', '12345678', 'ciudad',201845335)", coneccion.con);
            //cons.ExecuteNonQuery();
            coneccion.cerrar();

            //consultar
            /*coneccion.abrir();
            SqlCommand cons = new SqlCommand("Select * from Cliente", coneccion.con);
            SqlDataReader ingresar = cons.ExecuteReader();
            while (ingresar.Read())
            { 
                ViewData["nombre"] = ingresar["Nombre1"].ToString();
            } 
            coneccion.cerrar();*/
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult contacto()
        {
            return View();
        }

        public IActionResult habitaciones()
        {
            return View();
        }

        public IActionResult entorno()
        {
            return View();
        }

        public IActionResult lugaresTuristicos()
        {
            return View();
        }

        public IActionResult reservas()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
