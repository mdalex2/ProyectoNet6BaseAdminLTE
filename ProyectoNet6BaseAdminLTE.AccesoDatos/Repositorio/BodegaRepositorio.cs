using ProyectoNet6BaseAdminLTE.AccesoDatos.Data;
using ProyectoNet6BaseAdminLTE.AccesoDatos.Repositorio.IRepositorio;
using ProyectoNet6BaseAdminLTE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNet6BaseAdminLTE.AccesoDatos.Repositorio
{
    public class BodegaRepositorio : Repositorio<Bodega> , IBodegaRepositorio
    {
        private readonly ApplicationDbContext _db;

        public BodegaRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Bodega bodega)
        {
            var bodegaDb = _db.Bodegas.FirstOrDefault(b => b.Id == bodega.Id);
            if (bodegaDb != null)
            {
                bodegaDb.Nombre = bodega.Nombre;
                bodegaDb.Descripcion = bodega.Descripcion;
                bodega.Estado = bodega.Estado;

                _db.SaveChanges();
            }
        }
    }
}
