using back_end_ecom_api.Entities;

namespace back_end_ecom_api.IRepositories
{
    public interface IBannerRepositories
    {
        Task<List<Banners>> GetListBanner();
        Task<Banners> GetBannerbyId(long id);
        Task<Banners> CreateBanner(Banners banners);
        Task<Banners> ModifyBanner(long id, Banners banners);
        Task<bool> DeleteBanner(long id);
    }
}
