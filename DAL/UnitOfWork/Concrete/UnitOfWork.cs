using Project_Login.DAL.Abstract;
using Project_Login.DAL.DataContexts;
using Project_Login.DAL.UnitOfWork.Abstract;

namespace Project_Login.DAL.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRegisterRepository UserRegisterRepository { get; set; }
        private readonly MyContext _context;
        public UnitOfWork(IUserRegisterRepository userRegisterRepository,MyContext context)
        {
            _context=context;
            UserRegisterRepository=userRegisterRepository;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
