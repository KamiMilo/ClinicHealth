using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Api_healthclinic.Domains
{
    [Table("Medico")]
    [Index(nameof(Crm),IsUnique =true)]
    public class Medico
    {
        [Key]

        public Guid IdMedico { get; set; } = Guid.NewGuid();

        //aqui é definido que cada classe será uma tabela
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O campo Nome é obrigatorio!")]
        public string? Nome { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A Data de nascimento é obrigatória!")]
     
        public DateTime? DatadeNascimento { get; set; }

        [Column(TypeName = "VARCHAR(10)")]
        [Required(ErrorMessage = "informe o CRM do médico!")]
        [StringLength(10)]
        public string? Crm { get; set; }


        //tabela que referencia a Chave estrangeira(Tabela de Tipo Usuario)
        [Required(ErrorMessage = "Informe o usuario!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }



        [Required(ErrorMessage ="A especialidade é Obrigatória!")]
        public Guid IdEspecialidade { get; set; }

        [ForeignKey("IdEspecialidade")]
        public  Especialidade? Especialidade { get; set; }


        public Guid IdClinica { get; set; }

        [ForeignKey("IdClinica")]
        public Clinica? Clinica { get; set; }


    }
}
