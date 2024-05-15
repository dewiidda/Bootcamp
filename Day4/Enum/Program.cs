using Enum;
class Program
{
    public static void Main(string[] args)
    {
        TraffictLight currentLight  = TraffictLight.Red;
        switch (currentLight)
        {
            case TraffictLight.Red:
                Console.WriteLine("Stop");
                break;
            case TraffictLight.Green:
                Console.WriteLine("Go");
                break;
            case TraffictLight.Yellow:
                Console.WriteLine("Prepare to stop");
                break;
            default:
                Console.WriteLine("Unknown light");
                break;
        }
    }

}