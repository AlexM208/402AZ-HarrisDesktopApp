using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisDesktopApp.Models
{
    internal class CourseList //: Course
    {
        public string xc_courseName { get; set; }
        public string xc_normal_Accelerated { get; set;}
        public int courseID { get; set; }
        public string courseCode { get; set; }

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
