namespace GeraEstoque.Models;
public class Produto
{

  public string Id { get; set; }
  public string Nome { get; set; }
  public int Quantidade { get; set; }
  public int ValorCusto { get; set; }
  public int ValorVenda { get; set; }

  public Produto() { }

  public Produto(string nome, int quantidade, int valorCusto, int valorVenda)
  {
    Id = Guid.NewGuid().ToString();
    Nome = Nome;
    Quantidade = quantidade;
    ValorCusto = valorCusto;
    ValorVenda = valorVenda;
  }

  public override string ToString()
  {
    return string.Format("Produto: Id: {0} | Nome: {1} | Qtd: {2}| R$ Compra: {3:c} | R$ Venda: {4:c}",
      Id,
      Nome,
      Quantidade,
      ValorCusto,
      ValorVenda
    );
  }

}