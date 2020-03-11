﻿using Microsoft.EntityFrameworkCore;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        SenaturContext ctx = new SenaturContext();

        public List<Usuario> Listarusuario()
        {
            return ctx.Usuario.Include(u => u.IdTipoUsuarioNavigation).ToList();
        }

        public Usuario Logar(string email, string senha)
        {
            return ctx.Usuario.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
