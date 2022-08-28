using System;

namespace P11_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsNumber = int.Parse(Console.ReadLine());

            int snowballHighValue = 0;
            int snowballSnowPrint = 0;
            int snowballTimePrint = 0;
            int snowballQualityPrint = 0;

            for (int i = 0; i < snowballsNumber; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowballValue = (int)Math.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue>snowballHighValue)
                {
                    snowballHighValue = snowballValue;
                    snowballTimePrint = snowballTime;
                    snowballSnowPrint = snowballSnow;
                    snowballQualityPrint = snowballQuality;
                }
            }

            Console.WriteLine($"{snowballSnowPrint} : {snowballTimePrint} = {snowballHighValue} ({snowballQualityPrint})");
        }
    }
}
