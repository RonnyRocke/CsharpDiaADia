class PassagemPorReferencia
{
    public void passarPorReferencia( ref int numero)
    {
        numero += 10;
    }
    public void passarPorValor(int numero)
    {
        numero += 10; 
        // não afeta o valor original
    }
} 