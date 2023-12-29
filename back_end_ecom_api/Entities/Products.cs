using System.ComponentModel.DataAnnotations.Schema;

namespace back_end_ecom_api.Entities
{
    [Table("product")]
    public class Products: IAuditableEntity
    {
        public long category_id {  get; set; }
        public string name { get; set; } = "";
        public double price { get; set; }
        public int views_count { get; set; } //số lượt xem sản phẩm
        public int stock_quantity { get; set; } //số lượng sản phẩm còn tồn
        public int sold_quantity { get; set; } //số lượng sản phẩm đã bán
        public int quantity {  get; set; }
        public string description { get; set; } = "";
        public string avatar { get; set; }
        public string status { get; set; }
        public bool is_active { get; set; }
    }
}
