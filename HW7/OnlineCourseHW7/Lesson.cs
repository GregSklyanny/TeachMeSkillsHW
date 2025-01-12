using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseHW7
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsDone { get; set; }
        public Lesson(string name, string description, DateTime dateTime) 
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            DateTime = dateTime;
            IsDone = false;
        }
    }
}
