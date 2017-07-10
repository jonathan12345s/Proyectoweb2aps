using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoWEB2.Models
{
    public class ProyectoWEB2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProyectoWEB2Context() : base("name=ProyectoWEB2Context")
        {
        }

        public System.Data.Entity.DbSet<ProyectoWEB2.Controllers.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<ProyectoWEB2.Controllers.Contacto> Contactoes { get; set; }

        public System.Data.Entity.DbSet<ProyectoWEB2.Controllers.Reunion> Reunions { get; set; }

        public System.Data.Entity.DbSet<ProyectoWEB2.Controllers.Tickets> Tickets { get; set; }

        ///   public System.Data.Entity.DbSet<ProyectoWEB2.Controllers.Usuario> Usuarios { get; set; }
    }
}
