using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace EnumsSerialization;

public class Book
{
    public string Name { get; set; }

    [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public Genre Genre { get; set; }

    public override string ToString()
    {
        return $"The Book: {Name}, of genre: {Genre}";
    }
}