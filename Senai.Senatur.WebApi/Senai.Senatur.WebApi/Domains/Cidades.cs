using System;
using System.Collections.Generic;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Cidades
    {
        public Cidades()
        {
            Pacotes = new HashSet<Pacotes>();
        }

        public int IdCidade { get; set; }

        public string NomeCidade { get; set; }

        public ICollection<Pacotes> Pacotes { get; set; }
    }
}
