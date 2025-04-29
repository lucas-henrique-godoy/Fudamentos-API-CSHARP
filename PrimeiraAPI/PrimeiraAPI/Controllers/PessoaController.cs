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
        public ActionResult<Pessoa>BuscarPessoaPorId(int id)
        {
            var lista = new List<Pessoa>
            {
                new Pessoa  {Id = 1, Nome = "Lucas", Idade = 27, Cpf = "44003132053", Email = "lucas@email.com"},
                new Pessoa  {Id = 2, Nome = "Mariana", Idade = 31,  Cpf = "11223344556", Email = "mariana@email.com" }
            };

            var Pessoa = lista.FirstOrDefault(p => p.Id == id);
            if(Pessoa == null)
            {
                return NotFound(); //Retorna erro 404 se nãoa achou
            }

            return Ok(Pessoa);
        }
        
    }

}
