class RemoteControlCar
{  

    private int meters = 0;
    private int battery = 100;
    
    public static RemoteControlCar Buy()
    {
        var car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay() => $"Driven {meters} meters"; 
    

    public string BatteryDisplay()
    {
        if(battery > 0){
        return $"Battery at {battery}%";
        } else {
            return "Battery empty";
        }
    }

    public void Drive()
    {
        if(battery > 0)
        meters = meters + 20;
        battery = battery - 1;
    }
}
