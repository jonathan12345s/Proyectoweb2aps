using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWEB2.Controllers
{
    public class Contacto
    {





        public int id { get; set; }



        public String Nombre { get; set; }

        public String Apellidos { get; set; }

        public String correo { get; set; }

        public string telefono { get; set; }

        public string puesto { get; set; }


        public string ClienteNombre { get; set; }
        public virtual Cliente Clientecontacto { get; set; }


    }
}