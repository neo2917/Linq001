using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqdemo
{
    public class RepositoryCollege
    {
        public static List<Cohort> cohorts()
        {
            List<Cohort> cohorts = new List<Cohort>();
            {
                new Cohort { Id = 1, CohortName = "English" },
                new Cohort { Id = 2, CohortName = "French" },
                new Cohort { Id = 3, CohortName = "Italian" },
                new Cohort { Id = 4, CohortName = "Spanish" }
            };

            return cohorts;
        }

        public static List<Student> students()
        {
            List<Student> students = new List<Student>()
            {
                new Student{CohortId = 1, StudentID=1, StudentName = "Bruce Wayne"},
                new Student{CohortId = 1, StudentID=1, StudentName = "Bruce Wayne"},
                new Student{CohortId = 1, StudentID=1, StudentName = "Bruce Wayne"},
                new Student{CohortId = 1, StudentID=1, StudentName = "Bruce Wayne"}
            };
        }
        }
    }
}
