using Project_Login.Dtos.UserRegisterDtos;
using Project_Login.Entities;

namespace Project_Login.BLL.Abstract
{
    public interface IUserRegisterService
    {
        void Add(UserRegisterToAddDtos dto);

        UserRegister Check(string username, string password);

    }
}
