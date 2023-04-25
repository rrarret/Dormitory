using System;
using System.Collections.Generic;

namespace Dormitory.Models
{
    public partial class Dormitory
    {
        public Dormitory()
        {
            DormitoryStudents = new HashSet<DormitoryStudent>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int MaxCapacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<DormitoryStudent> DormitoryStudents { get; set; }
    }
}
