// See https://aka.ms/new-console-template for more information

using EnumsSerialization;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

var books = new List<Book>
{
    new()
    {
        Name = "Hamlet",
        Genre = Genre.Drama
    },
    new()
    {
        Name = "The Book of Longings",
        Genre = Genre.HistoricalFiction
    }
};


Console.WriteLine("Hello, World of Enum Serialization!");

Console.WriteLine();
Console.WriteLine("Serialization");

Console.WriteLine("Newtonsoft.Json:");
var newtonsoftSerialized = JsonConvert.SerializeObject(books);
Console.WriteLine(newtonsoftSerialized);

Console.WriteLine();
Console.WriteLine("System.Text.Json (with Macross.Json.Extensions):");
var textJsonSerialized = JsonSerializer.Serialize(books);
Console.WriteLine(textJsonSerialized);
Console.WriteLine();

Console.WriteLine("Deserialization");
var input =
    "[{\"Name\":\"Hamlet\",\"Genre\":\"drama\"},{\"Name\":\"The Book of Longings\",\"Genre\":\"historical_fiction\"}]";

Console.WriteLine("Newtonsoft.Json:");
var newtonsoftDeserialized = JsonConvert.DeserializeObject<List<Book>>(input);
PrintBooks(newtonsoftDeserialized);

Console.WriteLine("System.Text.Json (with Macross.Json.Extensions):");
var textJsonDeserialized = JsonSerializer.Deserialize<List<Book>>(input);
PrintBooks(textJsonDeserialized);

void PrintBooks(List<Book>? list)
{
    foreach (var book in list)
    {
        Console.WriteLine(book.ToString());
    }
    Console.WriteLine();
}