namespace OnlineCourseHW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineCourse course = new("Новый курс", "Описание нового курса", DateTime.Now + TimeSpan.FromDays(1));

            course.AddStudent("Вася", "Пупкин", "+3923737324", "vasyap@gmail.com");
            course.AddStudent("Миша", "Рогов", "+1123343324", "misharogov@gmail.com");
            course.AddLesson("Урок1", "его описание", DateTime.Now + TimeSpan.FromDays(3));
            course.AddLesson("Урок2", "его описание", DateTime.Now + TimeSpan.FromDays(1));
            course.AddLesson("Урок3", "его описание", DateTime.Now + TimeSpan.FromDays(5));
            Lesson lesson = course.GetCurrentLesson();
            course.StopCurrentLesson();
            lesson = course.GetCurrentLesson();
            course.StopCurrentLesson();
            lesson = course.GetCurrentLesson();
            course.RemoveLesson(lesson.Id);
            lesson = course.GetCurrentLesson();

        }
    }
}
