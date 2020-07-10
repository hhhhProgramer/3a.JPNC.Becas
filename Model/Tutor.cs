namespace Model
{
    public class Tutor : BaseEntity
    {
        public int Birthday { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Names { get; set; }
        public string Occupation { get; set; }

        //FK

        public int AccountId { get; set; }
        public Account Account { get; set; }


        public int StudentId { get; set; }
        public Student student { get; set; }
    }
}