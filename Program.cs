using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc56_4_MoshCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit
            //    The list of numbers may include duplicates.
            //    Display the unique numbers that the user has entered.

            var numbers = new List<int>() { };
            Console.WriteLine("Type a number (or type 'Quit' to finish'): ");

            while (true)
            {
                
                var input = Console.ReadLine();
                if (input.ToLower() == "Quit")
                {
                    var uniqueNumbers = GetUniqueNumbersList(numbers);
                    uniqueNumbers.Sort();
                    uniqueNumbers.ForEach(Console.WriteLine);
                }
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                }
                                    
            }

        }
        private static List<int> GetUniqueNumbersList(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(number => number)
                .Where(number => number.Count() == 1)
                .SelectMany(number => number)
                .ToList();
        }
    }
}
