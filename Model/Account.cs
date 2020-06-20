namespace Model
{
    public class Account
    {
        public bool Status { get; set; }

        //Fk
        public int StudentId { get; set; }
        public Student student { get; set; }
    }
}