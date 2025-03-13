using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RouteEFCore.Entities;

namespace RouteEFCore.EntitiesConfigurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> student)
        {
            student.Property(s => s.FName)
                   .HasColumnType("varchar(50)");

            student.Property(s => s.LName)
                   .HasColumnType("varchar(50)");

            student.HasMany(s => s.Student_Courses)
                   .WithOne(sc => sc.Student)
                   .HasForeignKey(sc => sc.StudentId);

        }
    }
}
