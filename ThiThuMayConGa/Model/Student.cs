using System.ComponentModel.DataAnnotations;

namespace ThiThuMayConGa.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
    }
}
