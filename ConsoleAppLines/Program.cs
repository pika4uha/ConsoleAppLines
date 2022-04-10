using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordOne = "Eltsen";
            string wordTwo = "Nestle";

            int indexTwo = wordTwo.LastIndexOf("");    //нифига я догадался, как посчитать индекс последней буквы слова. Ох***ь

            string textWordOne = wordOne[0].ToString();   //привел к строке для будущего изменения регистра
            string textWordTwo = wordTwo[indexTwo].ToString();


            if (textWordOne.ToLower() == textWordTwo.ToLower())
            {
                Console.WriteLine("буквы одинаковы, да ты крутой мужик");
            }
            else
            {
                Console.WriteLine("че ты высрал");
            }


            Console.ReadKey();
        }
    }
}
