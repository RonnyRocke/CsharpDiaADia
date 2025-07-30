public class Produtos
{ 
    public required string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }
}