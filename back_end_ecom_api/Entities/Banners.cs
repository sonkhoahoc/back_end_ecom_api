using System.ComponentModel.DataAnnotations.Schema;

namespace back_end_ecom_api.Entities
{
    [Table("banner")]
    public class Banners: IAuditableEntity
    {
        public string banner_name { get; set; }
        public string link_url { get; set; } //đường dẫn đến web tương ứng banner
    }
}
