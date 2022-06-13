namespace GeraEstoque;

class Program
{
  static void Main(string[] args)
  {
    System.Console.WriteLine("Seja bem vindo!");
    System.Console.WriteLine("----------------------------");
    System.Console.WriteLine(@"
1 - Cadastrar Produto
2 - Consultar Produto
3 - Modificar Produto
4 - Excluir Produto
0 - Sair
    ");

    System.Console.Write("Opção: ");
    var option = short.Parse(Console.ReadLine());

    switch (option)
    {
      case 1: CadastrarProduto(); break;
      default: Environment.Exit(0); break;
    }
  }

  static void CadastrarProduto()
  {
    Console.Clear();
    System.Console.Write("Nome do produto: ");
    var name = Console.ReadLine();
    System.Console.Write("Quantidade em estoque: ");
    var qty = int.Parse(Console.ReadLine());
    System.Console.Write("Valor de compra: ");
    var buyValue = Console.ReadLine();
    System.Console.Write("Valor de venda: ");
    var sellingValue = Console.ReadLine();
    var prodId = Guid.NewGuid().ToString();

    System.Console.WriteLine("Produto cadastraro com sucesso!");
    System.Console.WriteLine(string.Format(@"
ID: {0}
Nome: {1}
Quantidade em estoque: {1}
R$ compra: {1}
R$ venda: {1}    
    ",
     prodId,
     name,
     qty,
     buyValue,
     sellingValue));
    Console.ReadLine();
    Environment.Exit(0);
  }
}