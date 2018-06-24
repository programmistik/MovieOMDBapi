using System;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Net;
namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ApiKey = "9f2df9da";
            string MovieName;
            Console.WriteLine("ПОИСК ФИЛЬМОВ");
            Console.Write("Введите название фильма (на англ. языке): ");
            MovieName = Console.ReadLine();

            string url = "http://www.omdbapi.com/?t=" + MovieName.Trim()+"&apikey="+ApiKey;
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                var oJS = new JavaScriptSerializer();
                var obj = new Movie();
                obj = oJS.Deserialize<Movie>(json);

                if (obj.Response == "True")
                    obj.Print();
                else
                    Console.Write("Фильм не найден :(");

            }

            Console.ReadLine();
        }
    }
}
