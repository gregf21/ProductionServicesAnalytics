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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(329, 82);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(175, 91);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(16, 82);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(307, 26);
            this.startDate.TabIndex = 2;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(16, 147);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(307, 26);
            this.endDate.TabIndex = 3;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(12, 59);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(87, 20);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(16, 124);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(77, 20);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date";
            // 
            // analysisTypeLabel
            // 
            this.analysisTypeLabel.AutoSize = true;
            this.analysisTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisTypeLabel.Location = new System.Drawing.Point(57, 188);
            this.analysisTypeLabel.Name = "analysisTypeLabel";
            this.analysisTypeLabel.Size = new System.Drawing.Size(168, 29);
            this.analysisTypeLabel.TabIndex = 9;
            this.analysisTypeLabel.Text = "Analysis Type:";
            // 
            // analysisTypeListBox
            // 
            this.analysisTypeListBox.FormattingEnabled = true;
            this.analysisTypeListBox.ItemHeight = 20;
            this.analysisTypeListBox.Location = new System.Drawing.Point(20, 313);
            this.analysisTypeListBox.Name = "analysisTypeListBox";
            this.analysisTypeListBox.Size = new System.Drawing.Size(244, 84);
            this.analysisTypeListBox.TabIndex = 10;
            this.analysisTypeListBox.SelectedIndexChanged += new System.EventHandler(this.analysisTypeListBox_SelectedIndexChanged);
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 20;
            this.nameListBox.Location = new System.Drawing.Point(20, 403);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(244, 184);
            this.nameListBox.TabIndex = 11;
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
            this.chart1.Size = new System.Drawing.Size(806, 399);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // analysisTypeCheckBoxList
            // 
            this.analysisTypeCheckBoxList.CheckOnClick = true;
            this.analysisTypeCheckBoxList.FormattingEnabled = true;
            this.analysisTypeCheckBoxList.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.analysisTypeCheckBoxList.Location = new System.Drawing.Point(20, 220);
            this.analysisTypeCheckBoxList.Name = "analysisTypeCheckBoxList";
            this.analysisTypeCheckBoxList.Size = new System.Drawing.Size(244, 88);
            this.analysisTypeCheckBoxList.TabIndex = 13;
            this.analysisTypeCheckBoxList.SelectedIndexChanged += new System.EventHandler(this.analysisTypeCheckBoxList_SelectedIndexChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(510, 82);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(175, 91);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update Chart";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
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
            this.totalHoursLabel.Location = new System.Drawing.Point(263, 609);
            this.totalHoursLabel.Name = "totalHoursLabel";
            this.totalHoursLabel.Size = new System.Drawing.Size(215, 37);
            this.totalHoursLabel.TabIndex = 16;
            this.totalHoursLabel.Text = "Total Hours: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 655);
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
    }
}

