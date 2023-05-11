using AutoMapper;
using Project_Login.BLL.Abstract;
using Project_Login.DAL.Abstract;
using Project_Login.Dtos.UserRegisterDtos;
using Project_Login.Entities;

namespace Project_Login.BLL.Concrete
{
    public class UserRegisterService : IUserRegisterService
    {
        private readonly IMapper _mapper;
        private IUserRegisterRepository _userRegisterRepository;
        public UserRegisterService(IMapper mapper,IUserRegisterRepository userRegisterRepository)
        {
            _mapper= mapper;
            _userRegisterRepository= userRegisterRepository;
        }
        public void Add(UserRegisterToAddDtos dto)
        {
            UserRegister userRegister = _mapper.Map<UserRegister>(dto);
            _userRegisterRepository.Add(userRegister);
        }
    }
}
