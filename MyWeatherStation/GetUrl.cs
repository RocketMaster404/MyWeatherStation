using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyWeatherStation
{
    internal class GetUrl
    {
        public string SmhiUrl(double longitude, double latitude)
        {
            string longitudeString = longitude.ToString();
            string latitudeString = latitude.ToString();

            if (longitudeString.Contains(","))
            {
                longitudeString = longitudeString.Replace(",", ".");
            }

            if (latitudeString.Contains(","))
            {
                latitudeString = latitudeString.Replace(",", ".");

            }

            string url = $"https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/{longitudeString}/lat/{latitudeString}/data.json";
            return url;
        }

        public string WeatherFromStream(double longitude,double latitude)
        {
            string url = SmhiUrl(longitude, latitude);

            var webClient = new WebClient();

            using (Stream file = webClient.OpenRead(url))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string smhiJson = reader.ReadToEnd();
                    return smhiJson;
                }
            }
        }
    }
}
