class PostoCombustivel
{
    public void abastecer()
    {
        int opt = 0;
        int Gasolina = 0, Alcool = 0, Diesel = 0;
        Console.WriteLine("Digite a opção de combustível (1-Gasolina, 2-Alcool, 3-Diesel, 4-Sair):");
        while (opt != 4)
        {
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Entrada nula! Tente novamente.");
                continue;
            }
            opt = int.Parse(input);
            switch (opt)
            {
                case 1:
                    Gasolina++;
                    break;
                case 2:
                    Alcool++;
                    break;
                case 3:
                    Diesel++;
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {Alcool}");
        Console.WriteLine($"Gasolina: {Gasolina}");
        Console.WriteLine($"Diesel: {Diesel}");
    }
}