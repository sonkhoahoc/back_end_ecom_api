using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using back_end_ecom_api.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace back_end_ecom_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogoController : BaseController
    {
        private readonly ILogoRepositories _repositories;

        public LogoController(ILogoRepositories repositories)
        {
            _repositories = repositories;
        }

        [HttpGet("logo-list")]
        public async Task<IActionResult> GetListLogo()
        {
            try
            {
                var logo = await _repositories.GetListLogo();

                return Ok(new ResponseMessageModel<List<Logo>>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = logo
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý",
                    Data = null
                });
            }
        }

        [HttpGet("logo/{id}")]
        public async Task<IActionResult> GetLogobyId(long id)
        {
            try
            {
                var logo = await _repositories.GetLogobyId(id);

                if(logo == null)
                {
                    return Ok(new ResponseMessageModel<Logo>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Logo>
                {
                    StatusCode = 200,
                    Message = " Thành công",
                    Data = logo
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý",
                    Data = null
                });
            }
        }

        [HttpPost("logo-create")]
        public async Task<IActionResult> CreateLogo([FromBody] Logo logo)
        {
            try
            {
                var logos = await _repositories.CreateLogo(logo);

                return Ok(new ResponseMessageModel<Logo>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = logos
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý",
                    Data = null
                });
            }
        }

        [HttpPut("logo-modify/{id}")]
        public async Task<IActionResult> ModifyLogo([FromBody] Logo logo, long id)
        {
            try
            {
                var logos = await _repositories.ModifyLogo(id, logo);

                if(logos == null)
                {
                    return Ok(new ResponseMessageModel<Logo>
                    {
                        StatusCode = 404,
                        Message = " Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Logo>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = logos
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý",
                    Data = null
                });
            }
        }

        [HttpDelete("logo-delete/{id}")]
        public async Task<IActionResult> DeleteLogo(long id)
        {
            try
            {
                var logo = await _repositories.DeleteLogo(id);

                if(!logo)
                {
                    return Ok(new ResponseMessageModel<Logo>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Logo>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = null
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý",
                    Data = null
                });
            }
        }
    }
}
