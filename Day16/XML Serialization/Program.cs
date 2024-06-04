using System.Xml.Serialization;

public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Human() { }
    public Human(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

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

        // XmlSerializer xmlSerializer = new(typeof(List<Human>));
        // using (StreamWriter sw = new("file.xml"))
        // {
        //     xmlSerializer.Serialize(sw, bootcamp);
        // }

        XmlSerializer xmlSerializer = new(typeof(List<Human>));
        List<Human> result;
        using (StreamReader sr = new("file.xml"))
        {
            result = (List<Human>)xmlSerializer.Deserialize(sr);
        }
        foreach (var human in result)
        {
            Console.WriteLine($"Name: {human.Name}");
            Console.WriteLine($"Age: {human.Age}");
        }
    }
}