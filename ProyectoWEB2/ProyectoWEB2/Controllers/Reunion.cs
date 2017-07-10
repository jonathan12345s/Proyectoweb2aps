using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWEB2.Controllers
{
    public class Reunion
    {




        //        Título de la reunión
        //Dia y hora
        //Usuario asignado(Listado de Usuarios del sistema, debe seleccionar al menos uno)
        //Es Virtual(checkbox)
        //Cliente(opcional)

        public int id { get; set; }
        public DateTime diayhora { get; set; }
        public String usuarios { get; set; }

        public String Virtual { get; set; }

        public String clientes { get; set; }

        public string ClienteNombre { get; set; }



        public virtual Cliente Clientecontacto { get; set; }








    }
}