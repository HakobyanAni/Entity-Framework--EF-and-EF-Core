using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databse_First_EF
{
    public partial class Stage
    {
        public Stage(string name, Nullable<int> price, int duration__month_, string language, Trainer trainer, ProgrammingCourses programmingCours, ClassRoom classRoom)
        {
            Name = name;
            Price = price;
            Duration__month_ = duration__month_;
            Language = language;
            this.Students = new HashSet<Student>(); 
            Trainer = trainer;
            ProgrammingCours = programmingCours;
            ClassRoom = classRoom;
        }
    }
}
