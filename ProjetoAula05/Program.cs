using ProjetoAula05.Controllers;

namespace ProjetoAula05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var produtoController = new ProdutoController();
            try
            {
                Console.WriteLine("(1) Cadastrar Produto...;");
                Console.WriteLine("(2) Atualizar Produto...;");
                Console.WriteLine("(3) Excluir Produto.....;");
                Console.WriteLine("(4) Consultar Produtos..;");
                Console.WriteLine("\n Entre com a opção desejada: ");

                var opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        produtoController.CadastrarProduto();
                        break;

                    case 2:
                        produtoController.AtualizarProduto();
                        break;
                    case 3:
                        produtoController.ExcluirProduto();
                        break;
                    case 4:
                        produtoController.ConsultarProdutos();
                        break;
                    default:
                        Console.WriteLine("\n Opção inválida.");
                        break;

                }

                Console.Write("\nDeseja continuar? (S, N): ");
                var escolha = Console.ReadLine();

                if (escolha == "S")
                {
                    Console.Clear();
                    Main(args);
                }
                else
                {
                    Console.WriteLine("\n Fim do programa!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n Erro:{ex.Message}");
            }


            Console.ReadKey();
        }
    }
}
