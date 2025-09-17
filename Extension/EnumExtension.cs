namespace hrm_api.Extension;

public class EnumExtension
{
    public static Dictionary<string, List<string>> ConvertEnumsToDictionary(params Type[] enums)
    {
        var result = new Dictionary<string, List<string>>();

        foreach (var enumType in enums)
        {
            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"Type {enumType.Name} is not an enum.");
            }

            var enumName = enumType.Name;
            var enumValues = System.Enum.GetNames(enumType).ToList();
            result[enumName] = enumValues;
        }

        return result;
    }
}