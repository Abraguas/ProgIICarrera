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
    public class AsignaturaController : ControllerBase
    {
        private IAsignaturaService app_asig;
        public AsignaturaController()
        {
            app_asig = new AsignaturaService();
        }

        [HttpGet("Asignatura")]
        public IActionResult GetAsignatura()
        {
            return Ok(app_asig.Consultar());
        }

        [HttpPost]
        public IActionResult PostAsignatura(Asignatura oAsignatura)
        {
            if (oAsignatura == null)
            {
                return BadRequest();
            }

            if (app_asig.Grabar(oAsignatura))
                return Ok("Ok");
            else
                return Ok("No se pudo grabar la asignatura!");
        }


        //[HttpPost]
        //public IActionResult ActualizarAsignatura(Asignatura oAsignatura)
        //{
        //    if (oAsignatura == null)
        //    {
        //        return BadRequest();
        //    }

        //    if (app_asig.Actualizar(oAsignatura))
        //        return Ok("Ok");
        //    else
        //        return Ok("No se pudo grabar la asignatura!");
        //}

        [HttpDelete("{id}")]
        public IActionResult DeleteAsignatura(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(app_asig.Borrar(id));
        }
    }
}
