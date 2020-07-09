using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Visit : BaseEntity
    {
        public DateTime Date{ get; set; }

        //FK
        [ForeignKey("EconomicStudy")]
        public int EconomicStudyId { get; set; }
        public EconomicStudy EconomicStudy  { get; set; }
        public int AccountId { get; set; }
        public Account account { get; set; }
        public int EvaluatorId { get; set; }
        public Evaluator evaluator { get; set; }
    }
}