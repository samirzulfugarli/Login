namespace Project_Login.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public UserRegister? UserRegister { get; set; }
        public Banks? Banks { get; set; }
        public string CardType { get; set; }
        public int CadrNumber { get; set; }
    }
}
