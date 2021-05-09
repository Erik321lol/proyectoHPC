using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoHPC.Models
{
	public class Tablas
	{
        public class Cliente
        {
            public long Cod_cliente { get; set; }
            public String Nombre { get; set; }
            public String Apellido { get; set; }
            public String Telefono { get; set; }
            public String Correo { get; set; }
            public DateTime Fecha_Entrada { get; set; }
            public DateTime Fecha_Salida { get; set; }

            public Cliente() { }
            public Cliente(int _Cod_cliente, String _Nombre, String _Apellido, String _Telefono, String _Correo, DateTime _Fecha_Entrada, DateTime _Fecha_Salida)
            {
                Cod_cliente = _Cod_cliente;
                Nombre = _Nombre;
                Apellido = _Apellido;
                Telefono = _Telefono;
                Correo = _Correo;
                Fecha_Entrada = _Fecha_Entrada;
                Fecha_Salida = _Fecha_Salida;
            }
        }


    }


    		
}
