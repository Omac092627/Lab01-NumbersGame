using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSequence();

            try
            {
                Console.WriteLine("You messed up, bud");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            finally
            {
                Console.WriteLine("Mission accomoplished");
            }
        }

        static void StartSequence()
        {
            Console.WriteLine("Please pick a number greater than 0: ");
            Convert.ToInt32(Console.ReadLine());

            int[] numberEntered = new int[5];
        }
    }
}
