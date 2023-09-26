using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_healthclinic.Domains
{
    [Table("Especialidade")]
    public class Especialidade
    {
        [Key]
        public Guid IdEspecialidade { get; set; }= Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Informe a Especialidade!")]
        public string? EspecialidadeNome { get; set; }
    }
}
