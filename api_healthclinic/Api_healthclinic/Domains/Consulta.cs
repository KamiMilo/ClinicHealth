using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_healthclinic.Domains
{
    [Table("Consulta")]
    public class Consulta
    {
        [Key]
        public Guid IdConsulta { get; set; }= Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "O campo Data é obrigatorio!")]
        public DateTime? DataDaConsulta { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"dd\mm\yyyy")]

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "O campo Horario é obrigatorio!")]
        public TimeSpan? HoraConsulta { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"hh\:mm")]

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrição é obrigatória!")]
        public string Descricao { get; set; }


        //**********FOREIGN KEYS*************************
        [Required(ErrorMessage = "Informe o Tipo de usuario!")]
        public Guid IdPaciente { get; set; }

        [ForeignKey("IdPaciente")]
        public Paciente? paciente { get; set; }

        ///////////////////////////////////////////////////

        [Required(ErrorMessage ="O médico é obrigatório!!")]

        public Guid IdMedico { get; set; }

        [ForeignKey("IdMedico")]

        public Medico? Medico { get; set; }

        //////////////////////////////////////////////
        
        [Required(ErrorMessage ="informe o Paciente!!")]
        public Guid IdFeedback{ get; set; }

        [ForeignKey("IdFeedback")]
        public Feedback? Feedback { get; set; }

    }
}
