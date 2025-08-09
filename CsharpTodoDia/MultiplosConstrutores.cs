class  MultiplosConstrutores
{
   public static int qnt_msgs = 0;
    
    public MultiplosConstrutores(string mensagem)
    {
        // Incrementa o contador de mensagens
   
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine($"{qnt_msgs}°");
            
        }
        Console.WriteLine($"Construtor 1° com mensagem: {mensagem}");
    }
}