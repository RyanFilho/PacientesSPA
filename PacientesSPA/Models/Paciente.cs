using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PacientesSPA.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Acompanhante { get; set; }
    }
}