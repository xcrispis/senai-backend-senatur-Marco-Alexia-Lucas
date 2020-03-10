using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Pacotes
    {
        public int IdPacote { get; set; }

        [Required(ErrorMessage = "O Nome do pacote é obrigatório")]
        public string NomePacote { get; set; }

        public string Descricao { get; set; }

        public DateTime DataIda { get; set; }

        public DateTime DataVolta { get; set; }

        public decimal Valor { get; set; }

        public int IdCidade { get; set; }

        public bool Ativo { get; set; }

        public Cidades IdCidadeNavigation { get; set; }
    }
}
