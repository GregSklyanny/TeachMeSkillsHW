using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseHW7
{
    public interface ICourse
    {
        public Lesson GetCurrentLesson();
        public void StopCurrentLesson();
        public bool AddLesson(string name, string description, DateTime datetime);
        public bool RemoveLesson(Guid id);
        public void SendMessage(string message, ISender sender);
        public bool AddStudent(string name, string secondName, string phoneNumber, string email);
        public bool RemoveStudent(Guid id);
    }
}
