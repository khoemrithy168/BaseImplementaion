using DTOLayer;

namespace hrm_api.Services.Uri;

public interface IUriService
{
    public System.Uri GetPageUri(PaginationDTO filter, string route);
}