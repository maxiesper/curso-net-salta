using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proyectomvc.Models;

namespace proyectomvc.Controllers
{
    public class AlumnoController : Controller
    {
        public AlumnoController()
        {
        }

        public IActionResult Alumno()
        {
            return View();
        }

       
       [HttpPost]
        public IActionResult Guardar (string nombre, string apellido, string email, string estadocivil)
        {
            Alumno nuevoAlumno = new Alumno();
            nuevoAlumno.Nombre = nombre;
            nuevoAlumno.Apellido= apellido;
            nuevoAlumno.Email= email;
            nuevoAlumno.EstadoCivil= estadocivil;
            
            return View(nuevoAlumno);
        }
    }
}