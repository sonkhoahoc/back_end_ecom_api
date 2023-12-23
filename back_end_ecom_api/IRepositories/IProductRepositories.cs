using back_end_ecom_api.Entities;
using back_end_ecom_api.Models.Common;

namespace back_end_ecom_api.IRepositories
{
    public interface IProductRepositories
    {
        public Task<PaginationSet<Products>> GetListProduct(string? keyword, int page_number, int pageSize);
        public Task<Products> GetProductbyId(long id);
        public Task<Products> CreateProduct(Products product);
        public Task<Products> ProductModify(Products product);
        public Task<bool> DeleteProduct(long id);
    }
}
