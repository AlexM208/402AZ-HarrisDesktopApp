using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisDesktopApp.Models
{
    internal class Enrolment : Course
    {
        public int ee_enrolmentID { get; set; }
        public string ee_stLname { get; set; }
        public string ee_stFname { get; set; }
        public int ee_stId { get; set; }
        public string ee_courseName {  get; set; }
        public int ee_yearNumber { get; set; }
        public string ee_PT_FT { get; set; }


    }
}
