using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proyectomvc.Models;

namespace proyectomvc.Controllers
{
    public class ProfesorController : Controller
    {
        public ProfesorController()
        {
        }

        public IActionResult Profesor()
        {
            return View();
        }

         [HttpPost]
        public IActionResult Guardar (string nombre, string apellido, string email, string estadocivil)
        {
            Profesor nuevoProfesor = new Profesor();
           nuevoProfesor.Nombre = nombre;
           nuevoProfesor.Apellido= apellido;
            nuevoProfesor.Email= email;
            nuevoProfesor.EstadoCivil= estadocivil;
            
            return View(nuevoProfesor);
        }
    }
}