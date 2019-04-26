namespace ProductionServicesAnalyticsProgram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.submitButton = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.analysisTypeLabel = new System.Windows.Forms.Label();
            this.analysisTypeListBox = new System.Windows.Forms.ListBox();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.analysisTypeCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalHoursLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.excelExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.overtimeCheck = new System.Windows.Forms.Button();
            this.hoursCheck = new System.Windows.Forms.Button();
            this.checkerListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(695, 152);
            this.submitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(369, 168);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(34, 176);
            this.startDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(644, 44);
            this.startDate.TabIndex = 2;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(34, 272);
            this.endDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(644, 44);
            this.endDate.TabIndex = 3;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(25, 109);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(170, 37);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(34, 229);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(150, 37);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date";
            // 
            // analysisTypeLabel
            // 
            this.analysisTypeLabel.AutoSize = true;
            this.analysisTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisTypeLabel.Location = new System.Drawing.Point(120, 348);
            this.analysisTypeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.analysisTypeLabel.Name = "analysisTypeLabel";
            this.analysisTypeLabel.Size = new System.Drawing.Size(335, 55);
            this.analysisTypeLabel.TabIndex = 9;
            this.analysisTypeLabel.Text = "Analysis Type:";
            // 
            // analysisTypeListBox
            // 
            this.analysisTypeListBox.FormattingEnabled = true;
            this.analysisTypeListBox.ItemHeight = 37;
            this.analysisTypeListBox.Location = new System.Drawing.Point(42, 579);
            this.analysisTypeListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.analysisTypeListBox.Name = "analysisTypeListBox";
            this.analysisTypeListBox.Size = new System.Drawing.Size(511, 152);
            this.analysisTypeListBox.TabIndex = 10;
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 37;
            this.nameListBox.Location = new System.Drawing.Point(42, 746);
            this.nameListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(511, 337);
            this.nameListBox.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(570, 348);
            this.chart1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1702, 738);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // analysisTypeCheckBoxList
            // 
            this.analysisTypeCheckBoxList.CheckOnClick = true;
            this.analysisTypeCheckBoxList.FormattingEnabled = true;
            this.analysisTypeCheckBoxList.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.analysisTypeCheckBoxList.Location = new System.Drawing.Point(42, 407);
            this.analysisTypeCheckBoxList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.analysisTypeCheckBoxList.Name = "analysisTypeCheckBoxList";
            this.analysisTypeCheckBoxList.Size = new System.Drawing.Size(511, 121);
            this.analysisTypeCheckBoxList.TabIndex = 13;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1077, 152);
            this.updateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(369, 168);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update Chart";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1311, 73);
            this.label1.TabIndex = 15;
            this.label1.Text = "Virginia Tech Production Services Analytics";
            // 
            // totalHoursLabel
            // 
            this.totalHoursLabel.AutoSize = true;
            this.totalHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursLabel.Location = new System.Drawing.Point(882, 1116);
            this.totalHoursLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalHoursLabel.Name = "totalHoursLabel";
            this.totalHoursLabel.Size = new System.Drawing.Size(411, 73);
            this.totalHoursLabel.TabIndex = 16;
            this.totalHoursLabel.Text = "Total Hours: ";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(1699, 189);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(487, 44);
            this.usernameBox.TabIndex = 17;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(1699, 248);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(487, 44);
            this.passwordBox.TabIndex = 18;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1512, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1522, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password";
            // 
            // excelExport
            // 
            this.excelExport.Location = new System.Drawing.Point(42, 1097);
            this.excelExport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.excelExport.Name = "excelExport";
            this.excelExport.Size = new System.Drawing.Size(515, 98);
            this.excelExport.TabIndex = 21;
            this.excelExport.Text = "Export to Excel";
            this.excelExport.UseVisualStyleBackColor = true;
            this.excelExport.Click += new System.EventHandler(this.excelExport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 1097);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 98);
            this.button1.TabIndex = 22;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2114, 1682);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "Version 1.0.0";
            // 
            // overtimeCheck
            // 
            this.overtimeCheck.Location = new System.Drawing.Point(64, 1215);
            this.overtimeCheck.Name = "overtimeCheck";
            this.overtimeCheck.Size = new System.Drawing.Size(183, 121);
            this.overtimeCheck.TabIndex = 25;
            this.overtimeCheck.Text = "Overtime Check";
            this.overtimeCheck.UseVisualStyleBackColor = true;
            this.overtimeCheck.Click += new System.EventHandler(this.OvertimeCheck_Click);
            // 
            // hoursCheck
            // 
            this.hoursCheck.Location = new System.Drawing.Point(282, 1215);
            this.hoursCheck.Name = "hoursCheck";
            this.hoursCheck.Size = new System.Drawing.Size(185, 121);
            this.hoursCheck.TabIndex = 26;
            this.hoursCheck.Text = "Hours Check";
            this.hoursCheck.UseVisualStyleBackColor = true;
            this.hoursCheck.Click += new System.EventHandler(this.HoursCheck_Click);
            // 
            // checkerListView
            // 
            this.checkerListView.AutoArrange = false;
            this.checkerListView.GridLines = true;
            this.checkerListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.checkerListView.Location = new System.Drawing.Point(519, 1237);
            this.checkerListView.Name = "checkerListView";
            this.checkerListView.Size = new System.Drawing.Size(836, 442);
            this.checkerListView.TabIndex = 27;
            this.checkerListView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(2324, 1719);
            this.Controls.Add(this.checkerListView);
            this.Controls.Add(this.hoursCheck);
            this.Controls.Add(this.overtimeCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.excelExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.totalHoursLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.analysisTypeCheckBoxList);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.analysisTypeListBox);
            this.Controls.Add(this.analysisTypeLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.submitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Production Services Analytics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label analysisTypeLabel;
        private System.Windows.Forms.ListBox analysisTypeListBox;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckedListBox analysisTypeCheckBoxList;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalHoursLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button excelExport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button overtimeCheck;
        private System.Windows.Forms.Button hoursCheck;
        private System.Windows.Forms.ListView checkerListView;
    }
}

