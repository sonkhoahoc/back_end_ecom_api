using AutoMapper;
using back_end_ecom_api.Entities;
using back_end_ecom_api.IRepositories;
using back_end_ecom_api.Models.Common;
using back_end_ecom_api.Models.Customer;
using Microsoft.EntityFrameworkCore;

namespace back_end_ecom_api.Repositories
{
    public class AdminRepositories : IAdminRepositories
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public AdminRepositories(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<string> Authentication(LoginModel login)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ChangAdminPassword(ChangePassModel changePass)
        {
            throw new NotImplementedException();
        }

        public Task<Admin_UserModel> CheckAdmin(string username)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckUserExists(string username, string email)
        {
            throw new NotImplementedException();
        }

        public Task<Admin_UserModel> CreateAdmin(Admin_UserModel model_Admin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAdmin(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Admin_UserModel> GetAdminbyId(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Admin_UserModel>> GetListAdmin()
        {
            throw new NotImplementedException();
        }

        public Task<Admin_UserModel> ModifyAdmin(Admin_UserModel model_Admin)
        {
            throw new NotImplementedException();
        }
    }
}
