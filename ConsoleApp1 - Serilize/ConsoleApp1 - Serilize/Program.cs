using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ConsoleApp1___Serilize
{
    public class Cereal
    {
        public string Name { get; set; }    
        public string Slogan { get; set; }  
        public Boolean MrClark_approved { get; set; } 
        public int Calories { get; set; }
        public decimal Price { get; set; }  
        public string Picture { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cereal LuckyCharms = new Cereal();
            LuckyCharms.Name = "Lucky Charms";
            LuckyCharms.Slogan = "They're magically delicious.";
            LuckyCharms.MrClark_approved = true;
            LuckyCharms.Calories = 137;
            LuckyCharms.Price = 3.99m;

            Cereal CrispyRice = new Cereal();
            CrispyRice.Name = "Crispy Rice";
            CrispyRice.Slogan = "They're magically delicious.";
            CrispyRice.MrClark_approved = true;
            CrispyRice.Calories = 137;
            CrispyRice.Price = 3.99m;



            Cereal TraderJoes_CornFlakes = new Cereal();
            TraderJoes_CornFlakes.Name = "Trader Joe's Corn Flakes";




            string jsonString = JsonSerializer.Serialize(TraderJoes_CornFlakes);
            Console.WriteLine(jsonString);

            TraderJoes_CornFlakes = JsonSerializer.Deserialize<Cereal>(jsonString);   
            Console.ReadKey();


            
        }
    }
}
