class MultiplosConstrutores2 : MultiplosConstrutores
{
    public MultiplosConstrutores2(string mensagem) : base(mensagem)
    {
        // Incrementa o contador de mensagens
        qnt_msgs++;
        Console.WriteLine($"Construtor 2° com mensagem: {mensagem}");
    }
}