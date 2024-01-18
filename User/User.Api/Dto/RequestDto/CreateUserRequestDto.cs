namespace User.Api.Dto.RequestDto
{
    public class CreateUserRequestDto
    {
        public string? Username { get; set; }
        public int Password { get; set; }
        public string? Email { get; set; }
    }
}
