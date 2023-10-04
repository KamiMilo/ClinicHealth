using System.ComponentModel.DataAnnotations;

namespace Api_healthclinic.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage ="O email é Obrigatório!!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A Senha é Obrigatório!!")]
        public string? Senha { get; set; }

    }
}
