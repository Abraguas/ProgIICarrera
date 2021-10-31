using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Acceso_a_Datos
{
    class CarreraDao : ICarreraDao
    {
        private DaoHelper helper;

        public CarreraDao()
        {
            helper = DaoHelper.ObtenerInstancia();
        }

        public bool Save(Carrera carrera)
        {
            List<List<Parametro>> paramDetalles = new List<List<Parametro>>();
            List<Parametro> paramMaestro = new List<Parametro>();

            paramMaestro.Add(new Parametro("@nombre", carrera.Nombre));
            paramMaestro.Add(new Parametro("@titulo", carrera.Titulo));

            List<Parametro> auxParam;
            foreach(DetalleCarrera detalle in carrera.Detalles)
            {
                auxParam = new List<Parametro>();
                auxParam.Add(new Parametro("@id_carrera", Convert.ToString(carrera.Id)));
                auxParam.Add(new Parametro("@anio", Convert.ToString(detalle.AnioCursado)));
                auxParam.Add(new Parametro("@cuatrimestre", Convert.ToString(detalle.Cuatrimestre)));
                auxParam.Add(new Parametro("@id_materia", Convert.ToString(detalle.Materia.Id)));
            }

            return helper.InsertarMaestroDetalle("insertar_carrera",paramMaestro,"insertar_detalle",paramDetalles);

        }

        public List<Carrera> Get()
        {
            DataTable carreras = helper.ConsultarDB("consultar_carrera");
            DataTable detalles;
            List<Carrera> listaC = new List<Carrera>();
            List<DetalleCarrera> listaD = new List<DetalleCarrera>();
            Carrera carrera;
            DetalleCarrera detalle;
            foreach (DataRow filaC in carreras.Rows)
            {
                detalles = helper.ConsultarConParametro(
                                                            "consultar_detalle_id", 
                                                            new Parametro("@id", Convert.ToString(filaC["id_carrera"]))
                                                        );
                foreach(DataRow filaD in detalles.Rows)
                {
                    detalle = new DetalleCarrera(
                                                 Convert.ToInt32(filaD["id_detalle"]),
                                                 Convert.ToInt32(filaD["anio_cursado"]),
                                                 Convert.ToInt32(filaD["cuatrimestre"]),
                                                 new Asignatura(Convert.ToInt32(filaD["id_materia"]), Convert.ToString(filaD["nombre"]))
                                                );
                    listaD.Add(detalle);
                }
                carrera = new Carrera(
                                        Convert.ToInt32(filaC["id_carrera"]),
                                        Convert.ToString(filaC["nombre"]),
                                        Convert.ToString(filaC["titulo"]),
                                        listaD
                                      );
                listaC.Add(carrera);
            }
            return listaC;
        }

        public bool Update(Carrera carrera)
        {
            throw new NotImplementedException();
        }
        public bool DeleteByID(int id)
        {
            List<Parametro> p = new List<Parametro>();
            p.Add(new Parametro("@id", Convert.ToString(id)));
            return helper.EjecutarSpEntrada("borrar_carrera_id", p);
        }

        public bool ExistsByID(int id)
        {
            int resultado = (int)helper.ConsultarEscalar("verificar_carrera_id", new Parametro("@id",Convert.ToString(id)));
            return resultado > 0;
        }
    }
}
