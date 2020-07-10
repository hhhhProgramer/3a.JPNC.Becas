namespace Model
{
    public class Account : BaseEntity
    {
        public bool Status { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
    }
}