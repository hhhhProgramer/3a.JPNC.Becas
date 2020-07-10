<<<<<<< HEAD
using System.Collections.Generic;

=======
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b
namespace Model
{
    public class Evaluator : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Names { get; set; }
<<<<<<< HEAD

         //FK
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public IEnumerable<Visit> Visits{ get; set; }
=======
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b
    }
}