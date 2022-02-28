using ProyectoNet6BaseAdminLTE.AccesoDatos.Data;
using ProyectoNet6BaseAdminLTE.AccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNet6BaseAdminLTE.AccesoDatos.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _db;
        public IBodegaRepositorio Bodega { get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Bodega = new BodegaRepositorio(_db); // Inicializamos

        }

        public async Task Guardar()
        {
            await _db.SaveChangesAsync();
        }
        
        public async ValueTask DisposeAsync()
        {
            await _db.DisposeAsync();
        }
    }
}
