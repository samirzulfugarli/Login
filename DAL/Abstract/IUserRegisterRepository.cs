using Project_Login.DAL.Concrete;

namespace Project_Login.DAL.Abstract
{
    public interface IUserRegisterRepository
    {
        List<UserRegisterRepository> Get();
        UserRegisterRepository GetById(int id);
        void Add(UserRegisterRepository UserRegister);    
    }
}
