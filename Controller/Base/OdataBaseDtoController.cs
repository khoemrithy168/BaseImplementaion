

using AutoMapper;
using hrm_api.Dtos;
using hrm_api.Model.Base;
using hrm_api.Services;
using hrm_api.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace PropertyManagement.Controllers.Base;

public class OdataBaseDtoController<T, dto> : ODataController
    where T : BaseEntity
    where dto : class
{
    protected OdataBaseRepository<T> _service;
    protected readonly IMapper _mapper;

    public OdataBaseDtoController(OdataBaseRepository<T> service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    internal IdentityDTO GetTokenInfo()
    {
        var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        return JwtUtils.ValidateToken(token);
    }
    public virtual IQueryable<dto> Get()
    {
        var entities = _service.GetQueryable();
        return _mapper.Map<IQueryable<dto>>(entities);
    }
    
    public async Task<IActionResult> Post([FromBody] dto request)
    {
        var entity = _mapper.Map<T>(request);
        return Created(await _service.SaveAsync(entity,GetTokenInfo()));
    }

    public async Task<IActionResult> Path([FromODataUri] int key, [FromBody] Delta<dto> request)
    {
        var result = await _service.UpdateDtoAsync(key, request, GetTokenInfo());
        var resultDto = _mapper.Map<dto>(result);
        return Updated(resultDto);
    }

}