using Microsoft.EntityFrameworkCore;
using RouteEFCore.DbContexts;
using RouteEFCore.Entities;

namespace RouteEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           using ITIDbContext context = new ITIDbContext();

            #region CRUD - Insert
            Instructor instructor = new Instructor { Name = "Tariq", Bouns = 1000, Salary = 10000, HourRate = 100, Address = "Beni-Suef, Egypt" };
            Console.WriteLine(context.Entry<Instructor>(instructor).State); //Detached
            #region Ways of Add
            // 4 ways to add 
            // 1. context.Add(instructor)
            // 2. context.Entry(instructor).state = EntityState.Added
            // 3. context.Instructor.Add(instructor)
            // 4. context.set<Instructor>().Add(instructor) 
            #endregion

            //context.Instructors.Add(instructor);
            //context.SaveChanges();

            Department department = new Department { Name = "Backend", ManagerId = 202506 };
            //context.Departments.Add(department);
            //context.SaveChanges();
            #endregion

            #region CRUD - Select
            Instructor instructor1 = context.Instructors.FirstOrDefault(i => i.Id == 202506);
            if (instructor1 is not null)
            {
                Console.WriteLine($"name ={instructor1.Name} , salary = {instructor1.Salary}");
            }
            #endregion

            #region CRUD - Update
            instructor1.Name = "Tariq Zaki";

            Console.WriteLine(context.Entry(instructor1).State); //Modified

            context.SaveChanges();
            Console.WriteLine(context.Entry(instructor1).State); //Unchanged
            #endregion

            #region CRUD - Delete
            Console.WriteLine(context.Entry(instructor1).State); //Unchanged
            context.Instructors.Remove(instructor1);
            Console.WriteLine(context.Entry(instructor1).State); //Deleted
            context.SaveChanges();
            Console.WriteLine(context.Entry(instructor1).State); //Detached
            #endregion


        }
    }
}
