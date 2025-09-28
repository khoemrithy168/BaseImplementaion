namespace hrm_api.Dtos;

public class ResponseDTO
{
    public ResponseDTO()
    {

    }
    public ResponseDTO(object data)
    {
        Data = data;
    }
    public string Code { get; set; } = "200";
    public string Status { get; set; } = "SUCCESS";
    public string Message { get; set; } = "Request Successfully";
    public object Data { get; set; }
}