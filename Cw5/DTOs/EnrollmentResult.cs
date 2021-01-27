using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw5.Models;

namespace Cw5.DTOs
{
    public class EnrollmentResult
    {
        public bool Successful { get; set; }
        public Student Student { get; set; }
        public Enrolled Enrolled { get; set; }
        public string Error { get; set; }
    }
}