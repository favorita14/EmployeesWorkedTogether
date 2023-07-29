using Models.CsvReaderClass;
using Models.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
	public partial class MainForm : Form
	{
		private readonly LongestWorkedTogetherFinder _longestWorkedTogetherFinder;

		public MainForm()
		{
			InitializeComponent();
			_longestWorkedTogetherFinder = new LongestWorkedTogetherFinder(new CsvHelperReader());
		}

		private void OpenCSVFile_Click(object sender, EventArgs e)
		{
			using (var openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = openFileDialog.FileName;
					var longestPair = _longestWorkedTogetherFinder.FindLongestWorkedTogetherPair(filePath);

					resultDataGridView.Rows.Clear();
					resultDataGridView.Rows.Add(longestPair.Item1.EmpID, longestPair.Item2.EmpID, longestPair.Item1.ProjectID, longestPair.Item3);
				}
			}
		}
	}
}
