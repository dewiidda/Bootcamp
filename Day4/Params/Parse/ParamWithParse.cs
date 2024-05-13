namespace Params.Parse;

    public class StringCalculator
    {
        // Menggunakan params untuk menerima array string dan parse setiap elemen
        public int Add(params string[] numberStrings)
        {
            int sum = 0;
            foreach (string numberString in numberStrings)
            {
                int number = int.Parse(numberString); // Parsing string menjadi integer
                sum += number;
            }
            return sum;
        }
    }

