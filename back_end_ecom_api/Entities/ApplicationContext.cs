using Microsoft.EntityFrameworkCore;

namespace back_end_ecom_api.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Category_Products> Category_Products { get; set; }
        public virtual DbSet<Admin_User> Admin_User { get; set; }
        public virtual DbSet<Banners> Banners { get; set; }
        public virtual DbSet<Logo> Logo { get; set; }
        public virtual DbSet<Product_Files> Product_Files { get; set; }
        public virtual DbSet<Sizies> Sizies { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
