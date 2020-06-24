using System;
namespace Model
{
    public class Visit : BaseEntity
    {
        public DateTime Date{ get; set; }

        //FK
        public int StudyEconomicId { get; set; }
        public EconomicStudy  economicStudy{ get; set; }
        public int AccountId { get; set; }
        public Account account { get; set; }
    }
}