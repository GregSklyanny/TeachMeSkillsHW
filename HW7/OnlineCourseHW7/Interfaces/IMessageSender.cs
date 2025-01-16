using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseHW7
{
    public interface IMessageSender
    {
        public void SendToStudents(string message, List<Student> list);
    }
}
