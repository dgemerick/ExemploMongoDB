using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploMongoDB
{
    class ProgramAssincrono
    {
        static void Main(string[] args)
        {
            Task t = MainAsync(args);
            Console.WriteLine("Pressione ENTER");
            Console.ReadLine();
        }

        static async Task MainAsync(string[] args)
        {
            Console.WriteLine("Esperando 10 segundos ...");
            await Task.Delay(10000);
            Console.WriteLine("Esperei 10 segundos ...");
        }
    }
}
