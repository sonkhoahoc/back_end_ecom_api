using System.ComponentModel.DataAnnotations.Schema;

namespace back_end_ecom_api.Entities
{
    [Table("admin_user")]
    public class Admin_User: IAuditableEntity
    {
        public string user_name { get; set; } = string.Empty;
        public string full_name { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string pass_code {  get; set; } = string.Empty;
        public string number {  get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public byte sex { get; set; }
        public string avatar { get; set; }
        public bool is_active { get; set; }
        public byte type { get; set; }
    }
}
