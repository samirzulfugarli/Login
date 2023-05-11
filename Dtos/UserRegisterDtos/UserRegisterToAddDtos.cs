namespace Project_Login.Dtos.UserRegisterDtos
{
    public record UserRegisterToAddDtos
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
    }
}
