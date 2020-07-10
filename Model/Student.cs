using System;
<<<<<<< HEAD
using System.Collections.Generic;
=======
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b

namespace Model
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Names { get; set; }
        public string Curp { get; set; }
        public DateTime Birthdate { get; set; }
        public bool Gender { get; set; }
        public int Discount { get; set; }
        public string Suburb { get; set; }
        public string Municipality { get; set; }
        public int Locality { get; set; }
        public string Disability { get; set; }
        public string Address { get; set; }
<<<<<<< HEAD

        IEnumerable<Tutor> Tutors { get; set; }
=======
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b
    }
}
