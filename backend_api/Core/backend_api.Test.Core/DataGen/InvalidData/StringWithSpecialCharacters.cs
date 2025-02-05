using backend_api.Test.Core.DataGen.FieldGenerators;

namespace backend_api.Test.Core.DataGen.InvalidData;

public class StringWithSpecialCharacters : StringValueGenerator
{
    public StringWithSpecialCharacters(bool generateUniqueValie = true,
        string value = "@@@@###%%%_string_with_special_characters") : base(generateUniqueValie, value)
    {
    }
}