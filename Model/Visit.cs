using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Visit : BaseEntity
    {
        public DateTime Date{ get; set; }

        [ForeignKey("TutorId")]
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
        
        [ForeignKey("EvaluatorId")]
        public int EvaluatorId { get; set; }
        public Evaluator Evaluator { get; set; }
        public EconomicStudy EconomicStudy { get; set; }
    }
}