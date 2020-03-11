using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    public interface IPacotesRepository 
    {
        List<Pacotes> ListarPacotes();

        void CadastrarPacote(Pacotes pacoteAtualizado);

        Pacotes BuscarPorId(int id);

        void AtualizarPacote(Pacotes novoPacote, int id);

    }
}
