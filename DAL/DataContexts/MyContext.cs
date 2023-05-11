using Microsoft.EntityFrameworkCore;
using Project_Login.Entities;

namespace Project_Login.DAL.DataContexts
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext>options):base(options)
        {

        }
        public DbSet<UserRegister>UserRegisters { get; set; }
    }
}
