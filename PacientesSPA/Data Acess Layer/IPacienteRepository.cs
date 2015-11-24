using PacientesSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PacientesSPA.Data_Acess_Layer
{
    interface IPacienteRepository : IDisposable
    {
        IEnumerable<Paciente> GetAll();
        Paciente GetPacientePorID(int id);
        void InserirPaciente(Paciente paciente);
        void DeletarPaciente(int id);
        void AtualizaPaciente(Paciente paciente);
        void Salvar();
    }
}