using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWEB2.Controllers
{
    public class Tickets
    {





        public int id { get; set; }


        public String Titulo { get; set; }


        public String detalle { get; set; }


        public String reportado { get; set; }

        public String clienye { get; set; }

        public String estado { get; set; }



        public virtual Cliente Clientecontacto { get; set; }





    }
}