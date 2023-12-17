namespace User.Api.Entites
{
    public class UserEntity: BaseEntity
    {
        public required string Username { get; set; }
        public required int Password { get; set; }
        public required string Email { get; set; }
    }
}
