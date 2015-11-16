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
            ListMode();

            Pacientes = new List<Paciente>();
            SearchPaciente = new Paciente();
            Entity = new Paciente();
            EventCommand = "list";
        }

        public List<Paciente> Pacientes { get; set; }
        public Paciente Entity { get; set; }
        public bool IsValid { get; set; }
        public string EventCommand { get; set; }
        public Paciente SearchPaciente { get; set; }
        public string Mode { get; set; }
        public bool IsDetailAreaVisible { get; set; }
        public bool IsListAreaVisible { get; set; }
        public bool IsSearchAreaVisible { get; set; }

        private void Init()
        {
            EventCommand = "List";
            ListMode();
        }

        public void HandleRequest()
        {
            switch (EventCommand.ToLower())
            {
                case "list" :
                case "search":
                    Get();
                    break;


                case "save":
                    break;

                case "resetsearch":
                    ResetSearch();
                    Get();
                    break;

                case "add":
                    Add();
                    break;

                case "cancel":
                    ListMode();
                    Get();
                    break;

                default:
                    break;
            }
        }

        private void AddMode()
        {
            IsDetailAreaVisible = true;
            IsListAreaVisible = false;
            IsSearchAreaVisible = false;
            Mode = "Add";
        }

        private void Add()
        {
            IsValid = true;

            Entity = new Paciente();

            AddMode();
        }
        private void ListMode()
        {
            IsValid = true;
            IsSearchAreaVisible = true;
            IsListAreaVisible = true;
            IsDetailAreaVisible = false;
            Mode = "List";
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