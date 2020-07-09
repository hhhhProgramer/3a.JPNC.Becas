namespace Model
{
    public class Account : BaseEntity
    {
        public bool Status { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        
        //Fk
        public int StudentId { get; set; }
        public Student student { get; set; }
    }
}