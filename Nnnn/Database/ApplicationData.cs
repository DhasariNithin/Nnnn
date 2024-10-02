using Microsoft.EntityFrameworkCore;
using PersonsDetails.Models;

namespace PersonsDetails.Database
{
    public class ApplicationData:DbContext
    {
        public ApplicationData(DbContextOptions<ApplicationData>Options):base(Options)
        {

        }

        public DbSet<PersonData>Person{ get; set; }
    }
}
