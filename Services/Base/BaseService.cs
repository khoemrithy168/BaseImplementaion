using AutoMapper;
using hrm_api.Data;
using hrm_api.Services.Uri;

namespace hrm_api.Services.Base;

public class BaseService
{
    protected AppDbContext _context;
    protected IMapper _mapper;
    protected IHttpContextAccessor _accessor;
    protected IUriService _uriService;
    public BaseService(AppDbContext context, IMapper mapper, IHttpContextAccessor accessor, IUriService uriService)
    {
        _context = context;
        _mapper = mapper;
        _accessor = accessor;
        _uriService = uriService;
    }
}