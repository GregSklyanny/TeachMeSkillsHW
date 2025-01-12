using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseHW7
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Student(string firstname, string secondName, string phoneNumber, string email)
        {
            Guid id = Guid.NewGuid();
            FirstName = firstname;
            SecondName = secondName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
