using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_healthclinic.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email),IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome de usuario é obrigatorio!")]
        public string? Nome { get; set; }

        //aqui é definido que cada classe será uma tabela
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome de usuario é obrigatorio!")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "a Senha é Obrigatória!")]
        [StringLength(100,MinimumLength= 5,ErrorMessage= "a senha deve conter de 5 á 12 caracteres")]
        public string? Senha { get; set; }

        //tabela que referencia a Chave estrangeira(Tabela de Tipo Usuario)
        [Required(ErrorMessage = "Informe o Tipo de usuario!")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TipoUsuario? tipoUsuario { get; set; }
    }
}
