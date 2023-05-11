using AutoMapper;
using Project_Login.BLL.Abstract;
using Project_Login.DAL.Abstract;
using Project_Login.DAL.UnitOfWork.Abstract;
using Project_Login.Dtos.UserRegisterDtos;
using Project_Login.Entities;

namespace Project_Login.BLL.Concrete
{
    public class UserRegisterService : IUserRegisterService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        
        public UserRegisterService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper= mapper;
            _unitOfWork = unitOfWork;
        }
        public void Add(UserRegisterToAddDtos dto)
        {
            UserRegister userRegister = _mapper.Map<UserRegister>(dto);
            _unitOfWork.UserRegisterRepository.Add(userRegister);
        }

        public UserRegister Check(string username,string password)
        {
            var user = _unitOfWork.UserRegisterRepository.Check(username,password);
            return user;
        }
       
    }
}
