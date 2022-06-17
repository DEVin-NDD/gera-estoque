using GeraEstoque.Repositories;
using GeraEstoque.Models;
namespace GeraEstoque.Screens;

public static class CriarProdutoScreen
{
  public static void Iniciar(ProdutoRepository repository)
  {
    Console.Clear();
    System.Console.Write("Nome do produto: ");
    var name = Console.ReadLine();
    System.Console.Write("Quantidade em estoque: ");
    var qty = int.Parse(Console.ReadLine()!);
    System.Console.Write("Valor de compra: ");
    var buyValue = int.Parse(Console.ReadLine()!);
    System.Console.Write("Valor de venda: ");
    var sellingValue = int.Parse(Console.ReadLine()!);
    var prodId = Guid.NewGuid().ToString();

    var produto = new Produto(name!, qty, buyValue, sellingValue);
    System.Console.WriteLine("Produto cadastraro com sucesso!");
    repository.Produtos.Add(produto);
    Console.ReadLine();
  }
}