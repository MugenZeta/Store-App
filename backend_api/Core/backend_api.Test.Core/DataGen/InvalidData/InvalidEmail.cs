using backend_api.Test.Core.DataGen.FieldGenerators;

namespace backend_api.Test.Core.DataGen.InvalidData;

public class InvalidEmail : StringValueGenerator
{
    public InvalidEmail(bool generateUniqueValue = true, string value = "invalid_email") : base(generateUniqueValue,
        value)
    {
    }
}