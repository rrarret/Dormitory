using System;
using System.Collections.Generic;

namespace Dormitory.Models
{
    public partial class DormitoryStudent
    {
        public int Id { get; set; }
        public int DormitoryId { get; set; }
        public int StudentId { get; set; }
        public int Capacity { get; set; }

        public virtual Dormitory Dormitory { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
