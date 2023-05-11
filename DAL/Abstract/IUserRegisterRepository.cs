using Project_Login.DAL.Concrete;
using Project_Login.Entities;

namespace Project_Login.DAL.Abstract
{
    public interface IUserRegisterRepository
    {
        List<UserRegister> Get();
        UserRegister GetById(int id);
       void  Add(UserRegister userRegister);    
    }
}
