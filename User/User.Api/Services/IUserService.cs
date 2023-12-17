using User.Api.Dto.RequestDto;
using User.Api.Dto.ResponseDto;

namespace User.Api.Services
{
    public interface IUserService
    {
        CreateUserResponseDto CreateUser(CreateUserRequestDto createUserRequestDto);
    }
}
