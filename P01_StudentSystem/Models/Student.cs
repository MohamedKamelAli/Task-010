using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_010.Models
{
    public  class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }

        public List<Homework> Homeworks { get; set; }


    }
}
