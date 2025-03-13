using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RouteEFCore.Entities;

namespace RouteEFCore.EntitiesConfigurations
{
    internal class InstructorCourseConfigurations : IEntityTypeConfiguration<Instructor_Course>
    {
        public void Configure(EntityTypeBuilder<Instructor_Course> inscourse)
        {
            inscourse.HasKey(ic => new { ic.CourseId , ic.InstructorId});
        }
    }
}
