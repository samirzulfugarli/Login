using Project_Login.DAL.Abstract;
using Project_Login.DAL.DataContexts;
using Project_Login.Entities;

namespace Project_Login.DAL.Concrete
{
    public class UserRegisterRepository : IUserRegisterRepository
    {
        private readonly MyContext _context;
        public UserRegisterRepository(MyContext context)
        {
            _context=context;
        }


        
        public void Add(UserRegister userRegister)
        {
            _context.UserRegisters.Add(userRegister);
            _context.SaveChanges();
        }

        public UserRegister Check(string username, string password)
        {
            return _context.UserRegisters.FirstOrDefault(x => x.Username == username && x.Password== password)!;

        }


        //public List<UserRegister> Get()
        //{
        //    return _context.UserRegisters.ToList();
        //}

        //public UserRegister GetById(int id)
        //{
        //    UserRegister userRegister = _context.UserRegisters.First(x=>x.Id == id);
        //    return userRegister;
        //}


    }
}
