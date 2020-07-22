using System.Collections.Generic;


namespace Model
{
    public class Evaluator : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Names { get; set; }

         //FK
        public int AccountId { get; set; }
        public Account Account { get; set; }

        public IEnumerable<Visit> Visits { get; set; }
    }
}