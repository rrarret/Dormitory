using System;
using System.Collections.Generic;

namespace Dormitory.DAL
{
    public partial class RoomStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public int? EndDate { get; set; }

        public virtual Room Room { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
