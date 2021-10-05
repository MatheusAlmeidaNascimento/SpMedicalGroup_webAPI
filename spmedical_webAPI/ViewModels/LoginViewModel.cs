using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_webAPI.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "O campo e-mail é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório!")]
        public string Senha { get; set; }

    }
}
