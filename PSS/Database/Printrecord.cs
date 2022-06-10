using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.Database
{
    public class Printrecord
    {
        public int Print_num { get; set; }
        public string Emp_name { get; set; }
        public int File_size { get; set; }
        public DateTime Log { get; set; }
        public string File_path { get; set; }
    }
}
