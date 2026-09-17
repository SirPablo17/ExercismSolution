class RemoteControlCar
{  

    private int meters = 0;
    private int battery = 100;
    
    public static RemoteControlCar Buy()
    {
        var car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {meters} meters"; 
    }

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
        int valueDrive = 20;
        int valueBattery = 1;

        if(battery > 0)
        meters = meters + valueDrive;
        battery = battery - valueBattery;
    }
}
