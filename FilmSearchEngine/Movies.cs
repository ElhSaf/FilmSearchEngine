using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSearchEngine
{
    class Movies
    {

         
        

            public string homepage { get; set; }


            public string original_language { get; set; }

            public string overview { get; set; }

            public string poster_path { get; set; }

            public string release_date { get; set; }

            public int runtime { get; set; }



            public string title { get; set; }

            public float vote_average { get; set; }


            public void DisplayMovie()
            {
                Console.WriteLine(" Title: {0}", title);
                Console.WriteLine(" Runt Time: {0}", runtime);
                Console.WriteLine(" Release date: {0}", release_date);
                Console.WriteLine(" Rating: {0}", vote_average);
                Console.WriteLine(" Overview: {0}", overview);
            Console.WriteLine($"Poser Link: https://image.tmdb.org/t/p/w500{poster_path}");

            }








        








    }
}
