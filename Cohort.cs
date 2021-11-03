using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
    public class Cohort
    {
        public int Id { get; set; }
        public string CohortName { get; set; }

    }
    
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int CohortId { get; set; }


    }
    }
}
