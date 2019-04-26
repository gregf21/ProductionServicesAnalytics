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
            this.components = new System.ComponentModel.Container();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(219, 53);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(117, 59);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(11, 62);
            this.startDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(206, 20);
            this.startDate.TabIndex = 2;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(11, 96);
            this.endDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(206, 20);
            this.endDate.TabIndex = 3;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(8, 38);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(11, 81);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date";
            // 
            // analysisTypeLabel
            // 
            this.analysisTypeLabel.AutoSize = true;
            this.analysisTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisTypeLabel.Location = new System.Drawing.Point(38, 122);
            this.analysisTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.analysisTypeLabel.Name = "analysisTypeLabel";
            this.analysisTypeLabel.Size = new System.Drawing.Size(109, 20);
            this.analysisTypeLabel.TabIndex = 9;
            this.analysisTypeLabel.Text = "Analysis Type:";
            // 
            // analysisTypeListBox
            // 
            this.analysisTypeListBox.FormattingEnabled = true;
            this.analysisTypeListBox.Location = new System.Drawing.Point(13, 203);
            this.analysisTypeListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.analysisTypeListBox.Name = "analysisTypeListBox";
            this.analysisTypeListBox.Size = new System.Drawing.Size(164, 56);
            this.analysisTypeListBox.TabIndex = 10;
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(13, 262);
            this.nameListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(164, 121);
            this.nameListBox.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(180, 122);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(537, 259);
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
            this.analysisTypeCheckBoxList.Location = new System.Drawing.Point(13, 143);
            this.analysisTypeCheckBoxList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.analysisTypeCheckBoxList.Name = "analysisTypeCheckBoxList";
            this.analysisTypeCheckBoxList.Size = new System.Drawing.Size(164, 49);
            this.analysisTypeCheckBoxList.TabIndex = 13;
            this.analysisTypeCheckBoxList.SelectedIndexChanged += new System.EventHandler(this.analysisTypeCheckBoxList_SelectedIndexChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(340, 53);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(117, 59);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update Chart";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Virginia Tech Production Services Analytics";
            // 
            // totalHoursLabel
            // 
            this.totalHoursLabel.AutoSize = true;
            this.totalHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursLabel.Location = new System.Drawing.Point(279, 392);
            this.totalHoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalHoursLabel.Name = "totalHoursLabel";
            this.totalHoursLabel.Size = new System.Drawing.Size(148, 26);
            this.totalHoursLabel.TabIndex = 16;
            this.totalHoursLabel.Text = "Total Hours: ";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(537, 66);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(157, 20);
            this.usernameBox.TabIndex = 17;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(537, 87);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(157, 20);
            this.passwordBox.TabIndex = 18;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password";
            // 
            // excelExport
            // 
            this.excelExport.Location = new System.Drawing.Point(13, 385);
            this.excelExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.excelExport.Name = "excelExport";
            this.excelExport.Size = new System.Drawing.Size(163, 34);
            this.excelExport.TabIndex = 21;
            this.excelExport.Text = "Export to Excel";
            this.excelExport.UseVisualStyleBackColor = true;
            this.excelExport.Click += new System.EventHandler(this.excelExport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Version 1.0.0";
            // 
            // overtimeCheck
            // 
            this.overtimeCheck.Location = new System.Drawing.Point(720, 339);
            this.overtimeCheck.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.overtimeCheck.Name = "overtimeCheck";
            this.overtimeCheck.Size = new System.Drawing.Size(128, 42);
            this.overtimeCheck.TabIndex = 25;
            this.overtimeCheck.Text = "Overtime Check";
            this.overtimeCheck.UseVisualStyleBackColor = true;
            this.overtimeCheck.Click += new System.EventHandler(this.OvertimeCheck_Click);
            // 
            // hoursCheck
            // 
            this.hoursCheck.Location = new System.Drawing.Point(857, 339);
            this.hoursCheck.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.hoursCheck.Name = "hoursCheck";
            this.hoursCheck.Size = new System.Drawing.Size(128, 42);
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
            this.checkerListView.Location = new System.Drawing.Point(720, 122);
            this.checkerListView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.checkerListView.Name = "checkerListView";
            this.checkerListView.Size = new System.Drawing.Size(267, 216);
            this.checkerListView.TabIndex = 27;
            this.checkerListView.UseCompatibleStateImageBehavior = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(720, 99);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(265, 21);
            this.progressBar1.TabIndex = 28;
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new System.Drawing.Point(717, 62);
            this.percentageLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(111, 13);
            this.percentageLabel.TabIndex = 29;
            this.percentageLabel.Text = "Data Grab Completion";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "CEP Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 443);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.progressBar1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Production Services Analytics";
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
    }
}

