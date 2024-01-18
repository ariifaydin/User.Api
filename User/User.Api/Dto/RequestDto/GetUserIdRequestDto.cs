namespace User.Api.Dto.RequestDto
{
    public class GetUserIdRequestDto
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public int Password { get; set; }
        public string? Email { get; set; }
    }
}
