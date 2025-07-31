class ConstrutoresSobrecarregados
{
    // Propriedades
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor padrão
    public ConstrutoresSobrecarregados()
    {
        Nome = "Desconhecido";
        Idade = 0;
    }

    // Construtor com um parâmetro
    public ConstrutoresSobrecarregados(string nome)
    {
        Nome = nome;
        Idade = 0;
    }

    // Construtor com dois parâmetros
    public ConstrutoresSobrecarregados(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    // Método para exibir informações
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
    // destrutor
    ~ConstrutoresSobrecarregados()
    {
        Console.WriteLine("Destrutor chamado para liberar recursos.");
    }
}