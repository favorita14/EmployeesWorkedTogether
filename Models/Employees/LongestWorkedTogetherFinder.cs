using Models.CsvReaderClass.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Employees
{
	public class LongestWorkedTogetherFinder
	{
        private readonly ICsvReader csvReader;

        public LongestWorkedTogetherFinder(ICsvReader csvReader)
        {
            this.csvReader = csvReader;
        }

        public Tuple<Employee, Employee, int> FindLongestWorkedTogetherPair(string filePath)
        {
            List<Employee> employees = csvReader.ReadEmployeesFromCsv(filePath);
            var employeePairs = new Dictionary<string, Tuple<Employee, Employee, int>>();

            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].ProjectID == employees[j].ProjectID)
                    {
                        string key = employees[i].EmpID < employees[j].EmpID
                            ? $"{employees[i].EmpID}-{employees[j].EmpID}"
                            : $"{employees[j].EmpID}-{employees[i].EmpID}";

                        if (!employeePairs.ContainsKey(key))
                            employeePairs[key] = Tuple.Create(employees[i], employees[j], 0);

                        int daysWorked = CalculateDaysWorked(employees[i], employees[j]);
                        employeePairs[key] = Tuple.Create(employeePairs[key].Item1, employeePairs[key].Item2, employeePairs[key].Item3 + daysWorked);
                    }
                }
            }

            return employeePairs.Values.OrderByDescending(pair => pair.Item3).FirstOrDefault();
        }

        static int CalculateDaysWorked(Employee emp1, Employee emp2)
        {
            DateTime? dateTo1 = DateTime.TryParse(emp1.DateTo, out DateTime dateTime) ? dateTime : DateTime.Today;
            DateTime? dateTo2 = DateTime.TryParse(emp2.DateTo, out dateTime) ? dateTime : DateTime.Today;
            DateTime dateFrom = emp1.DateFrom > emp2.DateFrom ? emp1.DateFrom : emp2.DateFrom;
            DateTime dateTo = dateTo1 < dateTo2 ? dateTo1.Value : dateTo2.Value;

            TimeSpan duration = dateFrom > dateTo ? dateFrom - dateTo : dateTo - dateFrom;
            return duration.Days;
        }
    }
}
