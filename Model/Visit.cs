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
<<<<<<< HEAD
              
=======
        public int AccountId { get; set; }
        public Account account { get; set; }
>>>>>>> 60f20aaa57d4b0c51e44fd19f6bbb4e69828bb5b
        public int EvaluatorId { get; set; }
        public Evaluator evaluator { get; set; }
    }
}