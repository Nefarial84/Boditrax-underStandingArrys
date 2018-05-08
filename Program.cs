using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace underStandingArrys
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = new int[5];

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;
            //Console.WriteLine(numbers[1].ToString());

            int [] numbers = { 8, 15, 16, 23 };

            string [] names = { "Bob", "Andrew", "Jen", "Hobo" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i].ToString());
            }

            string myText = "Now is the time for all good men to fight for thir country!";
            char[] charArray = myText.ToCharArray();
            Array.Reverse(charArray);
            foreach (char mychar in charArray)
            {
                Console.Write(mychar);
            }



            Console.ReadLine();

        }
    }
}
