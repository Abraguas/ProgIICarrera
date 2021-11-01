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

    public class DetallesController : ControllerBase
    {
        private IDetalleService app_det;
        public DetallesController()
        {
            app_det = new DetalleService();
        }

        [HttpPost("{id}")]
        public IActionResult PostDetalle(DetalleCarrera oDetalle, int id)
        {
            if (oDetalle == null)
            {
                return BadRequest();
            }

            if (app_det.Grabar(oDetalle,id))
                return Ok("Ok");
            else
                return Ok("No se pudo grabar el detalle!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAsignatura(int id)
        {
            if (id== 0)
                return BadRequest("Id es requerido!");
            return Ok(app_det.Borrar(id));
        }
    }
}
