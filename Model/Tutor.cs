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
<<<<<<< HEAD
        public int AccountId { get; set; }
        public Account Account { get; set; }
=======
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b

        public int StudentId { get; set; }
        public Student student { get; set; }
    }
}