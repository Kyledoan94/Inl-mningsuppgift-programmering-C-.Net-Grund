namespace InlämningsUppgift;
public class Student : Person
{
    public List<Course> Courses { get; } = new List<Course>();
    public void Enroll(Course course)
    {
        if (Courses.Contains(course))
        {
            Console.WriteLine($"Du är redan inskriven på {course.CourseName}.");
            return;
        }
        Courses.Add(course);
    }

    public override string ToString()
    {
        string courseText = string.Join("\n",Courses);
        return base.ToString() + $"\n Kurser:\n {courseText}";
    }
}