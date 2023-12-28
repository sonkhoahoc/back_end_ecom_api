using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using back_end_ecom_api.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace back_end_ecom_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Category_ProductController : BaseController
    {
        private readonly ICategory_ProductRepositories _repositories;

        public Category_ProductController(ICategory_ProductRepositories repositories)
        {
            _repositories = repositories;
        }

        [HttpGet("category-product-list")]
        public async Task<IActionResult> GetListCategory_Product()
        {
            try
            {
                var category = await _repositories.GetListCategory_Product();

                return Ok(new ResponseMessageModel<List<Category_Products>>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = category
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

        [HttpGet("category-product/{id}")]
        public async Task<IActionResult> GetCategory_ProductbyId(long id)
        {
            try
            {
                var category = await _repositories.GetCategory_ProductbyId(id);

                if(category == null)
                {
                    return Ok(new ResponseMessageModel<Category_Products>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Category_Products>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = category
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

        [HttpPost("category-create")]
        public async Task<IActionResult> CreateCategory_Product([FromBody] Category_Products category)
        {
            try
            {
                var cate = await _repositories.CreateCategory_Product(category);

                return Ok(new ResponseMessageModel<Category_Products>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = cate
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

        [HttpPut("category-product-modify/{id}")]
        public async Task<IActionResult> ModifyCategory_Product([FromBody] Category_Products category, long id)
        {
            try
            {
                var cate = await _repositories.ModifyCategory_Product(id, category);

                if(cate == null)
                {
                    return Ok(new ResponseMessageModel<Category_Products>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Category_Products>
                {
                    StatusCode = 200,
                    Message = "Thành công",
                    Data = cate
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

        [HttpDelete("category-product-delete/{id}")]
        public async Task<IActionResult> DeleteCategory_Product(long id)
        {
            try
            {
                var cate = await _repositories.DeleteCategory_Product(id);

                if (!cate)
                {
                    return Ok(new ResponseMessageModel<Category_Products>
                    {
                        StatusCode = 404,
                        Message = "Không thấy",
                        Data = null
                    });
                }

                return Ok(new ResponseMessageModel<Category_Products>
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
