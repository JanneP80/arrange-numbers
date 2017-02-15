using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrange_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputnumber1 = 0;
            int inputnumber2 = 0;
            int inputnumber3 = 0;
            string message = string.Empty;
            Console.Write("This program arranges your typed number. \nType 3 number: ");
            bool result = int.TryParse(Console.ReadLine(), out inputnumber1);
            if (!result) // incorrect input
           {
                message = "Input is NOT a number.";
            }
            bool result2 = int.TryParse(Console.ReadLine(), out inputnumber2);
            if (!result) // incorrect input
            {
                message = "Input is NOT a number.";
            }
            bool result3 = int.TryParse(Console.ReadLine(), out inputnumber3);
            if (!result) // incorrect input
            {
                message = "Input is NOT a number.";
            }


            int[] numbers = { inputnumber1, inputnumber2, inputnumber3 };
            Console.WriteLine("Arranged into ascending order");
            Array.Sort(numbers);

            foreach (var item in numbers)
            {
                
                Console.Write(item + " ");
            }
            Console.WriteLine(message);
            Console.ReadKey();
        }
            
    }
}
