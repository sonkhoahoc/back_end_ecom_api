using System.ComponentModel.DataAnnotations.Schema;

namespace back_end_ecom_api.Entities
{
    [Table("product_file")]
    public class Product_Files: IAuditableEntity
    {
        public long product_id { get; set; }
        public string file_name { get; set; }
    }
}
