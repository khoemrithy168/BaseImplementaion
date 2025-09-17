using hrm_api.Dtos;
using hrm_api.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using ServiceLayer;

namespace hrm_api.Controller.Base;
    
    public class BaseController<T> : ControllerBase where T : class
    {
        protected T _service;
        
        public BaseController(T service)
        {
            _service = service;
        }
        internal IdentityDTO GetTokenInfo()
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            return JwtUtils.ValidateToken(token);
        }
        protected OkObjectResult OkWithPagination([ActionResultObjectValue] object value)
        {
            return base.Ok(value);
        }
        public override OkObjectResult Ok([ActionResultObjectValue] object value)
        {
            var response = new ServiceResponse<object>
            {
                Data = value
            };
            return base.Ok(response);
        }

        protected FileStreamResult FileAsExcel(Stream fileStream, string fileDownloadName)
        {
            fileDownloadName += $"_{DateTime.Now:yyyyMMddhhmmss}.xlsx";
            return base.File(fileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileDownloadName);
        }
    }