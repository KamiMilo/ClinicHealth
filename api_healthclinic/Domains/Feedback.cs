using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_healthclinic.Domains
{
    [Table("Feedback")]
    public class Feedback
    {
        [Key]
        public Guid IdFeedback { get; set; } = Guid.NewGuid();

        //aqui é definido que cada classe será uma tabela
        [Column(TypeName = "VARCHAR(100)")]       
        public string? Comentario { get; set; }

        [Required(ErrorMessage = "Informe o usuario!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }


    }
}
