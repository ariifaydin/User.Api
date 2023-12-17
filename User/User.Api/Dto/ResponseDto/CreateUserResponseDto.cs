namespace User.Api.Dto.ResponseDto
{
    public class CreateUserResponseDto
    {
        public string? Username { get; set; }
        public int Password { get; set; }
        public string? Email { get; set; }
    }
}
