using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.AbstractionUserCase
{
    public abstract class Assignment
    {
        public abstract decimal Marks { get; set; }
        //What to do?
        public abstract void PerformAssignment();

        public virtual decimal AssignmentMarks(decimal _marks)
        {
            return this.Marks =  _marks;
        }
    }
}
