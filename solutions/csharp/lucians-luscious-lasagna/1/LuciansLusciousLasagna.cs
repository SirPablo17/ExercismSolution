class Lasagna
{
    public int minutos = 40;

    public int camadasMinutos = 0;
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return minutos;
    }

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int valor)
    {
        return minutos - valor;
    }
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int valor)
    {
        camadasMinutos = valor * 2;
        return camadasMinutos;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int valorUm, int valorDois)
    {
        return (valorUm * 2) + valorDois;
    }
}
