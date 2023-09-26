using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_healthclinic.Domains
{
    [Table("Paciente")]
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

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Informe o sexo do paciente!")]
        public string? Sexo { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Informe o Telefone do Paciente!!")]
        public string? Telefone { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Informe um email!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Informe o usuario!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }


    }
}
