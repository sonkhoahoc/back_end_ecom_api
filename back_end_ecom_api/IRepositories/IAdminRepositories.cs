using back_end_ecom_api.Models.Common;
using back_end_ecom_api.Models.Customer;

namespace back_end_ecom_api.IRepositories
{
    public interface IAdminRepositories
    {
        Task<List<Admin_UserModel>> GetListAdmin();
        Task<Admin_UserModel> GetAdminbyId(long id);
        Task<Admin_UserModel> CreateAdmin(Admin_UserModel model_Admin);
        Task<Admin_UserModel> ModifyAdmin(Admin_UserModel model_Admin);
        Task<Admin_UserModel> CheckAdmin(string username);
        Task<bool> ChangAdminPassword(ChangePassModel changePass);
        Task<bool> DeleteAdmin(long id);
        Task<string> Authentication(LoginModel login);
        Task<bool> CheckUserExists(string username, string email);
    }
}
