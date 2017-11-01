using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharlieEDogs.Models.Entities
{
    public class Compra
    {
        public int IdCompra { get; set; }

        public int IdPessoa { get; set; }

        public int IdCachorro { get; set; }

        public int Quanitdade { get; set; }

        public Compra() { }

        public Compra(int idPessoa, int idCachorro, int qtd)
        {
            this.IdCachorro = idCachorro;
            this.IdPessoa = idPessoa;
            this.Quanitdade = qtd;
        }
    }
}