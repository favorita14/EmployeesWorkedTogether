using Models.CsvReaderClass;
using Models.Employees;
using System;

namespace EmployeesWorkedTogether
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter the path to the CSV file:");
			string filePath = Console.ReadLine();

			try
			{
				var longestWorkedTogetherFinder = new LongestWorkedTogetherFinder(new CsvHelperReader());
				var longestPair = longestWorkedTogetherFinder.FindLongestWorkedTogetherPair(filePath);
				Console.WriteLine($"Employee ID #1: {longestPair.Item1.EmpID}, Employee ID #2: {longestPair.Item2.EmpID}, Days Worked: {longestPair.Item3}");
			}
			catch (Exception)
			{
				Console.WriteLine("Something is wrong with this file!");
			}
		}
	}
}
