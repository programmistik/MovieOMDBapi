using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public string Metascore { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }   
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string Response { get; set; }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Название: { Title }");
            Console.WriteLine($"Год:      { Year }");
            Console.WriteLine($"Жанр:     { Genre }");
            Console.WriteLine($"Режиссер: { Director }");
            Console.WriteLine($"В ролях:  { Actors }");
            Console.WriteLine($"Сюжет:    { Plot }");
            Console.WriteLine($"Награды:  { Awards }");

            if (Uri.IsWellFormedUriString(Poster, UriKind.Absolute))
                System.Diagnostics.Process.Start(Poster);
        }
    }
}
