using System.ComponentModel.DataAnnotations;
using Model.Interfaz;

namespace Model
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}