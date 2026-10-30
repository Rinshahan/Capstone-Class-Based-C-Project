List<Course> courses = new List<Course>
{
    new Course {CourseId=1122, CourseName="Backend Engineer"},
    new Course {CourseId=2233, CourseName="Frontend Engineer"}
};


List<Student> students = new List<Student>
{
    new Student { Id = 1, Name = "Rinshahan", Age = 24, CourseId = 1122 },
    new Student { Id = 2, Name = "Anand", Age = 20, CourseId = 1122 },
    new Student { Id = 3, Name = "Anas", Age = 26, CourseId = 1122 },
    new Student { Id = 4, Name = "Fadi", Age = 24, CourseId = 2233 },
    new Student { Id = 5, Name = "Ameer", Age = 26, CourseId = 2233 },
    new Student { Id = 6, Name = "Akash", Age = 27, CourseId = 2233 }
};

var names = students.Select(p => p.Name);

//Create Course

CourseManageer course = new CourseManageer();

course.addCourse(new Course { CourseId = 1122, CourseName = "Backend Engineer" });
course.addCourse(new Course { CourseId = 2233, CourseName = "Frontend Engineer" });

course.courseLists();

Console.WriteLine();
Console.WriteLine("Following Students");
Console.WriteLine();

// Add Students
StudentManager student = new StudentManager(course.courses);

student.AddStudent(new Student { Id = 1, Name = "Rinshahan", Age = 24, CourseId = 1122 });
student.AddStudent(new Student { Id = 2, Name = "Anand", Age = 20, CourseId = 1122 });
student.AddStudent(new Student { Id = 3, Name = "Anas", Age = 26, CourseId = 1122 });
student.AddStudent(new Student { Id = 4, Name = "Fadi", Age = 24, CourseId = 2233 });
student.AddStudent(new Student { Id = 5, Name = "Ameer", Age = 26, CourseId = 2233 });
student.AddStudent(new Student { Id = 6, Name = "Akash", Age = 27, CourseId = 2233 });

student.listStudents();


Console.WriteLine();
Console.WriteLine("Deleting Students");
Console.WriteLine();
// deleting students;

// student.deleteStudent(6);
// Console.WriteLine();
// student.listStudents();


// update student
student.updateStudent(6,new Student { Id = 6, Name = "Akash Cs", Age = 43, CourseId = 2233 });
student.listStudents();

// Filter Students above a certain age.
Console.WriteLine();
student.filterStudentsAboveCertainAge(25);

//Filter students enrolled in a specific course
Console.WriteLine("Filter students enrolled in a specific course");
student.filterStudentsUnderSpecificCourse();