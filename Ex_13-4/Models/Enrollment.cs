using System.ComponentModel.DataAnnotations.Schema;

namespace Ex_13_4.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        // Khoa ngoai noi voi bang Student
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        // Khoa ngoai noi voi bang Course
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        // Ban co the them cac thong tin khac cua viec dang ky o day
        public string Semester { get; set; } // Hoc ky (VD: HK1-2026)
        public double? Grade { get; set; } // Diem so (Co the null neu chua co diem)
    }
}