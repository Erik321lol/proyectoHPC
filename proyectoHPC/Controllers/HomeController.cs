﻿using Microsoft.AspNetCore.Authorization;
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

        public IActionResult login()
        {
            return View();
            
        }

        public string generarToken()
        {
            var ran = new Random();
            return ran.Next().ToString();
        }

        [HttpPost]
        public IActionResult login(String usuario, String contrasena)
        {
            String contra = "";
            coneccion.abrir();
            SqlCommand cons = new SqlCommand("SELECT contraseña FROM administrador WHERE usuario = '" + usuario + "'", coneccion.con);
            SqlDataReader ingresar = cons.ExecuteReader();
            while (ingresar.Read())
            {
                contra = ingresar["contraseña"].ToString();
            }
            coneccion.cerrar();

            if (contra.Equals(contrasena))
            {
                return View("registro_de_cuartos");
            }
            else
            {
                return View("Index");
            }
            
        }

        public IActionResult crear_usuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult crear_usuario(String nombre, String apellido, String usuario, String contrasena)
        {
            coneccion.abrir();
            SqlCommand cons = new SqlCommand("Insert Into administrador(nombre, apellido, usuario, contraseña) values ('" + nombre + "', '" + apellido + "', '" + usuario + "', '" + contrasena + "')", coneccion.con);
            cons.ExecuteNonQuery();
            coneccion.cerrar();
            return View();
        }

        public IActionResult registro_de_cuartos()
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
