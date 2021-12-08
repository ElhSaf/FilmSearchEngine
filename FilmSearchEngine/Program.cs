using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace FilmSearchEngine
{
    class Program
    {
        public static  HttpClient client = new HttpClient();
        static async Task  Main(string[] args)
        {



            DotNetEnv.Env.TraversePath().Load();
            string key = Environment.GetEnvironmentVariable("ApiKey");
            Console.WriteLine("enter Movie Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            string MovieId = $"https://api.themoviedb.org/3/movie/{id}?api_key={key}";

            var respons = await client.GetAsync(MovieId);
            respons.EnsureSuccessStatusCode();

            string responsContent = await respons.Content.ReadAsStringAsync();
           

            Movies test = JsonConvert.DeserializeObject<Movies>(responsContent);

            test.DisplayMovie();

            


        }
    }
}
