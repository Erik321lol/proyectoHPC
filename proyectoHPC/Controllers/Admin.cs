using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proyectoHPC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoHPC.Controllers
{
	public class Admin : Controller
	{
		public object Database { get; private set; }

		// GET: Admin
		public ActionResult Index()
		{
			return View();
		}

		// GET: Admin/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Admin/Create
		public ActionResult Create()
		{
			return View();
		}

		public ActionResult ControlHabitaciones()
		{
			String _consulta = "Select * from cliente";
			SqlDataReader Leer = coneccion.Consulta_Reader(_consulta);
			List<Tablas.Cliente> aux = new List<Tablas.Cliente>();
			while (Leer.Read())
			{
				aux.Add(new Tablas.Cliente((int)(long)Leer[0], (String)Leer[1], (String)Leer[2], (String)Leer[3], (String)Leer[4]));
			}
			coneccion.cerrar();
			return View(aux);
		}


			public ActionResult controlReserva()
		{
			return View();
		}

		// POST: Admin/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Admin/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Admin/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Admin/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Admin/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
