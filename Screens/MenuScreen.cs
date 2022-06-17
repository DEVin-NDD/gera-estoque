using GeraEstoque.Repositories;
namespace GeraEstoque.Screens;

public static class MenuScreen
{
  public static void Iniciar(ProdutoRepository repository)
  {
    Console.Clear();
    System.Console.WriteLine("Seja bem vindo!");
    System.Console.WriteLine("----------------------------");
    System.Console.WriteLine(@"
1 - Cadastrar Produto
2 - Consultar Produto
3 - Modificar Produto
4 - Excluir Produto
5 - Listar Produtos
0 - Sair
    ");

    System.Console.Write("Opção: ");
    var option = short.Parse(Console.ReadLine()!);

    switch (option)
    {
      case 1: CriarProdutoScreen.Iniciar(repository); Iniciar(repository); break;
      case 5: ListarProdutosScreen.Iniciar(repository); Iniciar(repository); break;
      default: Environment.Exit(0); break;
    }
  }

}