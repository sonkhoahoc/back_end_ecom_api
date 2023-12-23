using System.ComponentModel.DataAnnotations.Schema;

namespace back_end_ecom_api.Entities
{
    [Table("category_product ")]
    public class Category_Products: IAuditableEntity
    {
        public string name { get; set; } = "";
    }
}
