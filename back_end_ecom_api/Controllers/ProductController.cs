﻿//using back_end_ecom_api.Entities;
//using back_end_ecom_api.IRepositories;
//using back_end_ecom_api.Models.Common;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace back_end_ecom_api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductController : BaseController
//    {
//        private readonly IProductRepositories _repositories;

//        public ProductController(IProductRepositories repositories)
//        {
//            _repositories = repositories;
//        }

//        [HttpGet("product-list")]
//        public async Task<IActionResult> GetListProduct(string? keyword, int page_number, int page_size)
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

//        [HttpGet("product/{id}")]
//        public async Task<IActionResult> GetProductbyId(long id)
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

//        [HttpPost("product-create")]
//        public async Task<IActionResult> CreateProduct([FromBody] Products product)
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

//        [HttpPut("product-modify/{id}")]
//        public async Task<IActionResult> ModifyProduct([FromBody] Products product, long id)
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

//        [HttpDelete("product-delete/{id}")]
//        public async Task<IActionResult> DeleteProduct(long id)
//        {
//            try
//            {
                
//                });
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
