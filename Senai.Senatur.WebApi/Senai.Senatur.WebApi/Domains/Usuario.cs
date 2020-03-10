using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Usuario
    {

        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public int? IdTipoUsuario { get; set; }

        public TipoUsuario IdTipoUsuarioNavigation { get; set; }
    }
}
