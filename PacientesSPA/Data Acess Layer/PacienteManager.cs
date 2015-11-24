using PacientesSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PacientesSPA.Data_Acess_Layer
{
    public class PacienteManager
    {
        public PacienteManager()
        {
            ValidationErros = new List<KeyValuePair<string, string>>();
        }

        public List<KeyValuePair<string, string>> ValidationErros { get; set; }

        public bool Validate(Paciente entity)
        {
            ValidationErros.Clear();

            if (!string.IsNullOrEmpty(entity.Nome) && entity.Nome.ToLower() == entity.Nome)
            {
                ValidationErros.Add(new KeyValuePair<string, string>("Nome do Paciente", "O Nome do paciente não pode ser todo minúsculo."));
            }

            return ValidationErros.Count == 0;
        }
        public bool Insert(Paciente entity)
        {
            bool ret = false;
            ret = Validate(entity);

            if (ret)
            {
                // TODO: Create INSERT code here
                try
                {
                    var repository = new PacienteRepositorio(new Context());
                    repository.InserirPaciente(entity);
                    repository.Salvar();
                }
                catch (Exception)
                {                                     
                }

                
            }

            return ret;
        }


        public List<Paciente> Get(Paciente searchPaciente)
        {
            List<Paciente> pacientes = new List<Paciente>();

            //TODO: Add you own data acess method here
            var repository = new PacienteRepositorio(new Context());
            pacientes = repository.GetPacientes();

            if (!string.IsNullOrEmpty(searchPaciente.Nome))
            {
                pacientes = pacientes.FindAll(p => p.Nome.ToLower().StartsWith(searchPaciente.Nome, StringComparison.CurrentCultureIgnoreCase));
            }

            return pacientes;
        }

        private List<Paciente> CreateMockData()
        {
            return new List<Paciente>()
            {
                new Paciente () { Id = 1, Nome = "Cicrano da Silva", Nascimento = Convert.ToDateTime("11/11/2011"), Responsavel = "Mãe do Cicrano" },
                new Paciente () { Id = 2, Nome = "Fulano da Silva", Nascimento = Convert.ToDateTime("10/10/2010"), Responsavel = "Mãe do Fulano" },
                new Paciente () { Id = 3, Nome = "Deltrano da Silva", Nascimento = Convert.ToDateTime("9/9/2009"), Responsavel = "Mãe do Deltrano"}                
            };
        }
    }
}