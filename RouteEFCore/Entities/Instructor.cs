namespace RouteEFCore.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bouns { get; set; }
        public double HourRate { get; set; }
        public string Address { get; set; }
        public Department? ManagedDepartment { get; set; }
        public Department WorkingDepartment { get; set; }
        public int? WorkingDepartmentId { get; set; }
        public ICollection<Instructor_Course> Instructor_Courses { get; set; } = new HashSet<Instructor_Course>();
    } 
}
