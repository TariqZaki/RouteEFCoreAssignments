using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RouteEFCore.Entities;

namespace RouteEFCore.EntitiesConfigurations
{
    internal class SrudentCourseConfigurations : IEntityTypeConfiguration<Student_Course>
    {
        public void Configure(EntityTypeBuilder<Student_Course> studentcourse)
        {
            studentcourse.HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
    }
}
