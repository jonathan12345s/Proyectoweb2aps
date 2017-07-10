using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoWEB2.Controllers
{
    public class Usuario
    {


        [Required]
        [Display(Name = "User Login")]


        public int id { get; set; }
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }






    }
}