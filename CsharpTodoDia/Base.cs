class Base
{
    public string nome;
    protected string cpf;
    private int idade;

     public Base(string nome, string cpf, int idade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this .idade = idade;
    }
    public string getCpf()
    {
        return cpf;
    }
    public int getIdade()
    {
        return idade;
    }
}