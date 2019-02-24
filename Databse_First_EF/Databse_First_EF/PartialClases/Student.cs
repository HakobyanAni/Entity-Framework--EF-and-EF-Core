using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databse_First_EF
{
    public partial class Student
    {
        public Student(string firstName, string lastName, Nullable<System.DateTime> birthDate, int mark)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Mark = mark;
        }
    }
}
