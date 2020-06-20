using System;
namespace Model
{
    public class Visit : BaseEntity
    {
        public DateTime Date{ get; set; }

        //FK
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int EvaluatorId { get; set; }
        public Evaluator evaluator { get; set; }

        public int StudyEconomicId { get; set; }
        public EconomicStudy  economicStudy{ get; set; }

    }
}