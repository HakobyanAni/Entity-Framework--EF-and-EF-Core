using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databse_First_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DB_For_DbFirstEntities db = new DB_For_DbFirstEntities())
            {
                ClassRoom classRoom1 = new ClassRoom("Create", 24);
                Trainer trainer1 = new Trainer("Vanik", "Hakobyan", "C#");
                Score score1 = new Score(9, 9, 9, 9);
                ProgrammingCourses programmingCourses1 = new ProgrammingCourses("C# Bootcamp");
                Student student1 = new Student("Ani", "Hakobyan", DateTime.Now.AddYears(-24), 9);
                Stage stage1 = new Stage("Advance", 40000, 1, "C#", trainer1, programmingCourses1, classRoom1);

                db.Stages.Add(stage1);
                stage1.Students.Add(student1);
                student1.Score = score1;

                db.SaveChanges();

                Console.ReadKey();
            }
        }
    }
}
