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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.submitButton = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.totalHoursLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.excelExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.overlapNameListBox = new System.Windows.Forms.ListBox();
            this.overtimeNameListBox = new System.Windows.Forms.ListBox();
            this.overtimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.overtimeCheckButton = new System.Windows.Forms.Button();
            this.overtimeInformationView = new System.Windows.Forms.ListBox();
            this.overlapInformationView = new System.Windows.Forms.ListBox();
            this.overlappingLabel = new System.Windows.Forms.Label();
            this.overtimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(342, 82);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(176, 91);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(20, 81);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(307, 26);
            this.startDate.TabIndex = 2;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(20, 140);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(307, 26);
            this.endDate.TabIndex = 3;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(16, 58);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(87, 20);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(16, 117);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(77, 20);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date";
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 20;
            this.nameListBox.Location = new System.Drawing.Point(20, 188);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(244, 404);
            this.nameListBox.TabIndex = 11;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(270, 188);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(806, 398);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Virginia Tech Production Services Analytics";
            // 
            // totalHoursLabel
            // 
            this.totalHoursLabel.AutoSize = true;
            this.totalHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursLabel.Location = new System.Drawing.Point(263, 603);
            this.totalHoursLabel.Name = "totalHoursLabel";
            this.totalHoursLabel.Size = new System.Drawing.Size(215, 37);
            this.totalHoursLabel.TabIndex = 16;
            this.totalHoursLabel.Text = "Total Hours: ";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(806, 102);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(234, 26);
            this.usernameBox.TabIndex = 17;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(806, 134);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(234, 26);
            this.passwordBox.TabIndex = 18;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password";
            // 
            // excelExport
            // 
            this.excelExport.Location = new System.Drawing.Point(20, 593);
            this.excelExport.Name = "excelExport";
            this.excelExport.Size = new System.Drawing.Size(244, 52);
            this.excelExport.TabIndex = 21;
            this.excelExport.Text = "Export to Excel";
            this.excelExport.UseVisualStyleBackColor = true;
            this.excelExport.Click += new System.EventHandler(this.excelExport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 875);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 52);
            this.button1.TabIndex = 22;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 907);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Version 1.0.0";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1080, 152);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(398, 32);
            this.progressBar1.TabIndex = 28;
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new System.Drawing.Point(1076, 95);
            this.percentageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(168, 20);
            this.percentageLabel.TabIndex = 29;
            this.percentageLabel.Text = "Data Grab Completion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(800, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "CEP Information";
            // 
            // overlapNameListBox
            // 
            this.overlapNameListBox.FormattingEnabled = true;
            this.overlapNameListBox.ItemHeight = 20;
            this.overlapNameListBox.Location = new System.Drawing.Point(1080, 233);
            this.overlapNameListBox.Name = "overlapNameListBox";
            this.overlapNameListBox.Size = new System.Drawing.Size(396, 124);
            this.overlapNameListBox.TabIndex = 32;
            this.overlapNameListBox.SelectedIndexChanged += new System.EventHandler(this.overlapNameListBox_SelectedIndexChanged);
            // 
            // overtimeNameListBox
            // 
            this.overtimeNameListBox.FormattingEnabled = true;
            this.overtimeNameListBox.ItemHeight = 20;
            this.overtimeNameListBox.Location = new System.Drawing.Point(776, 743);
            this.overtimeNameListBox.Name = "overtimeNameListBox";
            this.overtimeNameListBox.Size = new System.Drawing.Size(300, 164);
            this.overtimeNameListBox.TabIndex = 34;
            this.overtimeNameListBox.SelectedIndexChanged += new System.EventHandler(this.overtimeNameListBox_SelectedIndexChanged);
            // 
            // overtimeDatePicker
            // 
            this.overtimeDatePicker.Location = new System.Drawing.Point(776, 649);
            this.overtimeDatePicker.Name = "overtimeDatePicker";
            this.overtimeDatePicker.Size = new System.Drawing.Size(300, 26);
            this.overtimeDatePicker.TabIndex = 36;
            // 
            // overtimeCheckButton
            // 
            this.overtimeCheckButton.Location = new System.Drawing.Point(868, 689);
            this.overtimeCheckButton.Name = "overtimeCheckButton";
            this.overtimeCheckButton.Size = new System.Drawing.Size(119, 48);
            this.overtimeCheckButton.TabIndex = 37;
            this.overtimeCheckButton.Text = "Overtime Check";
            this.overtimeCheckButton.UseVisualStyleBackColor = true;
            this.overtimeCheckButton.Click += new System.EventHandler(this.overtimeCheckButton_Click);
            // 
            // overtimeInformationView
            // 
            this.overtimeInformationView.FormattingEnabled = true;
            this.overtimeInformationView.ItemHeight = 20;
            this.overtimeInformationView.Location = new System.Drawing.Point(1082, 603);
            this.overtimeInformationView.Name = "overtimeInformationView";
            this.overtimeInformationView.Size = new System.Drawing.Size(399, 304);
            this.overtimeInformationView.TabIndex = 38;
            // 
            // overlapInformationView
            // 
            this.overlapInformationView.FormattingEnabled = true;
            this.overlapInformationView.ItemHeight = 20;
            this.overlapInformationView.Location = new System.Drawing.Point(1082, 363);
            this.overlapInformationView.Name = "overlapInformationView";
            this.overlapInformationView.Size = new System.Drawing.Size(396, 224);
            this.overlapInformationView.TabIndex = 39;
            // 
            // overlappingLabel
            // 
            this.overlappingLabel.AutoSize = true;
            this.overlappingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.overlappingLabel.Location = new System.Drawing.Point(1077, 205);
            this.overlappingLabel.Name = "overlappingLabel";
            this.overlappingLabel.Size = new System.Drawing.Size(216, 25);
            this.overlappingLabel.TabIndex = 40;
            this.overlappingLabel.Text = "Overlapping Schedules";
            // 
            // overtimeLabel
            // 
            this.overtimeLabel.AutoSize = true;
            this.overtimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.overtimeLabel.Location = new System.Drawing.Point(842, 612);
            this.overtimeLabel.Name = "overtimeLabel";
            this.overtimeLabel.Size = new System.Drawing.Size(170, 25);
            this.overtimeLabel.TabIndex = 41;
            this.overtimeLabel.Text = "Overtime Checker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1493, 926);
            this.Controls.Add(this.overtimeLabel);
            this.Controls.Add(this.overlappingLabel);
            this.Controls.Add(this.overlapInformationView);
            this.Controls.Add(this.overtimeInformationView);
            this.Controls.Add(this.overtimeCheckButton);
            this.Controls.Add(this.overtimeDatePicker);
            this.Controls.Add(this.overtimeNameListBox);
            this.Controls.Add(this.overlapNameListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.excelExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.totalHoursLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.submitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalHoursLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button excelExport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hoursCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox overlapNameListBox;
        private System.Windows.Forms.ListBox overtimeNameListBox;
        private System.Windows.Forms.DateTimePicker overtimeDatePicker;
        private System.Windows.Forms.Button overtimeCheckButton;
        private System.Windows.Forms.ListBox overtimeInformationView;
        private System.Windows.Forms.ListBox overlapInformationView;
        private System.Windows.Forms.Label overlappingLabel;
        private System.Windows.Forms.Label overtimeLabel;
    }
}

