using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosUniversity.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            //otsib õpilasi
            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student {FirstMidName="Markus",LastName = "Nirgi",EnrollmentDate = DateTime.Parse("2022-09-01")},
                new Student { FirstMidName = "Virkus", LastName = "Uusküla", EnrollmentDate = DateTime.Parse("2022-09-01") },
                new Student { FirstMidName = "Juuli", LastName = "Virtsu", EnrollmentDate = DateTime.Parse("2022-09-01") },
                new Student { FirstMidName = "Maali", LastName = "Nirgi", EnrollmentDate = DateTime.Parse("2022-09-01") },
                new Student { FirstMidName = "Markus", LastName = "Nirgi", EnrollmentDate = DateTime.Parse("2022-09-01") },
                new Student { FirstMidName = "Markus", LastName = "Nirgi", EnrollmentDate = DateTime.Now },
            };
            foreach (Student s in students)
            { 
                context.Students.Add(s);
            }
            context.SaveChanges();



            var courses = new Course[]
            {
                new Course { Title = "Mathematics", Credits = 4 },
                new Course { Title = "History", Credits = 3 },
                new Course { Title = "Computer Science", Credits = 5 },
                new Course { Title = "Physics", Credits = 4 },
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }

            context.SaveChanges();


        }
    }
}





