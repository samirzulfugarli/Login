using Project_Login.DAL.Abstract;
using Project_Login.DAL.DataContexts;

namespace Project_Login.DAL.UnitOfWork.Abstract
{
    public interface IUnitOfWork
    {
        public IUserRegisterRepository UserRegisterRepository { get;}
        public void Commit();
    }
}
