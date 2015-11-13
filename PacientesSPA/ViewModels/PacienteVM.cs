using PacientesSPA.Data_Acess_Layer;
using PacientesSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PacientesSPA.ViewModels
{
    public class PacienteVM
    {
        public PacienteVM()
        {
            Pacientes = new List<Paciente>();
            SearchPaciente = new Paciente();
            EventCommand = "list";
        }

        public List<Paciente> Pacientes { get; set; }
        public string EventCommand { get; set; }
        public Paciente SearchPaciente { get; set; }

        public void HandleRequest()
        {
            switch (EventCommand.ToLower())
            {
                case "list" :
                case "search":
                    Get();
                    break;

                case "resetsearch":
                    ResetSearch();
                    Get();
                    break;

                default:
                    break;
            }
        }

        private void ResetSearch()
        {
            SearchPaciente = new Paciente();  
        }
        private void Get()
        {
            PacienteManager manager = new PacienteManager();
            Pacientes = manager.Get(SearchPaciente);
        }
    }
}