using Microsoft.EntityFrameworkCore;

namespace HiWebAPI.Models
{
    public class context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost;database=HiwebApi;user id=sa;password=arshia1234;Trusted_Connection=false;trustservercertificate=true");
        }
       public  DbSet<Gift> gifts {  get; set; }
    }
}