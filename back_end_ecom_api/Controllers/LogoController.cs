//using back_end_ecom_api.Entities;
//using back_end_ecom_api.IRepositories;
//using back_end_ecom_api.Models.Common;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace back_end_ecom_api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class LogoController : BaseController
//    {
//        private readonly ILogoRepositories _repositories;

//        public LogoController(ILogoRepositories repositories)
//        {
//            _repositories = repositories;
//        }

//        [HttpGet("logo=list")]
//        public async Task<IActionResult> GetListLogo()
//        {
//            try
//            {
                
//            }
//            catch(Exception)
//            {
//                return Ok(new ResponseMessageModel<IResponseData>
//                {
//                    StatusCode = 500,
//                    Message = "Có lỗi trong quá trình xử lý",
//                    Data = null
//                });
//            }
//        }

//        [HttpGet("logo/{id}")]
//        public async Task<IActionResult> GetLogobyId(long id)
//        {
//            try
//            {
                
//            }
//            catch (Exception)
//            {
//                return Ok(new ResponseMessageModel<IResponseData>
//                {
//                    StatusCode = 500,
//                    Message = "Có lỗi trong quá trình xử lý",
//                    Data = null
//                });
//            }
//        }

//        [HttpPost("logo-create")]
//        public async Task<IActionResult> CreateLogo([FromBody] Logo logo)
//        {
//            try
//            {
                

//            }
//            catch (Exception)
//            {
//                return Ok(new ResponseMessageModel<IResponseData>
//                {
//                    StatusCode = 500,
//                    Message = "Có lỗi trong quá trình xử lý",
//                    Data = null
//                });
//            }
//        }

//        [HttpPut("logo-put/{id}")]
//        public async Task<IActionResult> ModifyLogo([FromBody] Logo logo, long id)
//        {
//            try
//            {
                
//            }
//            catch (Exception)
//            {
//                return Ok(new ResponseMessageModel<IResponseData>
//                {
//                    StatusCode = 500,
//                    Message = "Có lỗi trong quá trình xử lý",
//                    Data = null
//                });
//            }
//        }

//        [HttpDelete("logo-delete/{id}")]
//        public async Task<IActionResult> DeleteLogo(long id)
//        {
//            try
//            {
                
//            }
//            catch (Exception)
//            {
//                return Ok(new ResponseMessageModel<IResponseData>
//                {
//                    StatusCode = 500,
//                    Message = "Có lỗi trong quá trình xử lý",
//                    Data = null
//                });
//            }
//        }
//    }
//}
