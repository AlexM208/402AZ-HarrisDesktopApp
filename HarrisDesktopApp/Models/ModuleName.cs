//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisDesktopApp.Models
{
    internal class ModuleName : Course
    {

        public int xm_moduleId { get; set; }
        public string xm_moduleName { get; set; }
        public string xm_cw1_pass_fail {  get; set; }
        public string xm_cw2_mark {  get; set; } // int


    }
}
