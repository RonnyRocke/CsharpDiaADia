class ClasseseEncapsulamento
{
    private int numero;

    public int Numero
    {
        get { return numero; }
        set { numero = value; }
    }

    public void ExibirNumero()
    {
        Console.WriteLine($"O número é: {numero}");
    }
}