
class StudentManager
{
    public List<Student> students = new List<Student>();
    private List<Course> courses;

    public StudentManager(List<Course> courses)
    {
        this.courses = courses;
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void listStudents()

    {
        if (students.Count <= 0)
        {
            throw new InvalidOperationException("Students not added");
        }

        foreach (var item in students)
        {
            Console.WriteLine($"Student {item.Name} Id is {item.Id} Age is {item.Age}");
        }
    }

    public void updateStudent(int id, Student newStudent)
    {
        var student = students.FirstOrDefault(p => p.Id == id);
        if (student == null)
        {
            throw new InvalidOperationException($"{id} Student not added");
        }
        Console.WriteLine(student.Name);

        student.Name = newStudent.Name;
        student.Age = newStudent.Age;
    }

    public void deleteStudent(int id)
    {
        var student = students.FirstOrDefault(p => p.Id == id);
        if (student == null)
        {
            throw new InvalidOperationException($"{id} Student not added");
        }
        Console.WriteLine(student.Name);

        students.Remove(student);
    }

    public void filterStudentsAboveCertainAge(int age)
    {
        var stds = students.Where(student => student.Age > age);

        foreach (var item in stds)
        {
            Console.WriteLine(item.Name);
        }
    }

    public void filterStudentsUnderSpecificCourse()
    {
        foreach (var student in students)
        {
            var course = courses.FirstOrDefault(p => p.CourseId == student.CourseId);
            Console.WriteLine($"Student {student.Name} Enrolled {course?.CourseName ?? "Not Enrolled"}");
        }
    }
}