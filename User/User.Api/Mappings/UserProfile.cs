using AutoMapper;
using User.Api.Dto.RequestDto;
using User.Api.Dto.ResponseDto;
using User.Api.Entites;

namespace User.Api.Mappings
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserRequestDto, UserEntity>();
            CreateMap<UserEntity, CreateUserResponseDto>();
        }
    }
}
