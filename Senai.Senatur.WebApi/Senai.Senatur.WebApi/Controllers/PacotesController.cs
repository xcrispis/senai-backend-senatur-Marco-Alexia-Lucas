using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        private IPacotesRepository _pacotesRepository { get; set; }

        public PacotesController()
        {
            _pacotesRepository = new PacotesRepository();
        }

        /// <summary>
        /// Método que lista todos os pacotes
        /// </summary>
        /// <returns>uma lista de pacotes</returns>
        [Authorize(Roles = "1,2")]
        [HttpGet]
        public IEnumerable<Pacotes> ListaPacote()
        {
            return _pacotesRepository.ListarPacotes();
        }

        /// <summary>
        /// Método que busca um pacote pelo seu identificador
        /// </summary>
        /// <param name="id">Identificador que será buscado</param>
        /// <returns></returns>
        [Authorize(Roles = "1,2")]
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            return Ok(_pacotesRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Método que atualiza pacote pelo seu identificador
        /// </summary>
        /// <param name="pacoteAtualizado">Objeto que será atualizado</param>
        /// <param name="id">Idetificador que será buscado para atualizar</param>
        /// <returns></returns>
        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult AtualizaPacote(Pacotes pacoteAtualizado, int id)
        {
            Pacotes pacotebuscado = _pacotesRepository.BuscarPorId(id);

            if (pacotebuscado != null)
            {
                _pacotesRepository.AtualizarPacote(pacoteAtualizado,id);

                return Ok(pacoteAtualizado);
            }
            return NotFound("Pacote não encontrado para ser atualizado!");
        }

        /// <summary>
        ///  Métofo que cadastra um novo Pacote
        /// </summary>
        /// <param name="pacotenovo">Objeto que será cadastrado</param>
        /// <returns>returna um novoPacote cadastrado</returns>
        [Authorize (Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Pacotes pacotenovo)
        {
            _pacotesRepository.CadastrarPacote(pacotenovo);

            return StatusCode(201, new { menssagem = "Pacote cadastrado com sucesso"});
        }

        [Authorize (Roles = "1, 2")]
        [HttpGet]
        public IActionResult BuscarAtivos(bool Ativo)
        {
            return Ok(_pacotesRepository.BuscarAtivos(Ativo));
        }
    }
}