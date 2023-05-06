using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory
{
    internal class Applications
    {
        public int Id { get; set; }
        public int StudentId { get; set; } 
        public int AnnouncementId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool IsActive { get; set; }

    }
}
 