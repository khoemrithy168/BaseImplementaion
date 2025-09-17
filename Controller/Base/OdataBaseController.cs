using hrm_api.Dtos;
using hrm_api.Model.Base;
using hrm_api.Services;
using hrm_api.Utils;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ServiceLayer;

namespace hrm_api.Controller.Base;

public class OdataBaseController<T> : ODataController where T : BaseEntity   
{
    protected OdataBaseRepository<T> _service;
        public OdataBaseController(OdataBaseRepository<T> service)
        {
            _service = service;
        }
        internal IdentityDTO GetTokenInfo()
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            return JwtUtils.ValidateToken(token);
        }
        // protected OkObjectResult OkWithPagination([ActionResultObjectValue] object value)
        // {
        //     return base.Ok(value);
        // }
        // public override OkObjectResult Ok([ActionResultObjectValue] object value)
        // {
        //     var response = new ServiceResponse<object>
        //     {
        //         Data = value
        //     };
        //     return base.Ok(response);
        // }
        //
        // protected FileStreamResult FileAsExcel(Stream fileStream, string fileDownloadName)
        // {
        //     fileDownloadName += $"_{DateTime.Now:yyyyMMddhhmmss}.xlsx";
        //     return base.File(fileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileDownloadName);
        // }
        
        
        
        [EnableQuery]
        public virtual IQueryable<T> Get()
        {
            return _service.GetQueryable();
        }
        //
         
        public async Task<IActionResult> Post([FromBody] T request)
        {
            return Created(await _service.SaveAsync(request,GetTokenInfo()));
        }
        //
        public async Task<IActionResult> Patch([FromODataUri]int key, [FromBody] Delta<T> request)
        {
            var x = await _service.UpdateAsync(key, request,GetTokenInfo());
            return Updated(x);
        }
        
        public async Task<IActionResult> Delete([FromODataUri]int key)
        {
            var x =  await _service.DeleteAsync(key);
            return Updated(x);
        }
        
        public OkObjectResult RestOk([ActionResultObjectValue] object value)
        {
            var response = new ServiceResponse<object>
            {
                Data = value
            };
            return base.Ok(response);
        }
}