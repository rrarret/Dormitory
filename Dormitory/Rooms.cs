using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory
{
    internal class Rooms
    {
        public int Id { get; set; }    
        public string Name { get; set; }
        public int DormitoryId { get; set; }
        public int Capacity { get;set; }
    }
}
