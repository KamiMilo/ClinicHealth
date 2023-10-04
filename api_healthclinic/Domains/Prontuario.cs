using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_healthclinic.Domains
{
    [Table("Prontuario")]
    public class Prontuario
    {
        [Key]
        public Guid IdProntuario { get; set; } = Guid.NewGuid();

        [Column(TypeName ="DATE")]
        [Required(ErrorMessage = "Informe a data de abertura!!")]
        public DateTime? DataAbertura { get; set; }


        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Informe a descrição do prontuario!!")]
        public string? Descricao { get; set; }


        [Required(ErrorMessage ="Informe a consulta que irá para o prontúario")]
        public Guid IdConsulta { get; set; }

        [ForeignKey(nameof(IdConsulta))]
        public Consulta? consulta { get; set; }
    }
}
