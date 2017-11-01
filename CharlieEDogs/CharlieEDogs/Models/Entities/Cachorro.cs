using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharlieEDogs.Models.Entities
{
    public class Cachorro
    {
        public int IdCachorro { get; set; }
        public string Nome { get; set; }

        public int Idade { get; set; }

        public double Preco { get; set; }

        public string Foto { get; set; }

        public int IdPorte { get; set; }

        public string Porte { get; set; }
    }
}