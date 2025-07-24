using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AprilBatchMVCProject.Models
{
	public class Emp
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Dept { get; set; }
        public double Salary { get; set; }
    }
}