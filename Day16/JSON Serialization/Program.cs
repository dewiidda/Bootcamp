using System.Text.Json;

class Program
{
    static void Main()
    {
        // Human yusa = new Human("Yusa", 26);
        // Human ega = new Human("Ega", 22);
        // Human rizqy = new Human("Rizqy", 24);
        // Human fadl = new Human("Fadl", 23);
        // Human dewi = new Human("Dewi", 25);
        // Human wulan = new Human("Wulan", 29);
        // Human bela = new Human("Bela", 24);
        // Human jun = new Human("Jun", 23);

        // List<Human> bootcamp = new List<Human>()
        // {
        // yusa, ega, rizqy, fadl, dewi, wulan, bela, jun
        // };
        // string json = JsonSerializer.Serialize(bootcamp);
        // using (StreamWriter sw = new("file.json"))
        // {
        //     sw.WriteLine(json);
        // }

        string result;
        using (StreamReader sr = new("file.json"))
        {
            result = sr.ReadToEnd();
        }

        List<Human> bootcamp = JsonSerializer.Deserialize<List<Human>>(result);
        foreach (var human in bootcamp)
        {
            Console.WriteLine($"Name: {human.Name}");
            Console.WriteLine($"Age: {human.Age}");
        }

    }

}