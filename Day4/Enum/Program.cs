using Enum;
class Program
{
    public static void Main(string[] args)
    {
        Days jumatan = Days.Jumat;        
        int valueDays = (int)Days.Senin; // Konversi Hari ke int
        Days valueDaysFromInt = (Days)1; // Konversi int ke Hari (Senin)

        TraffictLight currentLight  = TrafficLight.Red;
        switch (currentLight)
        {
            case TrafficLight.Red:
                Console.WriteLine("Stop");
                break;
            case TrafficLight.Green:
                Console.WriteLine("Go");
                break;
            case TrafficLight.Blue:
                Console.WriteLine("Prepare to stop");
                break;
            default:
                Console.WriteLine("Unknown light");
                break;
        }
    }

}