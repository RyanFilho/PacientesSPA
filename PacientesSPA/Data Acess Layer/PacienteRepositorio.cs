using PacientesSPA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PacientesSPA.Data_Acess_Layer
{
    public class PacienteRepositorio
    {
        private Context _context;
        public PacienteRepositorio(Context context)
        {
            this._context = context;
        }

        public List<Paciente> GetPacientes()
        {
            return _context.Pacientes.ToList();
        }

        public Paciente GetPacientePorID(int id)
        {
            return _context.Pacientes.Find(id);
        }

        public void InserirPaciente(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
        }

        public void DeletarPaciente(int id)
        {
            Paciente paciente = _context.Pacientes.Find(id);
            _context.Pacientes.Remove(paciente);
        }

        public void AtualizaPaciente(Paciente paciente)
        {
            _context.Entry(paciente).State = EntityState.Modified;
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}