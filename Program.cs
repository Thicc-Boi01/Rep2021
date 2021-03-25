using System;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times do you want to repeat this?");
            string repeatnum  = Console.ReadLine();


            int number = int.Parse(repeatnum);

            int counter = 0;
            
            while (counter < number) {
                Console.WriteLine("please enter a name:");
                string input = Console.ReadLine();
                Console.WriteLine(input);
                counter++;
            }
            Console.WriteLine("Goodbye :3");
            
        }
    }
}
