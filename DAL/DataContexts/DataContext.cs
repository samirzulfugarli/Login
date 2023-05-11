using Microsoft.EntityFrameworkCore;
using Project_Login.Entities;

namespace Project_Login.DAL.DataContexts
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
        public DbSet<UserRegister>UserRegisters { get; set; }
    }
}
