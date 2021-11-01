using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarreraBackend.Entidades;
using CarreraBackend.Servicios;
using CarreraBackend.Servicios.Interfaces;
using CarreraBackend.Servicios.Implementaciones;

namespace CarreraWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrerasController : ControllerBase
    {
        private ICarreraService app_carre;

        public CarrerasController()
        {
            app_carre = new CarreraService();
        }

        [HttpGet("Carrera")]
        public IActionResult GetCarrera()
        {
            return Ok(app_carre.Consultar());
        }

        [HttpPost]
        public IActionResult PostCarrera(Carrera oCarrera)
        {
            if (oCarrera == null)
            {
                return BadRequest();
            }

            if (app_carre.Grabar(oCarrera))
                return Ok("Ok");
            else
                return Ok("No se pudo grabar la carrera!");
        }

        public ActionResult PutCarrera(Carrera oCarrera)
        {
            if (!app_carre.Actualizar(oCarrera))
            {
                return BadRequest("La carrera no existe");
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCarrera(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(app_carre.Borrar(id));
        }



    }
}
