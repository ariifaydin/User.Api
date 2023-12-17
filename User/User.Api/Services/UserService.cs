using AutoMapper;
using User.Api.Dto.RequestDto;
using User.Api.Dto.ResponseDto;
using User.Api.Entites;
using User.Api.Repositories;
using User.Api.UnitOfWorks.Abstract;

namespace User.Api.Services
{
    public class UserService: IUserService
    {
        private readonly IEFRepository<UserEntity> _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IEFRepository<UserEntity> userRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public CreateUserResponseDto CreateUser(CreateUserRequestDto createUserRequestDto)
        {
            UserEntity user = _mapper.Map<UserEntity>(createUserRequestDto);

            user = _userRepository.Add(user);

            _unitOfWork.SaveChanges();

            return _mapper.Map<CreateUserResponseDto>(user);
        }
    }
}
