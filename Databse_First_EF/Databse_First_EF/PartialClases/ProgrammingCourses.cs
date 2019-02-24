using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databse_First_EF
{
    public partial class ProgrammingCourses
    {
        public ProgrammingCourses(string name)
        {
            Name = name;
            this.Stages = new HashSet<Stage>();
        }
    }
}
