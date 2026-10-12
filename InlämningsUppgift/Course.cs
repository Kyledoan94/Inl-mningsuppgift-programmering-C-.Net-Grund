namespace InlämningsUppgift;


public enum CourseType
    {
        Classroom,
        Distance
    }

public class Course
    {
        public string CourseNumber {get; set;} = "";
        public string CourseName {get; set;} = "";
        public int LengthInWeeks {get; set;} 
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}
        public CourseType Type {get; set;}

        public override string ToString()
        {
           return $"{CourseNumber} {CourseName} {LengthInWeeks} Veckor {StartDate:yyyy-MM-dd} {EndDate:yyyy-MM-dd} {Type} ";
        }

        
    }