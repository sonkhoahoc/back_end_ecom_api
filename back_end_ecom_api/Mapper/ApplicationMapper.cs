using AutoMapper;
using back_end_ecom_api.Entities;
using back_end_ecom_api.Models.Customer;

namespace back_end_ecom_api.Mapper
{
    public class ApplicationMapper: Profile
    {
        public ApplicationMapper()
        {
            //Mapper tài khoản admin
            CreateMap<Admin_User, Admin_UserModel>();
            CreateMap<Admin_UserModel, Admin_User>();

            //Mapper tài khoản người dùng
        }
    }
}
