using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4_Basico.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }


    }
}