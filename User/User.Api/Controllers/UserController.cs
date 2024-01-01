using Microsoft.AspNetCore.Mvc;
using User.Api.Dto.RequestDto;
using User.Api.Dto.ResponseDto;
using User.Api.Services;

namespace User.Api.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost(Name = "")]
        public CreateUserResponseDto CreateUser([FromBody] CreateUserRequestDto requestDto)
        {
            return _userService.CreateUserAsync(requestDto);
        }

        [HttpPut(Name = "")]
        public UpdateUserResponseDto UpdateUser([FromBody] UpdateUserRequestDto requestDto)
        {
            return _userService.UpdateUserAsync(requestDto);
        }
    }
}
