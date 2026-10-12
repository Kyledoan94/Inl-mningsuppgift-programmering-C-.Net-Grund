namespace InlämningsUppgift;

public class School
{
    public List<Course> Courses { get; } = new List<Course>();
    public List<Student> Students { get; } = new List<Student>();
    public List<Teacher> Teachers { get; } = new List<Teacher>();

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    // Tar emot Teacher. EducationLeader (handledare) och Administrator ÄR Teacher
    // (arv), så samma metod lägger till alla tre. Inget behov av upprepad kod.
    public void Addteacher(Teacher teacher)
    {
        Teachers.Add(teacher);
    }

    public void Listcourses()
    {
        if (Courses.Count == 0)
        {
            Console.WriteLine("Inga kurser finns.");
            return;
        }

        foreach (Course course in Courses)
        {
            Console.WriteLine(course);
        }
    }

    public void ListStudents()
    {
        for (int i = 0; i < Students.Count; i ++)
        {
            Console.WriteLine($" {i + 1}. {Students[i].FirstName} {Students[i].LastName}");
        }
    }
}