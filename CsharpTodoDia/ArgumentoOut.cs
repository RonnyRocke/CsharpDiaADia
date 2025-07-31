class ArgumentoOut
{
    public double divide(int dividendo, int divisor, out double resto)
    {
        if (divisor == 0 || dividendo == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }
        else if (divisor < 0 || dividendo < 0)
        {
            throw new ArgumentException("Divisão com números negativos não é permitida.");
        }
        double quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}