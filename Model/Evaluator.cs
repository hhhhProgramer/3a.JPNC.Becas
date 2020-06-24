namespace Model
{
    public class Evaluator : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Names { get; set; }

        public int VisitId { get; set; }
        public Visit visit { get; set; }
    }
}