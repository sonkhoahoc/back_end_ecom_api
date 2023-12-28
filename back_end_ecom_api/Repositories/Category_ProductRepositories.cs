using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace back_end_ecom_api.Repositories
{
    public class Category_ProductRepositories : ICategory_ProductRepositories
    {
        private readonly ApplicationContext _context;

        public Category_ProductRepositories(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Category_Products> CreateCategory_Product(Category_Products category)
        {
            _context.Category_Products.Add(category);
            await _context.SaveChangesAsync();

            return category;
        }

        public async Task<bool> DeleteCategory_Product(long id)
        {
            var cate = await _context.Category_Products.FindAsync(id);

            if(cate == null)
            {
                return false;
            }

            _context.Category_Products.Remove(cate);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Category_Products> GetCategory_ProductbyId(long id)
        {
            return await _context.Category_Products.FirstOrDefaultAsync(c => c.id == id);
        }

        public async Task<List<Category_Products>> GetListCategory_Product()
        {
            return await _context.Category_Products.OrderByDescending(c => c.dateAdded).ToListAsync();
        }

        public async Task<Category_Products> ModifyCategory_Product(long id, Category_Products category)
        {
            var cate = await _context.Category_Products.FirstOrDefaultAsync(c => c.id == id);

            if(cate == null)
            {
                return null;
            }

            cate.name = category.name;
            _context.Entry(cate).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return cate;
        }
    }
}
