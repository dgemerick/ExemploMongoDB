using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ExemploMongoDB
{
    class AcessandoMongoDB
    {
        static void Main(string[] args)
        {
            Task t = MainAsync(args);
            Console.WriteLine("Pressione ENTER");
            Console.ReadLine();
        }

        static async Task MainAsync(string[] args)
        {
            var doc = new BsonDocument
            {
                {"Titulo", "Guerra dos Trons" }
            };
            doc.Add("Autor", "George R R Martin");
            doc.Add("Ano", 1999);
            doc.Add("Páginas", 856);

            var assuntoArray = new BsonArray();
            assuntoArray.Add("Fantasia");
            assuntoArray.Add("Ação");

            doc.Add("Assunto", assuntoArray);
            Console.WriteLine(doc);

            //Acesso ao servidor do MongoDB
            string stringConexao = "mongodb://localhost:27017";
            IMongoClient client = new MongoClient(stringConexao);

            //Acesso ao banco de dados
            IMongoDatabase bancoDados = client.GetDatabase("Biblioteca");

            //Acesso a coleção
            IMongoCollection<BsonDocument> collection = bancoDados.GetCollection<BsonDocument>("Livros");

            //Incluir documento
            await collection.InsertOneAsync(doc);

            Console.WriteLine("Documento incluido");
        }
    }
}
