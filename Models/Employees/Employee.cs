using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Employees
{
	public class Employee
	{
		public int EmpID { get; set; }
		public int ProjectID { get; set; }
		public DateTime DateFrom { get; set; }
		public string DateTo { get; set; }
	}
}
