using Project_Login.DAL.Abstract;
using Project_Login.DAL.DataContexts;
using Project_Login.Entities;

namespace Project_Login.DAL.Concrete
{
    public class UserRegisterRepository : IUserRegisterRepository
    {
        private readonly DataContext _context;
        public UserRegisterRepository(DataContext context)
        {
            _context=context;
        }



        public void Add(UserRegister userRegister)
        {
            _context.UserRegisters.Add(userRegister);
            _context.SaveChanges();
        }

        public List<UserRegister> Get()
        {
            return _context.UserRegisters.ToList();
        }

        public UserRegister GetById(int id)
        {
            UserRegister userRegister = _context.UserRegisters.First(x=>x.Id == id);
            return userRegister;
        }

      
    }
}
