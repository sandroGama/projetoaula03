using ProjetoAula03.Entities;
using ProjetoAula03.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Controllers
{
    /// <summary>
    /// Classe de controle para operações de pessoa
    /// </summary>
    public class PessoaController
    {
        public void CadastrarPessoa()
        {
            try
            {
                Console.WriteLine("\n *** CADASTRO DE PESSOA ***\n");

                var pessoa = new Pessoa();
                pessoa.IdPessoa = Guid.NewGuid();

                Console.Write("Informe o nome da pessoa...............: ");
                pessoa.Nome = Console.ReadLine();

                Console.Write("Informe o cpf da pessoa................: ");
                pessoa.Cpf = Console.ReadLine();

                Console.Write("Informe a data de nascimento da pessoa.: ");
                pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());

                var pessoaRepository = new PessoaRepository();
                pessoaRepository.Create(pessoa);

                Console.WriteLine("\nPessoa cadastrada com sucesso!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"\nErro de validação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFalha ao cadastrar: {e.Message}");
            }
            finally
            {
                Console.Write("\nDeseja repetir o processo? (S,N): ");
                var opcao = Console.ReadLine();

                if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    CadastrarPessoa(); //recursividade
                }
            }
        }
    }
}



