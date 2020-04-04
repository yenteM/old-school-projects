using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            //GradeBook book = new GradeBook();

            var grades = new List<Grade>
            {
                new Grade {CourseName = "Java", Score = 80.0f },
                new Grade {CourseName = "PHP", Score = 20.0f }
            };

            grades[0].Score = 85.0f;

        }
    }
}
