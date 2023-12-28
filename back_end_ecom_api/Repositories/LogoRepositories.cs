using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace back_end_ecom_api.Repositories
{
    public class LogoRepositories : ILogoRepositories
    {
        private readonly ApplicationContext _context;

        public LogoRepositories(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Logo> CreateLogo(Logo logo)
        {
            _context.Logo.Add(logo);
            await _context.SaveChangesAsync();

            return logo;
        }

        public async Task<bool> DeleteLogo(long id)
        {
            var logos = await _context.Logo.FindAsync(id);

            if(logos == null)
            {
                return false;
            }

            _context.Logo.Remove(logos);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<Logo>> GetListLogo()
        {
            return await _context.Logo.OrderByDescending(l => l.dateAdded).ToListAsync();
        }

        public async Task<Logo> GetLogobyId(long id)
        {
            return await _context.Logo.FirstOrDefaultAsync(l => l.id == id);
        }

        public async Task<Logo> ModifyLogo(long id, Logo logo)
        {
            var logos = await _context.Logo.FirstOrDefaultAsync(l => l.id == id);

            if(logos == null)
            {
                return null;
            }

            logos.logo_name = logo.logo_name;
            _context.Entry(logos).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return logos;
        }
    }
}
