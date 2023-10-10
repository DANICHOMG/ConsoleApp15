
public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Year { get; set; }
}
public class Teacher
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Subject { get; set; }
}
public class Subjects
{
    public string first { get; set; }
    public DateTime whenfirst { get; set; }
    public string second { get; set; }
    public DateTime whensecond { get; set; }
    public string third { get; set; }
    public DateTime whenthird { get; set; }
}
public class School
{
    public int NumberOfSchool { get; set; }
    public string Adress { get; set; }

    public List<Student> StudentList { get; set; }
    public List<Teacher> TeacherList { get; set; }
    public List<Subjects> SubjectsList { get; set; }

    public School()
    {
        StudentList = new List<Student>();
        TeacherList = new List<Teacher>();
        SubjectsList = new List<Subjects>();
    }
}

class Program
{
    static void Main(string[] args)
    {
    s:
        int s = 0;
        try
        {
            Console.WriteLine("Type your number of school:");
            s = int.Parse(Console.ReadLine());

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto s;
        }
    Adress:
        string Adress = null;
        try
        {
            Console.WriteLine("Type adress of school:");
            Adress = Console.ReadLine();

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto Adress;
        }



        School библиотека = new School
        {
            NumberOfSchool = s,
            Adress = Adress,
        };



    namestudent:
        string namestudent = null;
        try
        {
            Console.WriteLine("Type student`s name:");
            namestudent = Console.ReadLine();

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto namestudent;
        }
    surname:
        string surname = null;
        try
        {
            Console.WriteLine("Type student`s surname:");
            surname = Console.ReadLine();

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto surname;
        }
    yeear:
        int yeear = 0;
        try
        {
            Console.WriteLine("Type year of student:");
            yeear = int.Parse(Console.ReadLine());

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto yeear;
        }


        Student book1 = new Student
        {
            Name = namestudent,
            Surname = surname,
            Year = yeear,
        };
    nameteaher:
        string nameteaher = null;
        try
        {
            Console.WriteLine("Type teachers`s name:");
            nameteaher = Console.ReadLine();

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto nameteaher;
        }
    surname2:
        string surname2 = null;
        try
        {
            Console.WriteLine("Type teachers`s surname:");
            surname2 = Console.ReadLine();

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto surname2;
        }
    subject:
        string subject = null;
        try
        {
            Console.WriteLine("Type teachers`s subject:");
            subject = Console.ReadLine();

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto subject;
        }

        Teacher teacher = new Teacher
        {
            Name = nameteaher,
            Surname = surname2,
            Subject = subject,
        };
    first:
        string first = null;
        try
        {
            Console.WriteLine("Type first subject:");
            first = Console.ReadLine();

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto first;
        }
    whenfirst:
        DateTime whenfirst = new DateTime();
        try
        {
            Console.WriteLine("When this subject:");
            whenfirst = DateTime.Parse(Console.ReadLine());

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto whenfirst;
        }
    second:
        string second = null;
        try
        {
            Console.WriteLine("Type second subject:");
            second = Console.ReadLine();

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto second;
        }
    whensecond:
        DateTime whensecond = new DateTime();
        try
        {
            Console.WriteLine("When this subject:");
            whensecond = DateTime.Parse(Console.ReadLine());

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto whensecond;
        }
    third:
        string third = null;
        try
        {
            Console.WriteLine("Type third subject:");
            third = Console.ReadLine();

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto third;
        }
    whenthird:
        DateTime whenthird = new DateTime();
        try
        {
            Console.WriteLine("When this subject:");
            whenthird = DateTime.Parse(Console.ReadLine());

        }
        catch (Exception e)
        {
            Console.WriteLine("Wrong format");
            goto whenthird;
        }

        Subjects subjects = new Subjects
        {
            first = first,
            whenfirst = whenfirst,
            second = second,
            whensecond = whensecond,
            third = third,
            whenthird = whenthird,
        };


        библиотека.StudentList.Add(book1);
        библиотека.TeacherList.Add(teacher);
        библиотека.SubjectsList.Add(subjects);

   
        Console.WriteLine($"");
        Console.WriteLine($"----------------------");
        Console.WriteLine($"");
        Console.WriteLine($"Number of School: {библиотека.NumberOfSchool}");
        Console.WriteLine($"Adress of School: {библиотека.Adress}");
        Console.WriteLine($"");

        Console.WriteLine("Student:");
        foreach (var books in библиотека.StudentList)
        {
            Console.WriteLine($"- {books.Name} {books.Surname}, {books.Year}");
        }
        Console.WriteLine($"");
        Console.WriteLine("Teacher:");
        foreach (var books in библиотека.TeacherList)
        {
            Console.WriteLine($"- {books.Name} {books.Surname}, {books.Subject}");
        }
        Console.WriteLine($"");
        Console.WriteLine("Subjects:");
        foreach (var books in библиотека.SubjectsList)
        {
            Console.WriteLine($"1. {books.first}, {books.whenfirst}");
            Console.WriteLine($"2. {books.second}, {books.whensecond}");
            Console.WriteLine($"3. {books.third}, {books.whenthird}");
        }
    }
}