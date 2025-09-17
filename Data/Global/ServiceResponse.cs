using System.Text.Json;
namespace ServiceLayer;

public class ServiceResponse<T>
{
    public int Code { get; set; } = 200;
    public string Status
    {
        get
        {
            string result = Code switch
            {
                200 => "SUCCESS",
                404 => "NOT_FOUND",
                300 => "INVALID_PARAMETER",
                401 => "INVALID_TOKEN",
                406 => "NOT_ACCEPTABLE",
                _ => "FAILURE"
            };
            return result;
        }
        set
        {
            value = Status;
        }
    }
    public string Message { get; set; } = "The request was successful";
    public T Data { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this,
            new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
    }
}