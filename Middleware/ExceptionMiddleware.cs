using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using DataLayer;
using DTOLayer;
using hrm_api.Data;
using hrm_api.Dtos;
using hrm_api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
// using ModelLayer;
using Serilog;
// using SystemPlus;

namespace MiddlewareLayer
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private static LoggedRequest loggedRequest;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var stopwatch = Stopwatch.StartNew();
            httpContext.Request.EnableBuffering();

            // Extract controller and action names
            var actionDescriptor = httpContext.GetEndpoint()?.Metadata.GetMetadata<ControllerActionDescriptor>();
            string controllerName = actionDescriptor?.ControllerName;
            string actionName = actionDescriptor?.ActionName;

            // Extract user ID if available
            string userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            string userName = httpContext.User.FindFirst(ClaimTypes.Name)?.Value;

            loggedRequest = new LoggedRequest
            {
                UserID = userId,
                Method = httpContext.Request.Method,
                Controller = controllerName,
                ActionName = actionName,
                Path = httpContext.Request.Path,
                QueryString = httpContext.Request.QueryString.ToString(),
            };
            if (userName != null)
                loggedRequest.CreatedBy = userName;

            if (httpContext.Request.Body != null && (httpContext.Request.ContentType != "multipart/form-data" || httpContext.Request.ContentType != "application/octet-stream"))
            {
                // Read request body
                var requestBodyStream = new StreamReader(httpContext.Request.Body);
                var requestBodyText = await requestBodyStream.ReadToEndAsync();

                loggedRequest.RequestBody = requestBodyText;
                // Log request body
                Log.Information($"Request Body: {requestBodyText}");

                // Reset the request body stream position
                httpContext.Request.Body.Position = 0;
            }
            try
            {
                await _next(httpContext);
                loggedRequest.Status = "SUCCESS";
                if (httpContext.Response.StatusCode == 400)
                {
                    loggedRequest.Status = "ERROR";
                    loggedRequest.Description = "System validation";
                    loggedRequest.Remark = "Invalid Parameter";
                }
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                loggedRequest.Status = "ERROR";
                await HandleUnauthorizedExceptionAsync(httpContext, unauthorizedAccessException);
            }
            catch (CustomException ex)
            {
                loggedRequest.Status = "ERROR";
                loggedRequest.Description = "System validation";
                loggedRequest.Remark = ex.Message;

                if (ex.InnerException != null)
                    loggedRequest.Remark += " | " + ex.InnerException.Message;

                await HandleCustomExceptionAsync(httpContext, ex);
            }
            catch (Exception ex)
            {
                loggedRequest.Status = "ERROR";
                loggedRequest.Description = "Exception found";
                loggedRequest.Remark = ex.Message;

                if (ex.InnerException != null)
                    loggedRequest.Remark += " | " + ex.InnerException.Message;

                await HandleExceptionAsync(httpContext, ex);
            }
            finally
            {
                stopwatch.Stop();
                var duration = stopwatch.Elapsed.TotalMilliseconds;
                Log.Information($"URL : {httpContext.Request.Path}{httpContext.Request.QueryString}");
                Log.Information($"Duration : {duration}");

                loggedRequest.Duration = duration;
                if (loggedRequest.Controller != "Auth")
                {
                    try
                    {
                        var _context = new AppDbContext();
                        loggedRequest.Id = 0;
                        _context.LoggedRequests.Add(loggedRequest);
                        await _context.SaveChangesAsync().ConfigureAwait(false);
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to save logs: {ex.Message} {ex.InnerException?.Message}", ex);
                    }
                }
            }
        }
        private static async Task HandleUnauthorizedExceptionAsync(HttpContext context, UnauthorizedAccessException exception)
        {
            var statusCode = (int)HttpStatusCode.Unauthorized;
            context.Response.StatusCode = (int)statusCode;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(new ResponseDTO
            {
                Code = statusCode.ToString(),
                Status = "Unauthorized".ToUpper(),
                Message = exception.Message
            });

        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var statusCode = (int)HttpStatusCode.NotAcceptable;
            var msg = exception.Message;
            if (exception.InnerException?.Message != null)
                msg += " | " + exception.InnerException?.Message;

            Log.Error($"Exception: {msg}", exception);

            context.Response.StatusCode = (int)statusCode;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(new ResponseDTO
            {
                Code = statusCode.ToString(),
                Status = "Not_Acceptable".ToUpper(),
                Message = "Something's wrong | Kindly reach out to our IT support for assistance"
            });
        }
        private static async Task HandleCustomExceptionAsync(HttpContext context, CustomException exception)
        {
            var statusCode = (int)HttpStatusCode.NotAcceptable;
            context.Response.StatusCode = (int)statusCode;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(new ResponseDTO
            {
                Code = statusCode.ToString(),
                Status = "NOT_ACCEPTABLE",
                Message = exception.Message // Use the built-in Message property
            });
        }
    }
}