using System; 
using System.Globalization;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime data = DateTime.Parse(appointmentDateDescription);
        
        return data;
    }
    
    public static bool HasPassed(DateTime appointmentDate)
    {
        if(appointmentDate < DateTime.Now){
            return true;
        } else {
            return false;
        }
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if(appointmentDate.Hour >= 12 && appointmentDate.Hour < 18){
            return true;
        } else {
            return false;
        }
    }

    public static string Description(DateTime appointmentDate)
    {
        string resultado = appointmentDate.ToString("M/d/yyyy h:mm:ss tt");

        return $"You have an appointment on {resultado}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(2026, 9, 15);;
    }
}
