using System;

namespace Model
{
    public class Student : BaseEntity
    {
        public string Curp { get; set; }
        public DateTime Birthdate { get; set; }
        public bool Gender { get; set; }
        public int Discount { get; set; }
        public int Suburb { get; set; }
        public int Municipality { get; set; }
        public int Locality { get; set; }
    }
}
