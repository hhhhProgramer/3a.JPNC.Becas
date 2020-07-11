using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Visit : BaseEntity
    {
        public DateTime Date{ get; set; }

        [ForeignKey("Tutor")]
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
    }
}