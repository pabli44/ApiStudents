using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStudents.Dto
{
    public class StudentDTO
    {
        public long idStudent { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public long age { get; set; }
        public string carrer { get; set; }
    }
}
