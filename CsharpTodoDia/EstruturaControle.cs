class EstruturaControle
{
    public void estruturaControle()
    {
        // Exemplo de estrutura de controle: if-else
        int numero = 10;
        if (numero > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é negativo.");
        }
        else
        {
            Console.WriteLine("O número é zero.");
        }

        // Exemplo de estrutura de controle: switch
        string diaDaSemana = "Segunda";
        switch (diaDaSemana)
        {
            case "Segunda":
                Console.WriteLine("Hoje é segunda-feira.");
                break;
            case "Terça":
                Console.WriteLine("Hoje é terça-feira.");
                break;
            default:
                Console.WriteLine("Hoje é outro dia da semana.");
                break;
        }
    }
}