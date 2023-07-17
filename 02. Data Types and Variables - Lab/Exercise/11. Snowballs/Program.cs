using System.Diagnostics;
using System.Numerics;

int numOfSnowballs = int.Parse(Console.ReadLine());
BigInteger highestValue = 0;
int currentSnow = 0;
int currentTime = 0;
int currentQuality = 0;
if (numOfSnowballs > 0)
{



    for (int i = 0; i < numOfSnowballs; i++)
    {
        int snowballSnow = int.Parse(Console.ReadLine());
        int snowballTime = int.Parse(Console.ReadLine());
        int snowballQuality = int.Parse(Console.ReadLine());

        BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

        if (snowballValue > highestValue)
        {
            highestValue = snowballValue;
            currentSnow = snowballSnow;
            currentTime = snowballTime;
            currentQuality = snowballQuality;
        }

    }
    Console.WriteLine($"{currentSnow} : {currentTime} = {highestValue} ({currentQuality})");
}



