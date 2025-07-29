class RepeticaoComWhile
 { 
     public void repetindo()
     {
         int contador = 0;
         while (contador < 5)
         {
             Console.WriteLine($"Contador: {contador}");
             contador++;
         }
         Console.WriteLine("Fim da repetição com while.");
     }
}