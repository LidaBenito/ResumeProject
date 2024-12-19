using System.ComponentModel.DataAnnotations;

namespace Resume.DAL.Model.Common
{
    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
