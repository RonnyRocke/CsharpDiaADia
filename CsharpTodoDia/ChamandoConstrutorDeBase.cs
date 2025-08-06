class ChamandoConstrutorDeBase : Base
{

    public ChamandoConstrutorDeBase(string nome, string cpf, int idade) : base(nome, cpf, idade)
    {
        this.nome = nome;          
        Console.WriteLine("Nome: " + nome);
    }
    public void MostrarDados()
    {
        Console.WriteLine("CPF: " + getCpf());
        Console.WriteLine("Idade: " + getIdade());
    }
}