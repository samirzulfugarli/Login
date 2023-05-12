namespace Project_Login.Entities
{
    public class BankCardOrder
    {
        public int OrderId { get; set; }
        public UserRegister UserRegistr { get; set; }
        public Banks Banks { get; set; }
        public string CardType { get; set; }
        public int CardNumber { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
