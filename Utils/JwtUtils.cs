using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using hrm_api.Configurattion;
using hrm_api.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ServiceLayer;

namespace hrm_api.Utils;

public class JwtUtils
{
    public static IdentityDTO ValidateToken(string token)
        {
            if (token == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var appConfig = new AppConfigService().GetAppConfig();

            var key = Encoding.UTF8.GetBytes(appConfig.SignatureKey ?? "");
            try
            {
                ClaimsPrincipal principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var identity = principal?.Identity as ClaimsIdentity;
                var identityDTO = new IdentityDTO
                {
                    FullName = identity?.FindFirst(ClaimTypes.GivenName)?.Value ?? "",
                    EmployeeId = identity?.FindFirst("EmployeeId")?.Value ?? "",
                    UserID = identity?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "",
                    Username = identity?.FindFirst(ClaimTypes.Name)?.Value ?? "",
                    UserType = identity?.FindFirst(ClaimTypes.SerialNumber)?.Value ?? "",
                    PlatformType = identity?.FindFirst(ClaimTypes.System)?.Value ?? "",
                    StructureCode = identity?.FindFirst(ClaimTypes.Spn)?.Value ?? "",
                    Country = identity?.FindFirst(ClaimTypes.Country)?.Value ?? "",
                    Region = identity?.FindFirst(ClaimTypes.Sid)?.Value ?? "",
                    CostCenterCode = identity?.FindFirst("CostCenterCode")?.Value ?? ""
                };
                return identityDTO;
            }
            catch (SecurityTokenValidationException ex)
            {
                var result = new ObjectResult(new ServiceResponse<string>()
                {
                    Code = 401,
                    Status = "INVALID_TOKEN",
                    Message = "Invalid access token key"
                })
                {
                    StatusCode = 401
                };
                throw new UnauthorizedAccessException("Invalid access token key", ex);
            }
            catch (Exception ex)
            {
                _ = new ObjectResult(new ServiceResponse<string>()
                {
                    Code = 500,
                    Status = "ERROR",
                    Message = "An error occurred while validating the token"
                })
                {
                    StatusCode = 500
                };
                throw new Exception("Token validation error", ex);
            }
        }
}