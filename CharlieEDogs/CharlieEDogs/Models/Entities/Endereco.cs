using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharlieEDogs.Models.Entities
{
    public class Endereco
    {
        public int IdEndereco { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string CEP { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public int IdCidade { get; set; }
    }
}