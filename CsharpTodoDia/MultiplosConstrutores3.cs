class MultiplosConstrutores3 : MultiplosConstrutores2
{
    public MultiplosConstrutores3(string mensagem) : base(mensagem)
    {
        // Incrementa o contador de mensagens
        qnt_msgs++;   
        Console.WriteLine($"Construtor 3° com mensagem: {mensagem}");
    }
}