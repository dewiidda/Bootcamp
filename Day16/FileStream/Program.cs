using System.Text;

class Program
{
    static void Main()
    {
        using (FileStream fs = new FileStream("test1.txt", FileMode.Create, FileAccess.Write, FileShare.None))
        {
            string text = "Selamat pagi, saya agak lapar";
            byte[] myBytes = new byte[text.Length]; //buffer

            myBytes = Encoding.UTF8.GetBytes(text);
            fs.Write(myBytes, 0, myBytes.Length);
            Console.ReadLine();
        }

        Console.ReadLine();
        Console.WriteLine();

        using (FileStream fs1 = File.OpenRead("test1.txt"))
        {
            byte[] b = new byte[1024];
            UTF8Encoding tmp = new UTF8Encoding(true);
            int readLen;
            while ((readLen = fs1.Read(b, 1, b.Length)) > 0)
            {
                Console.WriteLine(tmp.GetString(b, 0, readLen));
            }
        }

        using (var sr = new StreamReader("test1.txt"))
        {
            Console.WriteLine(sr.ReadToEnd());
        }

    }
}