using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databse_First_EF
{
    public partial class Score
    {
        public Score(int activity, int github_performance, int knowledge_sharing, int homework)
        {
            Activity = activity;
            Github_performance = github_performance;
            Knowledge_sharing = knowledge_sharing;
            Homework = homework;
            this.Students = new HashSet<Student>();
        }
    }
}
