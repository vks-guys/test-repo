using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreDemoProject.Models
{
    public class ResponseFormatData
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public object Data { get; set; }
        public DateTime TimeStamp { get { return DateTime.Now; } }
        public object Error { get; set; }

    }
}
