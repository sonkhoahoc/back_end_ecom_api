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

        public Task<Logo> CreateLogo(Logo logo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteLogo(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Logo>> GetListLogo()
        {
            throw new NotImplementedException();
        }

        public Task<Logo> GetLogobyId(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Logo> ModifyLogo(Logo logo)
        {
            throw new NotImplementedException();
        }
    }
}
