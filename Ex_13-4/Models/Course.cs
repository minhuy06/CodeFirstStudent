using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ex_13_4.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string CourseName { get; set; }

        public int Credits { get; set; } // So tin chi

        // 1 Khoa hoc co the co nhieu luot Dang ky
        public List<Enrollment> Enrollments { get; set; }
    }
}