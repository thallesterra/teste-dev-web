using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharlieEDogs.Models.Entities
{
    public class Cidade
    {
        public int IdCidade { get; set; }

        public string NomeCidade { get; set; }

        public Cidade() { }

        public Cidade(string nome)
        {
            this.NomeCidade = nome;
        }
    }
}