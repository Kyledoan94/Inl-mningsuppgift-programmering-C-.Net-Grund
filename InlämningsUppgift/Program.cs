namespace InlämningsUppgift;

class Program
{
    static void Main()
    {
        var school = new School();
        
        var csharp = new Course
        {
            CourseNumber = "C#101",CourseName = "C# Basics", LengthInWeeks = 6,
            StartDate = new DateTime(2026, 1, 16), EndDate = new DateTime(2026, 02, 27),
            Type = CourseType.Classroom
        };

        var java = new Course
        {
            CourseNumber = "J101", CourseName = "Java Basics", LengthInWeeks = 8,
            StartDate = new DateTime(2026, 03, 02), EndDate = new DateTime(2026, 4, 24),
            Type = CourseType.Distance
        };
        school.AddCourse(csharp);
        school.AddCourse(java);

        var student = new Student
        {
            FirstName="Micky", LastName = "Mouse", PhoneNumber = "070-1111111", PersonalNumber = "111111-1111",
            HomeAddress = { Street = "Mickesvägen 1", PostalCode = "11111", City = "Mickeystad"}
        };
        student.Enroll(csharp);
        student.Enroll(csharp);
        student.Enroll(java);
        school.AddStudent(student);

        var teacher = new Teacher
        {
            FirstName = "Minnie", LastName = "Mouse", PhoneNumber = "070-2222222", PersonalNumber = "222222-2222",
            HomeAddress = { Street = "Minniesvägen 2", PostalCode = "22222", City = "Minniestad"},
            SkillsArea = "C# och Java" 
        };
        teacher.ResponsibleCourses.Add(csharp);

        var leader = new EducationLeader
        {
            FirstName = "Donald", LastName = "Duck", PhoneNumber = "070-3333333", PersonalNumber = "333333-3333",
            HomeAddress = { Street = "Donaldsvägen 3", PostalCode = "33333", City = "Donaldstad"},
            SkillsArea = "Utbildning", EmploymentDate = new DateTime(2026, 1, 1)
        };

        var admin = new Administrator
        {
            FirstName = "Pluto", LastName = "Dog", PhoneNumber = "070-4444444", PersonalNumber = "444444-4444",
            HomeAddress = {Street = "Plutosvägen 1", PostalCode = "44444", City = "Plutostad"},
            SkillsArea = "Administration", EmploymentDate = new DateTime (2026, 1, 1)
        };
        
        school.Addteacher(teacher);
        school.Addteacher(leader);
        school.Addteacher(admin);

        Console.WriteLine ("---Kurser---");
        school.Listcourses();

        Console.WriteLine("\n---Studenter---");
        school.ListStudents();

        Console.WriteLine("\n--- Student (detaljer) ---");
        Console.WriteLine(student);
        
        Console.WriteLine("\n--- Lärare, utbildningsledare, administratör ---");
        foreach (Teacher t in school.Teachers)
        {
            Console.WriteLine(t);
        }
    }
}
  