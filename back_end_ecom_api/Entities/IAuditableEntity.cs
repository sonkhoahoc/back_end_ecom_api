using System.ComponentModel.DataAnnotations;

namespace back_end_ecom_api.Entities
{
    public class IAuditableEntity
    {
        [Key]
        public long id {  get; set; }
        public long userAdded { get; set; }
        public long userUpdate {  get; set; }
        public DateTime dateAdded { get; set; } = DateTime.Now;
        public DateTime dateUpdate { get; set; } = DateTime.Now;
        public bool is_delete { get; set; } = false;
        public void getAuditable()
        {
            if(id == 0)
                dateUpdate = DateTime.Now;
            else
                dateAdded = DateTime.Now;
        }
    }
}
