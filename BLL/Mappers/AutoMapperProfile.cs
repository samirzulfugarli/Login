using AutoMapper;
using Project_Login.Dtos.UserRegisterDtos;
using Project_Login.Entities;

namespace Project_Login.BLL.Mappers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRegisterToAddDtos, UserRegister>();
        }
    }
}
