namespace Model
{
    public class EconomicStudy : BaseEntity
    {
        public bool Status { get; set; }
        public int Income { get; set; }
        public int Expenses { get; set; }
        public int Feeding { get; set; }
        public int Rcidence { get; set; }
        public string Services { get; set; }
        public int Fees { get; set; }
        public int Transport { get; set; }
        public int Other { get; set; }
        public int Distribution { get; set; } // piece
        public int Place { get; set; }
        public int Material { get; set; }
        public string Furniture { get; set; }
        public string Observations { get; set; }
        
    }
}