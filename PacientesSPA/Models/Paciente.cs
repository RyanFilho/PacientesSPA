using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PacientesSPA.Models
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome do paciente deve ser preenchido.")]
        [Display(Description = "Nome do Paciente.")]
        [StringLength(150, MinimumLength = 4, ErrorMessage = "O Nome do paciente deve ter entre {2} e {1} caracteres.")]
        public string Nome { get; set; }
        [Range(typeof(DateTime), "1/1/1800", "31/12/2020", ErrorMessage = "A Data de Nascimento deve ser entre {1} e {2}.")]
        public DateTime Nascimento { get; set; }
        [Required(ErrorMessage = "O Nome do Responsável deve ser preenchido.")]
        [Display(Description = "Nome do Responsável.")]
        [StringLength(150, MinimumLength = 4, ErrorMessage = "O Nome do responsável deve ter entre {2} e {1} caracteres.")]
        public string Responsavel { get; set; }
    }
}