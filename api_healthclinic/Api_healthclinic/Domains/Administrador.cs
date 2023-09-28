using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_healthclinic.Domains
{
    [Table("Administrador")]
    public class Administrador
    {
        [Key]
        public Guid IdAdministrador { get; set; } = Guid.NewGuid();

        //aqui é definido que cada classe será uma tabela
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O campo Nome é obrigatorio!")]
        public string? Nome { get; set; }


        //tabela que referencia a Chave estrangeira(Tabela de Tipo Usuario)
        [Required(ErrorMessage = "Informe o usuario!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }
    }
}
