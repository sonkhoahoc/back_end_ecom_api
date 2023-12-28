using back_end_ecom_api.Entities;

namespace back_end_ecom_api.IRepositories
{
    public interface ILogoRepositories
    {
        public Task<List<Logo>> GetListLogo();
        public Task<Logo> GetLogobyId(long id);
        public Task<Logo> CreateLogo(Logo logo);
        public Task<Logo> ModifyLogo(long id, Logo logo);
        public Task<bool> DeleteLogo(long id);
    }
}
