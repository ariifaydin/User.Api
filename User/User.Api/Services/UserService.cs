using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using User.Api.Dto.RequestDto;
using User.Api.Dto.ResponseDto;
using User.Api.Entites;
using User.Api.Repositories;
using User.Api.UnitOfWorks.Abstract;
using User.Api.UnitOfWorks.Concrete;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace User.Api.Services
{
    public class UserService : IUserService
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

        public CreateUserResponseDto CreateUserAsync(CreateUserRequestDto createUserRequestDto)
        {
            UserEntity user = _mapper.Map<UserEntity>(createUserRequestDto);

            user = _userRepository.Add(user);

            _unitOfWork.SaveChanges();

            return _mapper.Map<CreateUserResponseDto>(user);
        }

        public UpdateUserResponseDto UpdateUserAsync(UpdateUserRequestDto requestDto)
        {
            var dbUser = _userRepository.GetById(requestDto.Id);

            var updatedDbUser = _mapper.Map(requestDto, dbUser);

            updatedDbUser = _userRepository.Update(updatedDbUser);
            _unitOfWork.SaveChanges();

            return _mapper.Map<UpdateUserResponseDto>(updatedDbUser);
        }

        public void DeleteUserAsync(Guid id)
        {
            _userRepository.Delete(id);

            _unitOfWork.SaveChanges();
        }

        public GetUserIdResponseDto GetUserByIdAsync(GetUserIdRequestDto getUserIdRequestDto)
        {
            var dbUser = _userRepository.GetById(getUserIdRequestDto.Id);

            return _mapper.Map<GetUserIdResponseDto>(dbUser);
        }

        public List<GetUserIdResponseDto> GetUsers(int page, int limit)
        {
            var filteredUsers = _userRepository.Get().Skip((page -1) * limit).Take(limit).ToList();

            return _mapper.Map<List<GetUserIdResponseDto>>(filteredUsers);
        }
    }
}
