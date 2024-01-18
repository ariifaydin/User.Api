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

        [HttpPost]
        public CreateUserResponseDto CreateUser([FromBody] CreateUserRequestDto requestDto)
        {
            return _userService.CreateUserAsync(requestDto);
        }

        [HttpPut]
        public UpdateUserResponseDto UpdateUser([FromBody] UpdateUserRequestDto requestDto)
        {
            return _userService.UpdateUserAsync(requestDto);
        }

        [HttpDelete]
        public IActionResult DeleteUser([FromQuery] Guid id)
        {
             _userService.DeleteUserAsync(id);

            return NoContent();
        }

        [HttpGet]
        public GetUserIdResponseDto GetUserById([FromQuery] GetUserIdRequestDto requestDto)
        {       
            return _userService.GetUserByIdAsync(requestDto);
        }

        [HttpGet]
        [Route("filter")]
        public List<GetUserIdResponseDto> GetUsers([FromQuery] int page, int limit) 
        {
            return _userService.GetUsers(page, limit);
        }
    }
}
