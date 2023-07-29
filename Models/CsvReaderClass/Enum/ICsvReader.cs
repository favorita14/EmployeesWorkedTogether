using Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CsvReaderClass.Enum
{
	public interface ICsvReader
	{
		List<Employee> ReadEmployeesFromCsv(string filePath);
	}
}
