using Project_Login.Dtos.UserRegisterDtos;

namespace Project_Login.BLL.Abstract
{
    public interface IUserRegisterService
    {
        void Add(UserRegisterToAddDtos dto);
    }
}
