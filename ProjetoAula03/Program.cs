using ProjetoAula03.Controllers;

namespace ProjetoAula03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pessoaController = new PessoaController();
            pessoaController.CadastrarPessoa();
            Console.ReadKey();
        }
    }
}