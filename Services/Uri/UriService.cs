using DTOLayer;
using Microsoft.AspNetCore.WebUtilities;

namespace hrm_api.Services.Uri;

public class UriService : IUriService
{
    private readonly string _baseUri;
    public UriService (string baseUri)
    {
        _baseUri = baseUri;
    }
    public System.Uri GetPageUri(PaginationDTO pagination, string route)
    {
        var _enpointUri = new System.Uri(string.Concat(_baseUri, route));
        var modifiedUri = QueryHelpers.AddQueryString(_enpointUri.ToString(), "pageNumber", pagination.PageNumber.ToString());
        modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageSize", pagination.PageSize.ToString());
        return new System.Uri(modifiedUri);
    }
}