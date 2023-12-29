using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using back_end_ecom_api.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace back_end_ecom_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : BaseController
    {
        private readonly IBannerRepositories _repositories;

        public BannerController(IBannerRepositories repositories)
        {
            _repositories = repositories;
        }

        [HttpGet("banner-list")]
        public async Task<IActionResult> GetListBanner()
        {
            try
            {
                var banner = await _repositories.GetListBanner();

                return Ok(new ResponseMessageModel<List<Banners>>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = banner
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý!!!",
                    Data = null
                });
            }
        }

        [HttpGet("banner/{id}")]
        public async Task<IActionResult> GetBannerbyId(long id)
        {
            try
            {
                var banner = await _repositories.GetBannerbyId(id);

                if (banner == null)
                {
                    return Ok(new ResponseMessageModel<Banners>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Banners>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = banner
                });
            }
            catch(Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý!!!",
                    Data = null
                });
            }
        }

        [HttpPost("create-banner")]
        public async Task<IActionResult> CreateBanner([FromBody] Banners banners)
        {
            try
            {
                var ban = await _repositories.CreateBanner(banners);

                return Ok(new ResponseMessageModel<Banners>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = ban
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý!!!",
                    Data = null
                });
            }
        }

        [HttpPut("banner-modify/{id}")]
        public async Task<IActionResult> ModifyBanner(long id, [FromBody] Banners banners)
        {
            try
            {
                var ban = await _repositories.ModifyBanner(id, banners);

                if(ban == null)
                {
                    return Ok(new ResponseMessageModel<Banners>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Banners>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = ban
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quá trình xử lý!!!",
                    Data = null
                });
            }
        }

        [HttpDelete("banner-delete/{id}")]
        public async Task<IActionResult> DeleteBanner(long id)
        {
            try
            {
                var banner = await _repositories.DeleteBanner(id);

                if (!banner)
                {
                    return Ok(new ResponseMessageModel<Banners>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Banners>
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
                    Message = "Có lỗi trong quá trình xử lý!!!",
                    Data = null
                });
            }
        }
    }
}
