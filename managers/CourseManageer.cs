class CourseManageer
{
    public List<Course> courses { get; set; } = new List<Course>();

    public void addCourse(Course course)
    {
        this.courses.Add(course);
    }

    public void courseLists()
    {
        if (courses.Count <= 0)
        {
            Console.WriteLine("Courses not added");
            return;
        }

        foreach (var item in courses)
        {
            Console.WriteLine($"Course {item.CourseName} Id is {item.CourseId}");
        }
    }
}