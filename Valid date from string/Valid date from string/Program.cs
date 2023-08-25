using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_date_from_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";
            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                if (word.Length == 8 && int.TryParse(word, out _))
                {
                    Console.WriteLine(word);
                    break;
                }
            }

        }
    }
}
