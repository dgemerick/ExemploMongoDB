using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MainSync(args);
            Console.WriteLine("Pressione ENTER");
            Console.ReadLine();
        }

        static void MainSync(string[] args)
        {
            Console.WriteLine("Esperando 10 segundos ...");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Esperei 10 segundos ...");
        }
    }
}
