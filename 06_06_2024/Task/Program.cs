using Task;

Student student1 = new Student()
{
    Name = "Rizvan",
    Surname = "Veliyev",
    AvgPoint = 78
};

Student student2 = new Student()
{
    Name = "Ismayil",
    Surname = "Aliyev",
    AvgPoint = 0
};

Student student3 = new Student()
{
    Name = "Fatime",
    Surname = "Veliyeva",
    AvgPoint = 10
};

Group group = new Group()
{
    No = "PB303",
    StudentLimit = 2
};

group.AddStudent(student1);
group.AddStudent(student2);
group.AddStudent(student3);

foreach (var item in group.students)
{
    Console.WriteLine(item.GetInfo());
}