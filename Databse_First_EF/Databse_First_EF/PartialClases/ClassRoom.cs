using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databse_First_EF
{
    public partial class ClassRoom
    {
        public ClassRoom(string name, Nullable<int> count_of_computers)
        {
            Name = name;
            Count_of_computers = count_of_computers;
            this.Stages = new HashSet<Stage>();
        }
    }
}
