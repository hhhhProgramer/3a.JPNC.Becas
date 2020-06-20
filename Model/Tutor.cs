namespace Model
{
    public class Tutor : BaseEntity
    {
        public int Brithdate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Names { get; set; }

        //FK

        public int StudentId { get; set; }
        public Student student { get; set; }
    }
}