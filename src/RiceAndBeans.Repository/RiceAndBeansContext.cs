namespace RiceAndBeans.Repository
{
    using RiceAndBeans.Model;
    using System.Data.Entity;

    public class RiceAndBeansContext : DbContext
    {
        public RiceAndBeansContext() : base("RiceAndBeansConnectionString")
        {
            //Database.SetInitializer<SampleContext>(new CreateDatabaseIfNotExists<SampleContext>());
            //Database.SetInitializer<SampleContext>(new DropCreateDatabaseAlways<SampleContext>());

            Database.SetInitializer<RiceAndBeansContext>(new DropCreateDatabaseIfModelChanges<RiceAndBeansContext>());
        }

        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CategoryModel>().HasOptional(b => b.ParentCategory)
            //                      .WithMany(b => b.ChildrenCategory)
            //                      .HasForeignKey(b => b.ParentCategoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
