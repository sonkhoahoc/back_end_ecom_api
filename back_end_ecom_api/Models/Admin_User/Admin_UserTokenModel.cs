namespace back_end_ecom_api.Models.Admin_User
{
    public class Admin_UserTokenModel
    {
        public class Admin_UserCreateModel
        {
            public string username { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public string phone { get; set; }
            public string fullname { get; set; }
            public string address { get; set; }
        }

        public class Admin_UserModifyModel
        {
            public long id { get; set; }
            public string email { get; set; }
            public string phone { get; set; } = string.Empty;
            public string fullname { get; set; }
            public string address { get; set; }
        }
    }
}
