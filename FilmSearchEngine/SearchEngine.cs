using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace FilmSearchEngine
{
    class SearchEngine
    {
        public static HttpClient client = new HttpClient();
        public static async Task Search()
        {


            
                DotNetEnv.Env.TraversePath().Load();
                string key = Environment.GetEnvironmentVariable("ApiKey");
                Console.WriteLine("enter Movie Id:");
                int id = Convert.ToInt32(Console.ReadLine());

                string MovieId = $"https://api.themoviedb.org/3/movie/{id}?api_key={key}";

                var respons = await client.GetAsync(MovieId);
                respons.EnsureSuccessStatusCode();

                string responsContent = await respons.Content.ReadAsStringAsync();
                respons.EnsureSuccessStatusCode();

                Movies test = JsonConvert.DeserializeObject<Movies>(responsContent);

                test.DisplayMovie();
            
            
            



        }
    }
}

