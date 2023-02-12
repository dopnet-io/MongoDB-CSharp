using MongoDB.Driver;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá, Bem-Vindo ao D@pNetSkillDev!");

Console.WriteLine("Conectando com MongoDb Atlas - MONGODB CSHARP NET");
var mongoUrl = "mongodb+srv://usermongodbnet:<senha>@cluster0.fqypfft.mongodb.net/?retryWrites=true&w=majority";
//
var client = new MongoClient(mongoUrl);
//
var mongoDbList = client.ListDatabases().ToList();
//
foreach (var itemMongo in mongoDbList)
{
    Console.WriteLine(itemMongo);
}
