using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hack2018
{
    static class NASA
    {
        static string apiKey = ConfigurationManager.AppSettings["nasa_key"];

        public static Bitmap getImageAt(
            float longitude,
            float latitude,
            float zoomLevel,
            DateTime date)
        {
            string queryUrl = createQueryUrl(
                longitude,
                latitude,
                zoomLevel,
                date,
                apiKey);

            string imageUrl = getImageUrl(queryUrl);

            Bitmap earthImage = getImageFromUrl(imageUrl);

            return earthImage;
        }

        static string createQueryUrl(float longitude, float latitude, float zoomLevel, DateTime date, string apiKey)
        {
            string dateString = date.ToString("yyyy-MM-dd");

            string queryUrl = 
                $"https://api.nasa.gov/planetary/earth/imagery/?" + 
                $"lon={longitude}&" + 
                $"lat={latitude}&"  + 
                $"dim={zoomLevel}&" + 
                $"date={dateString}&" +
                $"cloud_score=True" +
                $"&api_key={apiKey}";
            return queryUrl;
        }

        static string getImageUrl(string queryUrl)
        {
            string imageUrl;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(queryUrl);
                JObject o = JObject.Parse(json);
                imageUrl = o.GetValue("url").ToString();
            }

            return imageUrl;
        }

        static Bitmap getImageFromUrl(string imageUrl)
        {
            Bitmap image;

            var request = WebRequest.Create(imageUrl);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                image = (Bitmap)Image.FromStream(stream);
            }

            return image;
        }
    }
}
