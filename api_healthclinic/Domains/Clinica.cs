using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_healthclinic.Domains
{
    [Table("Clinica")]
    [Index(nameof(Cnpj),IsUnique=true)]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();

        //aqui é definido que cada classe será uma tabela
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O campo Nome é obrigatorio!")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O endereço é obrigatório!")]
        public string? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O cep é obrigatório!")]
        public string? Cep { get; set; }


        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "O CNPJ da clinica é obrigatório!")]
        [StringLength(14)]
        public string? Cnpj { get; set; }



        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "O horario de abertura é obrigatório!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"hh\:mm")]
        public TimeSpan? HorarioAbertura { get; set; }



        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "O horario de Fechamento é obrigatório!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"hh\:mm")]
        public TimeSpan? HorarioFechamento { get; set; }



        [Column(TypeName = "VARCHAR")]
        [Required(ErrorMessage = "a Razão Social é obrigatória!")]
        public string? RazaoSocial { get; set; }



    }
}
