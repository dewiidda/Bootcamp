using System.Collections;
using System.Collections.Generic;

class Program
{
    void Main()
    {
        //Enumerator
        List<string> bp = new (){"Lisa",null,"Jennie","Jisoo","Rose"};
        IEnumerator<string> enumerator = bp.GetEnumerator();
        while(enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }

        foreach (int number in GetNumbers())
        {
            Console.WriteLine(number);
        }
    }

    //Iterator
    public static IEnumerable<int> GetNumbers()
    {
        for(int i = 1; i < 100; i++)
        {
            yield return i;
        }
    }

}


