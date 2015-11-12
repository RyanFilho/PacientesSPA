using PacientesSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PacientesSPA.Data_Acess_Layer
{
    public class PacienteManager
    {
        public List<Paciente> Get()
        {
            List<Paciente> pacientes = new List<Paciente>();

            //TODO: Add you own data acess method here
            pacientes = CreateMockData();

            return pacientes;
        }

        private List<Paciente> CreateMockData()
        {
            return new List<Paciente>()
            {
                new Paciente () { Id = 1, Nome = "Cicrano da Silva", Nascimento = Convert.ToDateTime("11/11/2011") ,Acompanhante = "Mãe do Cicrano" },
                new Paciente () { Id = 2, Nome = "Fulano da Silva", Nascimento = Convert.ToDateTime("10/10/2010") ,Acompanhante = "Mãe do Fulano" },
                new Paciente () { Id = 3, Nome = "Deltrano da Silva", Nascimento = Convert.ToDateTime("9/9/2009") ,Acompanhante = "Mãe do Deltrano"}                
            };
        }
    }
}