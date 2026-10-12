namespace InlämningsUppgift;
public class Teacher : Person
{
    public string SkillsArea { get; set; } = "";
    public List<Course> ResponsibleCourses { get;} = new List<Course>();
    public override string ToString()
    {
        string courseText = string.Join("\n", ResponsibleCourses);
        return base.ToString() + $"\n Kunskapsområde: {SkillsArea}\n Ansvariga kurser:\n {courseText}";
    }

}