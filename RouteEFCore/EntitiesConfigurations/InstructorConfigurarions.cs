using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RouteEFCore.Entities;

namespace RouteEFCore.EntitiesConfigurations
{
    internal class InstructorConfigurarions : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> instructor)
        {
            instructor.HasKey(i => i.Id);

            instructor.Property(i => i.Id)
                      .UseIdentityColumn(202500 , 1);

            instructor.Property(i => i.Name)
                      .HasColumnType("varchar(50)");

            instructor.Property(i => i.Address)
                      .HasColumnType("varchar(50)");

            instructor.Property(i => i.Salary)
                      .HasColumnType("decimal(18,2)");


            instructor.Property(i => i.Bouns)
                      .HasColumnType("decimal(18,2)");


            instructor.Property(i => i.HourRate)
                      .HasColumnType("decimal(18,2)");

            instructor.HasOne(i => i.ManagedDepartment)
                      .WithOne(d => d.Manager)
                      .HasForeignKey<Department>(d => d.ManagerId);

            instructor.HasOne(i => i.WorkingDepartment)
                      .WithMany(d => d.Instructors)
                      .HasForeignKey(i => i.WorkingDepartmentId)
                      .OnDelete(DeleteBehavior.NoAction);

            instructor.HasMany(i => i.Instructor_Courses)
                      .WithOne(ic => ic.Instructor)
                      .HasForeignKey(ic => ic.InstructorId);
        }
    }
}
