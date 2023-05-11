using Project_Login.DAL.Concrete;
using Project_Login.Entities;

namespace Project_Login.DAL.Abstract
{
    public interface IUserRegisterRepository
    {
        UserRegister Check(string username,string password);
        void Add(UserRegister userRegister);
    }
}
