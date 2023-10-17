using Microsoft_Studio.Models;
using System;
using System;
using System.Linq;
namespace Microsoft_Studio.Data
{
    public class DbInitializer
    {
        public static void Initialize(CompanyContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var businesses = new Business[]
            {
            new Business{BusinessId="Carson",EmpId="Alexander",ProdId=6, ProdComments=""},
            new Business{BusinessId="Meredith",EmpId="Alonso",ProdId=9, ProdComments="" },
            new Business{BusinessId="Arturo",EmpId="Anand",ProdId=3, ProdComments=""},
            new Business{BusinessId="Gytis",EmpId="Barzdukas",ProdId=8, ProdComments=""},
            new Business{BusinessId="Yan",EmpId="Li",ProdId=5, ProdComments=""},
            new Business{BusinessId="Peggy",EmpId="Justice",ProdId=1, ProdComments=""},
            new Business{BusinessId="Laura",EmpId="Norman",ProdId=7, ProdComments=""},
            new Business{BusinessId="Nino",EmpId="Olivetto",ProdId=4, ProdComments=""}
            new Business{BusinessId="Carson",EmpId="Alexander",ProdId=2, ProdComments=""},

            };
            foreach (Business b in businessess)
            {
                context.Businesses.Add(b);
            }
            context.SaveChanges();

            var product = new Course[]
            {
            new Product{ProdNum=01,ProdQuantity=250},
            new Product{ProdNum=02, ProdQuantity=132},
            new Product{ProdNum=03,ProdQuantity=325},
            new Product{ProdNum=04,ProdQuantity=741},
            new Product{ProdNum=05,ProdQuantity=576},
            new Product{ProdNum=06,ProdQuantity=968},
            new Product{ProdNum=07,ProdQuantity=403}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var employees = new Employee[]
            {
            new Employee{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Employee{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Employee{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Employee{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Employee{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Employee{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Employee{StudentID=3,CourseID=1050},
            new Employee{StudentID=4,CourseID=1050},
            new Employee{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Employee{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Employee{StudentID=6,CourseID=1045},
            new Employee{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Employee e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}