using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharlieEDogs.Models.Entities
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }
    }
}