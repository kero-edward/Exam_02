using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    internal abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestion { get; set; }
        public Question[] Questions { get; set; }
        public abstract void ShowExam();

    }
}
