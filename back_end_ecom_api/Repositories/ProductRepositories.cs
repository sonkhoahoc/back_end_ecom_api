using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using back_end_ecom_api.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace back_end_ecom_api.Repositories
{
    public class ProductRepositories : IProductRepositories
    {
        private readonly ApplicationContext _context;

        public ProductRepositories(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Products> CreateProduct(Products product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<bool> DeleteProduct(long id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.id == id);

            if(product == null)
            {
                return false;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Products>> GetListProduct()
        {
            return await _context.Products.OrderByDescending(p => p.dateAdded).ToListAsync();
        }

        public async Task<Products> GetProductbyId(long id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.id == id);
        }

        public async Task<Products> ModifyProduct(long id, Products product)
        {
            var pro = await _context.Products.FirstOrDefaultAsync(p => p.id == id);

            if(pro == null)
            {
                return null;
            }

            pro.category_id = product.category_id;
            pro.name = product.name;
            pro.price = product.price;
            pro.description = product.description;
            pro.avatar = product.avatar;
            _context.Entry(pro).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return pro;
        }
    }
}