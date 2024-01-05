using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace back_end_ecom_api.Repositories
{
    public class SliderRepositories : ISliderRepositories
    {
        private readonly ApplicationContext _context;

        public SliderRepositories(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Sliders> CreateSlider(Sliders slider)
        {
            _context.Sliders.Add(slider);
            await _context.SaveChangesAsync();

            return slider;
        }

        public async Task<bool> DeleteSlider(long id)
        {
            var slider = await _context.Sliders.FindAsync(id);

            if (slider == null)
            {
                return false;
            }

            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Sliders> GetSliderbyId(long id)
        {
            return await _context.Sliders.FirstOrDefaultAsync(s => s.id == id);
        }

        public async Task<List<Sliders>> GetListSlider()
        {
            return await _context.Sliders.OrderByDescending(s => s.dateAdded).ToListAsync();
        }

        public async Task<Sliders> ModifySlider(long id, Sliders sliders)
        {
            var slider = await _context.Sliders.FirstOrDefaultAsync(s => s.id == id);

            if(slider == null)
            {
                return null;
            }

            slider.file_name = sliders.file_name;
            _context.Entry(slider).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return slider;
        }
    }
}
