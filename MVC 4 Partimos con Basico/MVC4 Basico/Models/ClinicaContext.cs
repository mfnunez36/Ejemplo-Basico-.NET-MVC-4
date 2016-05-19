using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC4_Basico.Models
{
    public class ClinicaContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
    }
}