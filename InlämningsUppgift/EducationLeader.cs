namespace InlämningsUppgift;
public class EducationLeader : Teacher
{
    public DateTime EmploymentDate { get; set; }
    public override string ToString()
    {
        return base.ToString() + $"\n Anställd: {EmploymentDate:yyyy-MM-dd}";
    }
}