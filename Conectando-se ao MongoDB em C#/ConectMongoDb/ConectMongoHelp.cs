var mongoUrl = "mongodb+srv://usermongodbnet:o5mAuvPrT5vTB3Mh@cluster0.fqypfft.mongodb.net/?retryWrites=true&w=majority";

var client = new MongoClient(mongoUrl);

var mongoDbList = client.ListDatabases().ToList();

foreach (var itemMongo in mongoDbList)
{
    Console.WriteLine(itemMongo);
}