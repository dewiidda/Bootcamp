class Program
{
    enum Days
    {
    Senin,
    Selasa,
    Rabu,
    Kamis,
    Jumat,
    Sabtu,
    Minggu
    }

    Days jumatan = Days.Jumat;
    
    switch (hariLibur)
    {
    case Hari.Sabtu:
    case Hari.Minggu:
    Console.WriteLine("Akhir pekan!");
    break;
    default:
    Console.WriteLine("Hari kerja.");
    break;
    }

    
    int valueDays = (int)Hari.Senin; // Konversi Hari ke int
    Days valueDaysFromInt = (Days)1; // Konversi int ke Hari (Senin)

    public static void Main(string[] args)
    {
        
    }

}