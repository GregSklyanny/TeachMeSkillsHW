using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseHW7
{
    public class OnlineCourse : CourseBase, ICourse
    {
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override DateTime StartingDate { get; set; }
    
        public override List<Lesson> LessonList { get; set; }  = new();
        public override List<Student> StudentList { get; set; } = new();

        public OnlineCourse(string name, string description, DateTime startingdate)
        {
            Name = name;
            Description = description;
            StartingDate = startingdate;
        }
        public bool AddStudent(string name, string secondName, string phoneNumber, string email)
        {
            StudentList.Add(new Student(name, secondName, phoneNumber, email));
            Console.WriteLine("Студент добавлен");
            return true;
        }
        public bool RemoveStudent(Guid id)
        {
            Student student = StudentList.Where(s => s.Id == id).FirstOrDefault();
            if (student != null)
            {
                StudentList.Remove(student);
                Console.WriteLine("Студент удален");
                return true;
            }
            Console.WriteLine("Студент не удален");
            return false;
        }
        public bool AddLesson(string name, string description, DateTime datetime)
        {
            LessonList.Add(new Lesson(name, description, datetime));
            Console.WriteLine("Урок добавлен");
            return true;
        }
        public bool RemoveLesson(Guid id)
        {
            Lesson lesson = LessonList.Where(s => s.Id == id).FirstOrDefault();
            if (lesson != null)
            {
                LessonList.Remove(lesson);
                Console.WriteLine("Урок удален");
                return true;
            }
            Console.WriteLine("Урок не удален");
            return false;
        }
        public Lesson GetCurrentLesson()
        {
            
            Lesson lesson = LessonList.Where(l => l.IsDone == false).Select(l => l).OrderBy(l=>l.DateTime).FirstOrDefault();
            if(lesson != null)
            {
                Console.WriteLine($"Текущий урок {lesson.Name}");
                return lesson;
            }
            Console.WriteLine("Нет ближайших уроков");
            return null;
        }
        public void StopCurrentLesson()
        {
            Lesson lesson = LessonList.Where(l => l.IsDone == false).Select(l => l).OrderBy(l => l.DateTime).FirstOrDefault();
            for (int i = 0; i < LessonList.Count; i++)
            {
                if (LessonList[i].Id == lesson.Id)
                {
                    Console.WriteLine("Урок остановлен");
                    LessonList[i].IsDone = true;
                    break;
                }
            }
        }
       public void SendMessage(string message, IMessageSender sender)
        {
            sender.SendToStudents(message, StudentList);
        }

        
    }
}
