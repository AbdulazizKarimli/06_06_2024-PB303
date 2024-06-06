namespace Task;

public class Group
{
    private int studentLimit;

    public string No { get; set; }
    public int StudentLimit
    {
        get => studentLimit;
        set
        {
            if (value >= 2 && value <= 18)
                studentLimit = value;
        }
    }

    public Student[] students /*= new Student[0]*/;

    public Group()
    {
        students = new Student[0];
    }

    public void AddStudent(Student student)
    {
        if (students.Length < StudentLimit)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
            Console.WriteLine("Elave olundu!");
        }
        else
        {
            Console.WriteLine("Sinif doludu!");
        }
    }
}