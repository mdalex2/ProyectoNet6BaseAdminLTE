using Microsoft.EntityFrameworkCore;
using ProyectoNet6BaseAdminLTE.AccesoDatos.Data;

namespace ProyectoNet6BaseAdminLTE.Data
{
    public class SysDBContext : ApplicationDbContext
    {
        public SysDBContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }

}
