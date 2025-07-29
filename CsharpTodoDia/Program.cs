using System;

namespace CsharpTodoDia
{
    // This is the main entry point for the application.
    class Program
    {
        static void Main(string[] args)
        {
            #region PrimeiroHelloWorld
            // Este é o primeiro programa em C# que imprime "Hello, World!" na tela.    
            Console.WriteLine("C# Todo Dia");
            Console.WriteLine("----------------------------");
            Console.WriteLine("\tPrimeiro Hello World em C#: ");
            Console.WriteLine("\nHello, World!");
            Funcao funcao = new Funcao();
            // Chama o método msg da classe Funcao para imprimir uma mensagem.
            funcao.msg();
            Console.WriteLine("\tEste aqui tá chamando uma função ao invés de um Console.WriteLine.");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            #endregion
            #region TiposPrimitivos
            // Exemplo de tipos primitivos em C#
            TiposPrimitivos tiposPrimitivos = new TiposPrimitivos();
            tiposPrimitivos.ExemploTipos();
            // Imprime os valores dos tipos primitivos
            #endregion
            #region PassagemPorReferencia e PassagemPorValor
            Console.WriteLine("\tPassagem por Referência e Valor:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n\tpor Referência:");
            // Exemplo de passagem por referência e por valor em C#
            PassagemPorReferencia passagem = new PassagemPorReferencia();
            int numero = 5;
            passagem.passarPorReferencia(ref numero);
            Console.WriteLine($"Número após passagem por referência: {numero}");
            int numeroValor = 5;
            Console.WriteLine("\n\tPassagem por Valor:");
            passagem.passarPorValor(numeroValor);
            // A passagem por valor não altera o valor original
            // O valor de numeroValor permanece o mesmo após a chamada do método passarPorValor.
            Console.WriteLine($"Número após passagem por valor: {numeroValor}");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            #endregion
            #region Funcao
            // Exemplo de função em C#
            Console.WriteLine("\tExemplo de Função em C# COM LOOP WHILE:");
            Console.WriteLine("----------------------------");
            Funcao funcaoExemplo = new Funcao();
            // Chama o método msg2 da classe Funcao para imprimir uma mensagem em loop.
            funcaoExemplo.msg2();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            #endregion
            #region RepeticaoComWhile

            // Exemplo de repetição com while em C#
            Console.WriteLine("\tExemplo de Repetição com While:");
            Console.WriteLine("----------------------------");
            RepeticaoComWhile repeticao = new RepeticaoComWhile();
            repeticao.repetindo();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            #endregion
            #region EstruturaControle
            // Exemplo de estrutura de controle em C#
            Console.WriteLine("\tExemplo de Estrutura de Controle:");
            Console.WriteLine("----------------------------");
            EstruturaControle estrutura = new EstruturaControle();
            estrutura.estruturaControle();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            #endregion
            #region ArrayComSplit
            // Exemplo de uso de arrays e o método Split em C#          
            Console.WriteLine("\tExemplo de Array com Split:");
            Console.WriteLine("----------------------------");
            FraseComSplit fraseComSplit = new FraseComSplit();
            fraseComSplit.arrayscomSplit();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            #endregion
            #region ValoresMaximosEMinimos
            // Exemplo de valores máximos e mínimos de tipos primitivos em C#
            Console.WriteLine("\tExemplo de Valores Máximos e Mínimos:");
            Console.WriteLine("----------------------------");
            ValoresMaximosEMinimos valoresMaximosEMinimos = new ValoresMaximosEMinimos();
            valoresMaximosEMinimos.valoresMaximoseMinimos();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            #endregion
            #region ClassesEEncapsulamento
            // Exemplo de classes e encapsulamento em C#
            Console.WriteLine("\tExemplo de Classes e Encapsulamento:");
            Console.WriteLine("----------------------------");
            ClasseseEncapsulamento classeEncapsulamento = new ClasseseEncapsulamento();
            classeEncapsulamento.Numero = 10; // Define o valor do número
            classeEncapsulamento.ExibirNumero(); // Exibe o número
            Console.WriteLine("----------------------------");
            Console.WriteLine();
             // Espera o usuário pressionar uma tecla para encerrar o programa.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            #endregion
        }
    }
}