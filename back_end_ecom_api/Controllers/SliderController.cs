using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using back_end_ecom_api.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace back_end_ecom_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : BaseController
    {
        private readonly ISliderRepositories _repositories;

        public SliderController(ISliderRepositories repositories)
        {
            _repositories = repositories;
        }

        [HttpGet("slider-list")]
        public async Task<IActionResult> GetListSlider()
        {
            try
            {
                var slider = await _repositories.GetListSlider();

                return Ok(new ResponseMessageModel<List<Sliders>>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = slider
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quỗ trình xử lý!!!",
                    Data = null
                });
            }
        }

        [HttpGet("slider/{id}")]
        public async Task<IActionResult> GetSliderbyId(long id)
        {
            try
            {
                var slider = await _repositories.GetSliderbyId(id);

                if(slider == null)
                {
                    return Ok(new ResponseMessageModel<Sliders>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Sliders>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = slider
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quỗ trình xử lý!!!",
                    Data = null
                });
            }
        }

        [HttpPost("slider-create")]
        public async Task<IActionResult> CreateSlider([FromBody] Sliders sliders)
        {
            try
            {
                var slider = await _repositories.CreateSlider(sliders);

                return Ok(new ResponseMessageModel<Sliders>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = slider
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quỗ trình xử lý!!!",
                    Data = null
                });
            }
        }

        [HttpPut("slider-modify/{id}")]
        public async Task<IActionResult> ModifySlider(long id, [FromBody]Sliders sliders)
        {
            try
            {
                var slider = await _repositories.ModifySlider(id, sliders);

                if(slider == null)
                {
                    return Ok(new ResponseMessageModel<Sliders>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = slider
                    });
                }

                return Ok(new ResponseMessageModel<Sliders>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = slider
                });
            }
            catch (Exception)
            {
                return Ok(new ResponseMessageModel<IResponseData>
                {
                    StatusCode = 500,
                    Message = "Có lỗi trong quỗ trình xử lý!!!",
                    Data = null
                });
            }
        }

        [HttpDelete("slider-delete/{id}")]
        public async Task<IActionResult> DeleteSlider(long id)
        {
            try
            {
                var slider = await _repositories.DeleteSlider(id);

                if (!slider)
                {
                    return Ok(new ResponseMessageModel<Sliders>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Sliders>
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
                    Message = "Có lỗi trong quỗ trình xử lý!!!",
                    Data = null
                });
            }
        }
    }
}
