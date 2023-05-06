using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection.Metadata;

namespace Dormitory
{
    internal class StudentManagement
    {
        static string fileContent = File.ReadAllText("MOCK_DATA.json");
        readonly List<Students> students = JsonSerializer.Deserialize<List<Students>>(fileContent);
        public bool StudentCheck(int targetId)
        {
            bool studentExists = students.Any(s => s.Id == targetId);
            if (studentExists)
            {
                return true;
            }
            else return false;
        }






    };
}
