namespace RouteEFCore.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public Topic Topic { get; set; }
        public int TopicId { get; set; }
        public ICollection<Student_Course> Student_Courses { get; set; } = new HashSet<Student_Course>();
        public ICollection<Instructor_Course> Instructor_Courses { get; set; } = new HashSet<Instructor_Course>();

    }
}
