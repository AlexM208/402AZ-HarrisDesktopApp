using K4os.Compression.LZ4.Streams.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HarrisDesktopApp.Models
{
    internal class Materials
    {
        public int mm_materialID {  get; set; }
        public int mm_moduleID { get; set; }
        public string mm_materialName {  get; set; }
        public int mm_tID {  get; set; }
        public DateTime mm_mat_date_edit { get; set; }
        public byte[] mm_material_blob {  get; set; }
      
        //public string mm_tLname {  get; set; }
        //public string mm_tFname { get; set; } 
        
    }
}
