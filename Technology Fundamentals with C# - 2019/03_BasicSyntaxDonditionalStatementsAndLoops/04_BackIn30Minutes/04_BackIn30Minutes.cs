using System;

namespace _04_BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int backIn30Minutes = minutes + 30;

            if (backIn30Minutes < 60)
            {
                Console.WriteLine($"{hours}:{backIn30Minutes:D2}");
            }
            else
            {
                if (hours < 23)
                {
                    hours++;
                    backIn30Minutes -= 60;
                    Console.WriteLine($"{hours}:{backIn30Minutes:D2}");
                }
                else
                {
                    hours = 0;
                    backIn30Minutes -= 60;
                    Console.WriteLine($"{hours}:{backIn30Minutes:D2}");
                }
            }
        }
    }
}