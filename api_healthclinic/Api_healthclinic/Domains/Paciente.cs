using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_healthclinic.Domains
{
    [Table("Paciente")]
    [Index(nameof(Cpf), IsUnique = true)]
    [Index(nameof(Telefone), IsUnique = true)]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O campo Nome é obrigatorio!")]
        public string? Nome { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "o campo Data de nascimento é Obrigatório !")]
        public DateTime? DataDeNascimento { get; set; }

        [Column(TypeName = "VARCHAR(11)")]
        [Required(ErrorMessage = "O campo cpf é obrigatorio!")]
        [MaxLength(11)]
        public string? Cpf { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Informe o Telefone do Paciente!!")]
        public string? Telefone { get; set; }


        [Required(ErrorMessage = "Informe o usuario!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }


    }
}
