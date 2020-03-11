using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class PacotesRepository : IPacotesRepository
    {

        SenaturContext ctx = new SenaturContext();

        public void AtualizarPacote(Pacotes pacoteAtualizado, int id)
        {
            Pacotes pacoteBuscado = ctx.Pacotes.Find(id);

            
            pacoteBuscado.NomePacote = pacoteAtualizado.NomePacote;
            pacoteBuscado.Descricao = pacoteAtualizado.Descricao;
            pacoteBuscado.DataIda = pacoteAtualizado.DataIda;
            pacoteBuscado.DataVolta = pacoteAtualizado.DataVolta;
            pacoteBuscado.Valor = pacoteAtualizado.Valor;
            pacoteBuscado.IdCidade = pacoteAtualizado.IdCidade;
            pacoteBuscado.Ativo = pacoteAtualizado.Ativo;

            ctx.Pacotes.Update(pacoteBuscado);

            ctx.SaveChanges();
        }

        public Pacotes BuscarPorId(int id)
        {
            return ctx.Pacotes.FirstOrDefault(p => p.IdPacote == id);

        }

        public void CadastrarPacote(Pacotes novoPacote)
        {
            ctx.Pacotes.Add(novoPacote);

            ctx.SaveChanges();
        }

        public List<Pacotes> ListarPacotes()
        {
            return ctx.Pacotes.ToList();
        }

        public List<Pacotes> BuscarAtivos(bool Ativo)
        {
            return ctx.Pacotes.ToList().FindAll(p => p.Ativo == Ativo);
        }
    }
}
