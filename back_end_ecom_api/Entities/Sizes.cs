using System.ComponentModel.DataAnnotations.Schema;

namespace back_end_ecom_api.Entities
{
    [Table("size")]
    public class Sizes: IAuditableEntity
    {
        public long product_id { get; set; }
        public string name { get; set; } = "";
        public int quantity { get; set; }
    }
}
