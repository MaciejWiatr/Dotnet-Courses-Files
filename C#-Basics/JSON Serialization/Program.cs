using Newtonsoft.Json;
using System;
using System.IO;

namespace JSON_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerSerialized = File.ReadAllText(@"./data/playerSerialized.json");
            Player player = JsonConvert.DeserializeObject<Player>(playerSerialized);

            Console.WriteLine(player.Name);

            //var player = new Player()
            //{
            //    Name = "Mario",
            //    Level = 1,
            //    HealthPoints = 100,
            //    Statistics = new List<Statistic>()
            //    {
            //        new Statistic()
            //        {
            //            Name = "Strength",
            //            Points = 10
            //        },
            //        new Statistic()
            //        {
            //            Name = "Intelligence",
            //            Points = 20
            //        }
            //    }
            //};
            //player.Level++;
            //string playerSerialized = JsonConvert.SerializeObject(player);
            //File.WriteAllText(@"./data/playerSerialized.json", playerSerialized);
        }
    }
}
