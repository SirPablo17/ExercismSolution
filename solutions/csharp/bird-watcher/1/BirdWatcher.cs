class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new [] {0, 2, 5, 3, 7, 8, 4 };

    
    public int Today()
    {   
        int tamanho = birdsPerDay.Length;
        int ultimoValor = birdsPerDay[tamanho - 1];
        return ultimoValor;
    }

    public void IncrementTodaysCount()
    {
        int tamanho = birdsPerDay.Length;
        birdsPerDay[tamanho - 1] = Today() + 1;
    }

    public bool HasDayWithoutBirds()
    {
        bool valor = false;
        for(int i = 0; i < birdsPerDay.Length; i++){
            if(birdsPerDay[i] == 0){
                valor = true;
            }
        }
        return valor;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int contador = 0;
        for(int i = 0; i < numberOfDays; i++){
            if(birdsPerDay[i] > 0)
            contador = contador + birdsPerDay[i];
        }

        return contador;
    }

    public int BusyDays()
    {
        int diasCheios = 0;
        foreach(int birds in birdsPerDay){
            if(birds >= 5)
            diasCheios++;
        }

        return diasCheios;
    }
}
