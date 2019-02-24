using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databse_First_EF
{
    public partial class Trainer
    {
        public Trainer(string firstName, string lastName, string language)
        {
            FirstName = firstName;
            LastName = lastName;
            Language = language;
            this.Stages = new HashSet<Stage>();
        }
    }
}
