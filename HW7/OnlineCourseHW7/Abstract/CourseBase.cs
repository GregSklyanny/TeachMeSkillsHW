using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseHW7
{
    public abstract class CourseBase
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract DateTime StartingDate { get; set; }
        public abstract List<Lesson> LessonList { get; set; }
        public abstract List<Student> StudentList { get; set; }
    }
}
