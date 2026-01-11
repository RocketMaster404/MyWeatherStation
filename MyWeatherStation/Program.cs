using System.Net;

namespace MyWeatherStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetUrl smhi = new GetUrl();

            double longitude = 12.250;
            double latitude = 57.105;

            string info = smhi.WeatherFromStream(longitude, latitude);
            Console.WriteLine(info);

        }
    }
}
