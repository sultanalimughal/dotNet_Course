using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public struct Course
    {
        public Guid CourseId;
        public string Title;
        public int DurationInMonths;
        public string Description;
        public decimal Fee;
        public bool IsFeatured;
        public DateTime CreatedDate;
        public DateTime LaunchDate;
    }
}
