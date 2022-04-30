using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ExemploMongoDB
{
    class ManipulandoClasses
    {
        static void Main(string[] args)
        {
            Task t = MainAsync(args);
            Console.WriteLine("Pressione ENTER");
            Console.ReadLine();
        }

        static async Task MainAsync(string[] args)
        {
            Livro livro = new Livro();
            livro.Titulo = "Sob a redoma";
            livro.Autor = "Stepahn King";
            livro.Ano = 2012;
            livro.Paginas = 679;

            List<string> listaAssuntos = new List<string>();
            listaAssuntos.Add("Ficção Científica");
            listaAssuntos.Add("Terror");
            listaAssuntos.Add("Ação");

            livro.Assunto = listaAssuntos;


            //Acesso ao servidor do MongoDB
            string stringConexao = "mongodb://localhost:27017";
            IMongoClient client = new MongoClient(stringConexao);

            //Acesso ao banco de dados
            IMongoDatabase bancoDados = client.GetDatabase("Biblioteca");

            //Acesso a coleção
            IMongoCollection<Livro> collection = bancoDados.GetCollection<Livro>("Livros");

            //Incluir documento
            await collection.InsertOneAsync(livro);

            Console.WriteLine("Documento incluido");
        }
    }
}
