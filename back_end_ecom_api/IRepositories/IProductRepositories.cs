using back_end_ecom_api.Entities;
using back_end_ecom_api.Models.Common;

namespace back_end_ecom_api.IRepositories
{
    public interface IProductRepositories
    {
        Task<List<Products>> GetListProduct();
        Task<Products> GetProductbyId(long id);
        Task<Products> CreateProduct(Products product);
        Task<Products> ModifyProduct(long id, Products product);
        Task<bool> DeleteProduct(long id);
    }
}
