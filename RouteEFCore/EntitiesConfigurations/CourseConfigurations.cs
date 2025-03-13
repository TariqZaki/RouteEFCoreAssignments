using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RouteEFCore.Entities;

namespace RouteEFCore.EntitiesConfigurations
{
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> course)
        {
            course.HasOne(c => c.Topic)
                  .WithMany(t => t.Courses)
                  .HasForeignKey(c => c.TopicId);

            course.HasMany(c => c.Student_Courses)
                  .WithOne(sc => sc.Course)
                  .HasForeignKey(sc => sc.CourseId);

            course.HasMany(c => c.Instructor_Courses)
                  .WithOne(ic => ic.Course)
                  .HasForeignKey(ic => ic.CourseId);
        }
    }
}
