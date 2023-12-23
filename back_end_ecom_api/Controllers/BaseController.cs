using back_end_ecom_api.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace back_end_ecom_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected long userid(IHttpContextAccessor _httpContextAccessor)
        {
            long id = long.Parse(_httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type.Equals("sid", StringComparison.OrdinalIgnoreCase))?.Value ?? "0");
            return id;
        }

        protected IActionResult RouteToInternalServerError()
        {
            return StatusCode(500, new ResponseMessageModel<IResponseData>
            {
                StatusCode = 500,
                Message = "Internal Server Error!",
            });
        }

        protected IActionResult RouteToFordbiddenServerError()
        {
            return StatusCode(403, new ResponseMessageModel<IResponseData>
            {
                StatusCode = 403,
                Message = "Fordbidden!",

            });
        }
    }
}
