using System.ComponentModel.DataAnnotations.Schema;

namespace back_end_ecom_api.Entities
{
    [Table("logo")]
    public class Logo: IAuditableEntity
    {
        public string logo_name { get; set; }
    }
}
