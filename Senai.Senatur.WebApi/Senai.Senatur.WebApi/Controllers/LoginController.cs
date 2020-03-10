using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;
using Senai.Senatur.WebApi.ViewModels;

namespace Senai.Senatur.WebApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    
    public class LoginController : ControllerBase
    {

        private IUsuarioRepository _UsuarioRepository { get; set; }

        public LoginController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }

       
        [HttpPost]
        public IActionResult Post(LoginViewModel login)
        {
            Usuario usuario = _UsuarioRepository.Logar(login.Email, login.Senha);

            return Ok(usuario);
        }
    }
}