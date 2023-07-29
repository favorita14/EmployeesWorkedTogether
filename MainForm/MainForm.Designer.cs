
namespace MainForm
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.OpenCSVFile = new System.Windows.Forms.Button();
			this.resultDataGridView = new System.Windows.Forms.DataGridView();
			this.EmpID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmpID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DaysWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// OpenCSVFile
			// 
			this.OpenCSVFile.Location = new System.Drawing.Point(672, 215);
			this.OpenCSVFile.Name = "OpenCSVFile";
			this.OpenCSVFile.Size = new System.Drawing.Size(143, 107);
			this.OpenCSVFile.TabIndex = 0;
			this.OpenCSVFile.Text = "Open CSV file";
			this.OpenCSVFile.UseVisualStyleBackColor = true;
			this.OpenCSVFile.Click += new System.EventHandler(this.OpenCSVFile_Click);
			// 
			// dataGridView1
			// 
			this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.resultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID1,
            this.EmpID2,
            this.ProjectID,
            this.DaysWorked});
			this.resultDataGridView.Location = new System.Drawing.Point(0, 0);
			this.resultDataGridView.Name = "dataGridView1";
			this.resultDataGridView.RowHeadersWidth = 62;
			this.resultDataGridView.RowTemplate.Height = 33;
			this.resultDataGridView.Size = new System.Drawing.Size(666, 537);
			this.resultDataGridView.TabIndex = 1;
			// 
			// EmpID1
			// 
			this.EmpID1.HeaderText = "Employee ID #1";
			this.EmpID1.MinimumWidth = 8;
			this.EmpID1.Name = "EmpID1";
			this.EmpID1.Width = 150;
			// 
			// EmpID2
			// 
			this.EmpID2.HeaderText = "Employee ID #2";
			this.EmpID2.MinimumWidth = 8;
			this.EmpID2.Name = "EmpID2";
			this.EmpID2.Width = 150;
			// 
			// ProjectID
			// 
			this.ProjectID.HeaderText = "Project ID";
			this.ProjectID.MinimumWidth = 8;
			this.ProjectID.Name = "ProjectID";
			this.ProjectID.Width = 150;
			// 
			// DaysWorked
			// 
			this.DaysWorked.HeaderText = "Days worked";
			this.DaysWorked.MinimumWidth = 8;
			this.DaysWorked.Name = "DaysWorked";
			this.DaysWorked.Width = 150;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 540);
			this.Controls.Add(this.resultDataGridView);
			this.Controls.Add(this.OpenCSVFile);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button OpenCSVFile;
		private System.Windows.Forms.DataGridView resultDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmpID1;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmpID2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
		private System.Windows.Forms.DataGridViewTextBoxColumn DaysWorked;
	}
}

