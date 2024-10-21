using System.Data;

namespace ConsoleTolyID;

public static class ValidarCamposService
{
    public static double ValidarDouble()
    {
        try
        {
            System.Console.WriteLine("Digite um Numero:");
            double num = Convert.ToInt32(System.Console.ReadLine());
            return num;
        }
        catch
        {
            return ValidarDouble();
        }
    }
    public static int ValidarInt()
    {
        try
        {
            System.Console.WriteLine("Digite um Numero:");
            int num = Convert.ToInt32(System.Console.ReadLine());
            return num;
        }
        catch
        {
            return ValidarInt();
        }
    }
    public static bool ValidarBool()
    {
        System.Console.WriteLine("1- Verdadeiro\n2- Falso\n");
        switch(System.Console.ReadLine()){
            case "1":
            return true;
            case "2":
            return false;
            default:
            return ValidarBool();
        }
    }
    public static DateTime ValidarData()
    {
        //para testes
        return DateTime.Now;
    }

    public static TimeSpan ValidarTimeSpan(){
        return DateTime.Now.TimeOfDay;
    }
}
