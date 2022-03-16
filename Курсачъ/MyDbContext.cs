
using System.Data.Entity;

namespace Курсачъ
{
    class MyDBContext : DbContext
    {
        public MyDBContext() : base("DbConnect")
        {

        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sale> Sales { get; set; }

    }
}
