using ServiceStack.Redis;
using System;

namespace Redis
{
    class Program
    {
        static void Main()
        {
            var host = "127.0.0.1:6379";
            
            var client1 = new Client() { Document = "Z1239", Name = "Kramaric" };
            var client2 = new Client() { Document = "Z1560", Name = "Sabitzer" };

            using (var redisClient = new RedisClient(host))
            {
                //Set first value  
                redisClient.Set<Client>(client1.Id.ToString(), client1);

                //Set second value
                redisClient.Set<Client>(client2.Id.ToString(), client2);

                //Get first value
                var cli1 = redisClient.Get<Client>(client1.Id.ToString());
                Console.WriteLine($"Value1: {cli1.Id} - {cli1.Name} - {cli1.Document}");

                //Get second value
                var cli2 = redisClient.Get<Client>(client2.Id.ToString());
                Console.WriteLine($"Value2: {cli2.Id} - {cli2.Name} - {cli2.Document}");
            }

            //Waitng for key pressed
            Console.ReadLine();
        }
    }
}
