using back_end_ecom_api.Entities;

namespace back_end_ecom_api.IRepositories
{
    public interface ICategory_ProductRepositories
    {
        Task<List<Category_Products>> GetListCategory_Product();
        Task<Category_Products> GetCategory_ProductbyId(long id);
        Task<Category_Products> CreateCategory_Product(Category_Products category);
        Task<Category_Products> ModifyCategory_Product(long id, Category_Products category);
        Task<bool> DeleteCategory_Product(long id);
    }
}
