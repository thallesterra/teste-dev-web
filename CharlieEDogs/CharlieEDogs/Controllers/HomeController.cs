using CharlieEDogs.Models;
using CharlieEDogs.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharlieEDogs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ReturnDogs()
        {
            IList<Cachorro> cachorros = new List<Cachorro>();
            cachorros = new ModelDAL().ListarCachorros();
            
            return Json(cachorros, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Checkout(int id)
        {
            IList<Cachorro> cachorros = new List<Cachorro>();

            cachorros = new ModelDAL().ListarCachorros();

            Cachorro _dog = new Cachorro();

            _dog = cachorros.First(x => x.IdCachorro == id);

            return View(_dog);
        }

        [HttpPost]
        public ActionResult InserirCarrinho(FormCollection frm)
        {
            var nome = frm["nome"].ToString();
            var email = frm["email"].ToString();
            var cpf = frm["cpf"].ToString();
            var endereco = frm["endereco"].ToString();
            var numero = frm["numero"].ToString();
            var complemento = frm["complemento"].ToString();
            var bairro = frm["bairro"].ToString();
            var cidade = frm["cidade"].ToString();
            var cep = frm["cep"].ToString();
            var qtd = int.Parse(frm["qtd"].ToString());
            var idCachorro = int.Parse(frm["idcachorro"].ToString());

            Pessoa _pessoa = new Pessoa();
            _pessoa.Nome = nome;
            _pessoa.Email = email;
            _pessoa.CPF = cpf;
            _pessoa.IdPessoa = new ModelDAL().InserirPessoa(_pessoa);

            Compra _compra = new Compra(_pessoa.IdPessoa, idCachorro, qtd);
            _compra.IdCompra = new ModelDAL().InserirCompra(_compra);

            Cidade _cidade = new Cidade(cidade);
            _cidade.IdCidade = new ModelDAL().InserirCidade(_cidade);
            
            Endereco _endereco = new Endereco();
            _endereco.Bairro = bairro;
            _endereco.CEP = cep;
            _endereco.Complemento = complemento;
            _endereco.Numero = numero;
            _endereco.Rua = endereco;
            _endereco.IdCidade = _cidade.IdCidade;
            _endereco.IdEndereco = new ModelDAL().InserirEndereco(_endereco);


            return RedirectToAction("Index", "Home");
        }
    }
}