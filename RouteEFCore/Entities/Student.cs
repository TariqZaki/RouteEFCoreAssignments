namespace RouteEFCore.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<Student_Course> Student_Courses { get; set; } = new HashSet<Student_Course>();

    }
}
