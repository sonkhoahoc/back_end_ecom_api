using back_end_ecom_api.Entities;

namespace back_end_ecom_api.IRepositories
{
    public interface ISliderRepositories
    {
        Task<List<Sliders>> GetListSlider();
        Task<Sliders> GetSliderbyId(long id);
        Task<Sliders> CreateSlider(Sliders slider);
        Task<Sliders> ModifySlider(long id, Sliders sliders);
        Task<bool> DeleteSlider(long id);
    }
}
