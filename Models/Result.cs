using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOrgApp.Models
{
    public class Result
    {
        public bool Success { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }

        public string ErrorMessage { get; set; }
        public int ListCount { get; set; }
        public Object Data { get; set; }
    }
}
