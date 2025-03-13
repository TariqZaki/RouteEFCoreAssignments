using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RouteEFCore.Entities;

namespace RouteEFCore.EntitiesConfigurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> department)
        {
            department.HasKey(d => d.Id);

            department.Property(d => d.Id)
                      .UseIdentityColumn(100 , 1);

            department.Property(d => d.Name)
                      .HasColumnType("varchar(50)");

            department.Property(d => d.HiringDate)
                      .HasDefaultValueSql("getdate()");

            department.HasMany(d => d.Students)
                      .WithOne(s => s.Department)
                      .HasForeignKey(s => s.DepartmentId);
        }
    }
}
