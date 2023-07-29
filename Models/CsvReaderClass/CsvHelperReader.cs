using CsvHelper.Configuration;
using Models.CsvReaderClass.Enum;
using Models.Employees;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Models.CsvReaderClass
{
	public class CsvHelperReader : ICsvReader
    {
        public List<Employee> ReadEmployeesFromCsv(string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                HeaderValidated = null,
                MissingFieldFound = null,
            };

			using var reader = new StreamReader(filePath);
			using var csv = new CsvReader(reader, config);
			return csv.GetRecords<Employee>().ToList();
		}
    }
}
