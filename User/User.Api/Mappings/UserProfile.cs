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
            CreateMap<CreateUserRequestDto, UserEntity>().ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null && !srcMember.Equals(0)));
            CreateMap<UserEntity, CreateUserResponseDto>().ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null && !srcMember.Equals(0)));
            CreateMap<UpdateUserRequestDto, UserEntity>().ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null && !srcMember.Equals(0)));
            CreateMap<UserEntity,UpdateUserResponseDto>().ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null && !srcMember.Equals(0)));
            CreateMap<GetUserIdRequestDto, UserEntity>().ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null && !srcMember.Equals(0)));
            CreateMap<UserEntity, GetUserIdResponseDto>().ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null && !srcMember.Equals(0)));
        }
    }
}
