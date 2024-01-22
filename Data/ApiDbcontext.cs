using Microsoft.EntityFrameworkCore;

namespace Trainer.Data
{

       public class ApiDbContext :DbContext
   {
         public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
         {

         }

     public DbSet<Trainer> Trainers { get; set; }
   }
}

