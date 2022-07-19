using Microsoft.EntityFrameworkCore;

namespace laboratorio.data.access.Context
{
    public  class ContextLaboratorio : DbContext
    {

        public ContextLaboratorio()
        {

        }

        public ContextLaboratorio(DbContextOptions<ContextLaboratorio> options) : base(options)
        {

        }

        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=gurusoft;Trusted_Connection=True;");
            }
        }


    }
}
