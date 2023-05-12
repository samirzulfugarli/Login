namespace Project_Login.Entities
{
    public class Login
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public UserRegister? userRegister { get; set; }
    }
}
