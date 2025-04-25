using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroAPI.Model
{

    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }
}
