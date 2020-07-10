namespace Model
{
    public class Account : BaseEntity
    {
        public bool Status { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
<<<<<<< HEAD
        public int Type { get; set; }
=======
        
        //Fk
        public int StudentId { get; set; }
        public Student student { get; set; }
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b
    }
}