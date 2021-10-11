using System.Runtime.Serialization;

namespace EnumsSerialization;

public enum Genre
{
    [EnumMember(Value = "none")] None = 0,
    [EnumMember(Value = "fantasy")] Fantasy = 1,
    [EnumMember(Value = "horror")] Horror = 2,
    [EnumMember(Value = "drama")] Drama = 3,

    [EnumMember(Value = "historical_fiction")]
    HistoricalFiction = 4
}