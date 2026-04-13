using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ex_13_4.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Email { get; set; }

        // 1 Sinh vien co the co nhieu luot Dang ky
        public List<Enrollment> Enrollments { get; set; }
    }
}