using User.Api.Dto.RequestDto;
using User.Api.Dto.ResponseDto;

namespace User.Api.Services
{
    public interface IUserService
    {
        CreateUserResponseDto CreateUserAsync(CreateUserRequestDto createUserRequestDto);
       
         UpdateUserResponseDto UpdateUserAsync(UpdateUserRequestDto updateUserRequestDto);
         
    }
}
