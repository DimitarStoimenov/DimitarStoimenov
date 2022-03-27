using System;


namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            

            for (int i = 0; i < num; i++)
            {
                Random random = new Random();

                {
                    int currP = random.Next(0, Phrases.Length);
                    
                
                    int currE = random.Next(0, Events.Length);
                    
                
                    int currA = random.Next(0, Authors.Length);
                    
                    int currC = random.Next(0, Cities.Length);
                    

                    Console.WriteLine($"{Phrases[currP]}. {Events[currE]}. {Authors[currA]} – {Cities[currC]}.");
                }
                
                    
                
                
            }


        }

        static string[] Phrases = new string[]
        { "Excellent product.", "Such a great product.",
           "I always use that product.",
           "Best product of its category.", "Exceptional product.", 
           "I can’t live without this product."

          
                
        };
        static string[] Events = new string[]
        { "Now I feel good.", "I have succeeded with this product.",
          "Makes miracles. I am happy of the results!",
          "I cannot believe but now I feel awesome.",
          "Try it yourself, I am very satisfied.", "I feel great!"
        };
        static string[] Authors = new string[]
       {  "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
       };
        static string[] Cities = new string[]
        {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };

    }
}
