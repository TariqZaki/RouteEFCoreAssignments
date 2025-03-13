namespace RouteEFCore.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        public Instructor Manager { get; set; }
        public int ManagerId { get; set; }
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    } 
}
