using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisDesktopApp.Models
{
    public class Student : Person
    {
        public string ss_address { get; set; }
        public string ss_postcode { get; set; }
        public string ss_phone {  get; set; }
        public string ss_grade_CW2 { get; set;}
        public string ss_pass_fail { get; set;}
        public double ss_class_room {  get; set; }
    }
}
