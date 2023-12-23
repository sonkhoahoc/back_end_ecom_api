using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using back_end_ecom_api.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace back_end_ecom_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        private readonly IProductRepositories _repositories;

        public ProductController(IProductRepositories repositories)
        {
            _repositories = repositories;
        }

        [HttpGet("product-list")]
        public async Task<IActionResult> GetListProduct(string? keyword, int page_number, int page_size)
        {
            try
            {
                var product = await _repositories.GetListProduct(keyword, page_number, page_size);
                return Ok(new ResponseMessageModel<PaginationSet<Products>>
                {
                    StatusCode = 200, 
                    Message = "Lấy danh sách thành công!!!",
                    Data = product
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

        [HttpGet("product/{id}")]
        public async Task<IActionResult> GetProductbyId(long id)
        {
            try
            {
                var product = await _repositories.GetProductbyId(id);
                if(product == null)
                {
                    return Ok(new ResponseMessageModel<Products>
                    {
                        StatusCode = 404,
                        Message = "Không tìm thấy sản phẩm!!!",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Products>
                {
                    StatusCode = 200,
                    Message = "Thành công!!!",
                    Data = product
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

        [HttpPost("product-create")]
        public async Task<IActionResult> CreateProduct([FromBody] Products product)
        {
            try
            {
                var products = await _repositories.CreateProduct(product);
                return Ok(new ResponseMessageModel<Products>
                {
                    StatusCode = 200,
                    Message = "Thành công!!!",
                    Data = products
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

        [HttpPut("product-modify/{id}")]
        public async Task<IActionResult> ModifyProduct([FromBody] Products product, long id)
        {
            try
            {
                product.id = id;

                var update_pro = await _repositories.ProductModify(product);

                if(update_pro == null)
                {
                    return Ok(new ResponseMessageModel<Products>
                    {
                        StatusCode = 404,
                        Message = "Không thấy!!!",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Products>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = update_pro
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

        [HttpDelete("product-delete/{id}")]
        public async Task<IActionResult> DeleteProduct(long id)
        {
            try
            {
                var product = await _repositories.DeleteProduct(id);
                if (!product)
                {
                    return Ok(new ResponseMessageModel<Products>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Products>
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
