using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace FilmSearchEngine
{
    class Program
    {

        static async Task Main(string[] args)
        {

            bool display = true;
            while (display)
            {


                MainMenu.Menu();
                int menuChoice = Convert.ToInt32(Console.ReadLine());


                switch (menuChoice)
                {
                   
                    case 1:

                    

                            try
                            {
                                Console.Clear();
                                await SearchEngine.Search().ConfigureAwait(false);

                            }
                            catch (Exception)
                            {
                                Console.WriteLine("No Movie found. TRY AGAIN!");
                                Console.ReadKey();

                            }
                        break;
                            
                        



                       
                    



                          default:

                        display = false;
                        break;

                }



            }








        }
    }
}
