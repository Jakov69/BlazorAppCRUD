namespace BlazorAppOluja.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modeBuilder)
        {
            modeBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Knin",
                    Description = "Knin pobjeda",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ed/16_obljetnica_vojnoredarstvene_operacije_Oluja_05082011_Kninska_tvrdjava_155.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Mile",
                    Description = "Predaja Milana Martića",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/hr/4/43/Predaja_21.korpusa_SVK_1995.jpg",
                    Price = 7.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Oluja",
                    Description = "Operacija Oluja 95",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/69/Map_49_-_Croatia_-_Operation_Oluja%2C_4-8_August_1995.jpg/800px-Map_49_-_Croatia_-_Operation_Oluja%2C_4-8_August_1995.jpg",
                    Price = 8.99m
                }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
