﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseHW7.Senders
{
    public class EmailSender : ISender
    {
        public void SendToStudents(string message, List<Student> list)
        {
            Console.WriteLine($"Сообщение: {message}");
            Console.WriteLine($"Отправлено:");
            foreach (var student in list)
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName} {student.Email}");
            }

            
        }
    }
}
