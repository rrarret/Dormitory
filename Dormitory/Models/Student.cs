using System;
using System.Collections.Generic;

namespace Dormitory.Models
{
    public partial class Student
    {
        public Student()
        {
            Applications = new HashSet<Application>();
            DormitoryStudents = new HashSet<DormitoryStudent>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;

        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<DormitoryStudent> DormitoryStudents { get; set; }
    }
}
