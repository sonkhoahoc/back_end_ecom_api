using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace back_end_ecom_api.Repositories
{
    public class SizeRepositories : ISizeRepositories
    {
        private readonly ApplicationContext _context;

        public SizeRepositories(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Sizes> CreateSize(Sizes size)
        {
            _context.Sizes.Add(size);
            await _context.SaveChangesAsync();

            return size;
        }

        public async Task<bool> DeleteSize(long id)
        {
            var size_pro = await _context.Sizes.FindAsync(id);

            if(size_pro == null)
            {
                return false;
            }

            _context.Sizes.Remove(size_pro);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Sizes>> GetListSize()
        {
            return await _context.Sizes.OrderByDescending(s => s.dateAdded).ToListAsync();
        }

        public async Task<Sizes> GetSizebyId(long id)
        {
            return await _context.Sizes.FirstOrDefaultAsync(s => s.id == id);
        }

        public async Task<Sizes> ModifySize(long id, Sizes size)
        {
            var size_pro = await _context.Sizes.FirstOrDefaultAsync(s => s.id == id);

            if(size_pro == null)
            {
                return null;
            }

            size_pro.product_id = size.product_id;
            size_pro.name = size.name;
            size_pro.quantity = size.quantity;
            _context.Entry(size_pro).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return size_pro;
        }
    }
}
