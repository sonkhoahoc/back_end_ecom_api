using System.ComponentModel.DataAnnotations.Schema;

namespace back_end_ecom_api.Entities
{
    [Table("slider")]
    public class Sliders: IAuditableEntity
    {
        public string file_name { get; set; }
    }
}
