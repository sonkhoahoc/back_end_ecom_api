using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace back_end_ecom_api.Repositories
{
    public class BannerRepositories : IBannerRepositories
    {
        private readonly ApplicationContext _context;

        public BannerRepositories(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Banners> CreateBanner(Banners banners)
        {
            _context.Banners.Add(banners);
            await _context.SaveChangesAsync();

            return banners;
        }

        public async Task<bool> DeleteBanner(long id)
        {
            var banner = await _context.Banners.FindAsync(id);

            if(banner == null)
            {
                return false;
            }

            _context.Banners.Remove(banner);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Banners> GetBannerbyId(long id)
        {
            return await _context.Banners.FirstOrDefaultAsync(b => b.id == id);
        }

        public async Task<List<Banners>> GetListBanner()
        {
            return await _context.Banners.OrderByDescending(b => b.dateAdded).ToListAsync();
        }

        public async Task<Banners> ModifyBanner(long id, Banners banners)
        {
            var banner = await _context.Banners.FirstOrDefaultAsync(b => b.id == id);

            if(banner == null)
            {
                return null;
            }

            banner.banner_name = banners.banner_name;
            banner.link_url = banners.link_url;
            _context.Entry(banner).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return banner;
        }
    }
}
