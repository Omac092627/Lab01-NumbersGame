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

            int[] numberEntered = new int[6];


            Populate(numberEntered);
        }

 

        static int[] Populate(int[] int1)
            {
            int[] numberEntered = new int[6];
            int count = 0;   

         for(int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Please enter a random number between {count} and 6: ");
                numberEntered[i] = Convert.ToInt32(Console.ReadLine());
                count++;
            }

         for(int i = 0; i < 6; i++)
            {
                Console.WriteLine($"You entered {numberEntered[i]}");
            }

            Console.WriteLine("You array size is 6");
            Console.ReadLine();

            return int1;


        }


        /*static int GetSum(int int2)
        {

        }*/
    }
}
