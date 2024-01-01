namespace User.Api.Dto.RequestDto
{
    public class UpdateUserRequestDto
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public int Password { get; set; }
        public string? Email { get; set; }
    }
}
