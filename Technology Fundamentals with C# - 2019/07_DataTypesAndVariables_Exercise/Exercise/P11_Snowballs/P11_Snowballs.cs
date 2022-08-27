using System;

namespace P11_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsNumber = int.Parse(Console.ReadLine());

            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            int snowballValue = 0;
            int snowballHighValue = int.MinValue;
            int snowballSnowPrint = 0;
            int snowballTimePrint = 0;
            int snowballQualityPrint = 0;

            for (int i = 0; i < snowballsNumber; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = (int)Math.Pow((snowballSnow / snowballTime), snowballQuality);

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
