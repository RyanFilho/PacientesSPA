using PacientesSPA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PacientesSPA.Data_Acess_Layer
{
    public class Context : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
    }
}