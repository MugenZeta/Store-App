using backend_api.Test.Core.DataGen.FieldGenerators;

namespace backend_api.Test.Core.DataGen.InvalidData;

public class InvalidUri : StringValueGenerator
{
    public InvalidUri(bool generateUniqueValue = true, string value = "invalid_uri") : base(generateUniqueValue, value)
    {
    }
}