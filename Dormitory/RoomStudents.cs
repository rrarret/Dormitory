using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory
{
    internal class RoomStudents
    {
        public int Id { get; set; }
        public int DormitoryId { get; set; }
        public int RoomId { get; set; }
        public int StudentId { get; set; }
        public int Capacity { get; set; }
        DateOnly? StartDate { get; set; }
        DateOnly? EndDate { get; set; }
    }
}
