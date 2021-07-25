Scaffold-DbContext "Server=LHRLT-6243\SQLEXPRESS;Database=EZchingDev;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -Context "EZChingContext" -DataAnnotations -force


protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(AppConfiguration.SQLConnectionString);
            }
        }