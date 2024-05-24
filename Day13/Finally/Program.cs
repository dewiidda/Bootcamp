// finally
class Program{
    static void Main(){
        try
        {
            for(int i=0; i<100000; i++)
            {
                StreamWriter stream = new("../file.txt");
            }
        }
        catch(FormatException e)
        {
            Console.WriteLine("Format exception");
        }
        finally
        { // this will be run either there is exception or no
            Console.WriteLine("Program closed");
        }
    }
}