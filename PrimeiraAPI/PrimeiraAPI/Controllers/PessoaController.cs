using CadastroAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        [HttpGet("ListarPessoas")]
        public IEnumerable<Pessoa> ListarPessoas()
        {
            var lista = new List<Pessoa>
            {
                new Pessoa {Id = 1, Nome = "Lucas", Idade = 27, Cpf = "44003132053",  Email = "lucas@email.com"},
                new Pessoa {Id = 2, Nome = "Mariana", Idade = 31, Cpf = "11223344556", Email = "mariana@email.com" }
            };

            return lista;
        }

        [HttpGet("{id})")]
        public ActionResult<Pessoa> BuscarPessoaPorId(int id)
        {
            var lista = new List<Pessoa>
            {
                new Pessoa  {Id = 1, Nome = "Lucas", Idade = 27, Cpf = "44003132053", Email = "lucas@email.com"},
                new Pessoa  {Id = 2, Nome = "Mariana", Idade = 31,  Cpf = "11223344556", Email = "mariana@email.com" }
            };

            var Pessoa = lista.FirstOrDefault(p => p.Id == id);
            if (Pessoa == null)
            {
                return NotFound(); //Retorna erro 404 se não achou
            }

            return Ok(Pessoa);
        }

        [HttpGet("{cpf}")] //Nome deve ser igual ao parâmetro
        public ActionResult<Pessoa>BuscarPessoaPorCpf(string cpf) //nome deve ser igual à URL 
        {
            var lista = new List<Pessoa>
            {
                new Pessoa  {Id = 1, Nome = "Lucas", Idade = 27, Cpf = "44003132053", Email = "lucas@email.com"},
                new Pessoa  {Id = 2, Nome = "Mariana", Idade = 31,  Cpf = "11223344556", Email = "mariana@email.com" }
            };

            var pessoa = lista.FirstOrDefault(p => p.Cpf == cpf);
            if (pessoa == null) 
            { 
                return NotFound();
            }

            return Ok(pessoa);
        }

        [HttpPost]
        public ActionResult<Pessoa> AdicionarPessoa(Pessoa novaPessoa)
        {
            return Ok(novaPessoa);
        }

    }

}
