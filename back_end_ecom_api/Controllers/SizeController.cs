using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using back_end_ecom_api.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace back_end_ecom_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : BaseController
    {
        private readonly ISizeRepositories _repositories;

        public SizeController(ISizeRepositories repositories)
        {
            _repositories = repositories;
        }

        [HttpGet("size-list")]
        public async Task<IActionResult> GetListSize()
        {
            try
            {
                var size = await _repositories.GetListSize();

                return Ok(new ResponseMessageModel<List<Sizes>>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = size
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

        [HttpGet("size/{id}")]
        public async Task<IActionResult> GetSizebyId(long id)
        {
            try
            {
                var size = await _repositories.GetSizebyId(id);

                if(size == null)
                {
                    return Ok(new ResponseMessageModel<Sizes>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Sizes>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = size
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

        [HttpPost("size-create")]
        public async Task<IActionResult> CreateSize([FromBody] Sizes size)
        {
            try
            {
                var size_pro = await _repositories.CreateSize(size);

                return Ok(new ResponseMessageModel<Sizes>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = size_pro
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

        [HttpPut("size-modify/{id}")]
        public async Task<IActionResult> ModifySize([FromBody] Sizes size, long id)
        {
            try
            {
                var size_pro = await _repositories.ModifySize(id, size);

                if(size_pro == null)
                {
                    return Ok(new ResponseMessageModel<Sizes>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Sizes>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = size_pro
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

        [HttpDelete("size-delete/{id}")]
        public async Task<IActionResult> DeleteSize(long id)
        {
            try
            {
                var size = await _repositories.DeleteSize(id);

                if (!size)
                {
                    return Ok(new ResponseMessageModel<Sizes>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Sizes>
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
