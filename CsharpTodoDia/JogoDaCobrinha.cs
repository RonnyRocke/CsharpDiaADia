class JogoDaCobrinha
{
    public void Iniciar()
    {
        // Lógica para iniciar o jogo da cobrinha
        Console.WriteLine("Jogo da Cobrinha iniciado!");
        Console.WriteLine("Use as setas do teclado para mover a cobrinha.");
        Console.WriteLine("Pressione 'Esc' para sair do jogo.");
        Console.WriteLine("Boa sorte!");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Instruções:");
        Console.WriteLine("1. Use as setas do teclado para mover a cobrinha.");
        Console.WriteLine("2. Coma maçãs para crescer.");
        Console.WriteLine("3. Evite obstáculos.");
        Console.WriteLine("4. Tente sobreviver o máximo possível.");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Pressione qualquer tecla para começar...");
        Console.ReadLine();
    }

    public void Jogar()
    {
        // Lógica para jogar o jogo da cobrinha
        Console.WriteLine("Jogando o jogo da cobrinha...");
        // Simulação de jogo
        for (int i = 0; i < 5; i++)
        {
            // Simula o movimento da cobrinha
            Console.WriteLine("A cobrinha está se movendo...");
            // Exibe o estado atual do jogo
            Console.WriteLine($"Estado do jogo: Movimento {i + 1}");
            // Simula a lógica do jogo
            if (i % 2 == 0)
            {
                Console.WriteLine("A cobrinha está se movendo para a frente.");
            }
            else
            {
                Console.WriteLine("A cobrinha está se movendo para a direita.");
            }

            Console.WriteLine($"Movimento {i + 1}: A cobrinha se moveu.");
            // Simulação de tempo de jogo
            System.Threading.Thread.Sleep(1000);
            if (i == 2)
            {
                Console.WriteLine("A cobrinha comeu uma maçã!");
            }
            if (i == 4)
            {
                Console.WriteLine("A cobrinha encontrou um obstáculo e perdeu!");
                break;
            }
            if (i == 3)
            {
                Console.WriteLine("A cobrinha ganhou um ponto!");
            }
            if (i == 1)
            {
                Console.WriteLine("A cobrinha está crescendo!");
            }
            if (i == 0)
            {
                Console.WriteLine("A cobrinha está começando a se mover...");
            }
            if (i == 4)
            {
                Console.WriteLine("Fim do jogo!");
                break;
            }
        }
    }

    public void Encerrar()
    {
        // Lógica para encerrar o jogo da cobrinha
        Console.WriteLine("Jogo da Cobrinha encerrado!");
        Console.WriteLine("Obrigado por jogar!");
        Console.WriteLine("Esperamos que você tenha se divertido!");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadLine();
        Console.WriteLine("Saindo do jogo...");
        Console.WriteLine("Até a próxima!");
        Console.WriteLine("----------------------------");
    }
}