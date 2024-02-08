using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisDesktopApp.Models
{
    internal class Timetable
    {
        public int xt_timetableID {  get; set; }
        public int xt_moduleID {  get; set; }
        public string xt_moduleName { get; set; }
        public double xt_classRoom {  get; set; }
        public string xt_classFloor {  get; set; }
        public string xt_classBuilding { get; set; }
        public string xt_tLname { get; set; }
        public string xt_tFname {  get; set; }
        public string xt_classHours { get; set;}
    }
}
