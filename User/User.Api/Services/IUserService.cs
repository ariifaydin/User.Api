using User.Api.Dto.RequestDto;
using User.Api.Dto.ResponseDto;

namespace User.Api.Services
{
    public interface IUserService
    {
        CreateUserResponseDto CreateUserAsync(CreateUserRequestDto createUserRequestDto);
        UpdateUserResponseDto UpdateUserAsync(UpdateUserRequestDto updateUserRequestDto);
        void DeleteUserAsync(Guid id);
        GetUserIdResponseDto  GetUserByIdAsync(GetUserIdRequestDto getUserIdRequestDto);

        List<GetUserIdResponseDto> GetUsers(int skip, int count);

    }
}
