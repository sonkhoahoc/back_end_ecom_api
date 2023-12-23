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
            product.dateAdded = DateTime.Now;
            product.dateUpdate = DateTime.Now;
            product.is_delete = false;

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<bool> DeleteProduct(long id)
        {
            var product = await _context.Products.FindAsync(id);

            if(product == null || product.is_delete)
            {
                return false;
            }

            product.is_delete = true;
            product.dateUpdate = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<PaginationSet<Products>> GetListProduct(string? keyword, int page_number, int page_size)
        {
            var product = _context.Products.AsQueryable();

            if(!string.IsNullOrWhiteSpace(keyword))
            {
                product = product.Where(p => p.name.Contains(keyword));
            }

            product = product.Where(p => !p.is_delete);

            var total_count = await product.CountAsync();
            var total_page = (int)Math.Ceiling(total_count / (double)page_size);
            var max_page = Math.Max(1, total_page);

            var list = await product
                .OrderByDescending(p => p.dateAdded)
                .Skip((page_number -1 ) * page_size)
                .Take(page_size)
                .ToListAsync();

            return new PaginationSet<Products>
            {
                list = list,
                page = page_number,
                total_page = total_page,
                total_count = total_count,
                max_page = max_page
            };
        }

        public async Task<Products> GetProductbyId(long id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.id == id && !p.is_delete);
        }

        public async Task<Products> ProductModify(Products product)
        {
            try
            {
                var update_pro = await _context.Products.FindAsync(product.id);

                if(update_pro == null || update_pro.is_delete)
                {
                    return null;
                }

                _context.Entry(update_pro).CurrentValues.SetValues(product);
                await _context.SaveChangesAsync();

                return update_pro;
            }
            catch
            {
                return null;
            }
        }
    }
}