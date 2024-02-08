using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisDesktopApp.Models
{
    internal class Materials
    {
        public int mm_materialID {  get; set; }
        public int mm_moduleID { get; set; }
        public string mm_moduleName {  get; set; }
        public int mm_tID {  get; set; }
        public DateTime mm_mat_date_edit { get; set; }
        public string mm_tLname {  get; set; }
        public string mm_tFname { get; set; } 
        
    }
}
