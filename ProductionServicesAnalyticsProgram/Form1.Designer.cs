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
            this.submitButton = new System.Windows.Forms.Button();
            this.debugButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(297, 296);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(82, 29);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(22, 12);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(75, 23);
            this.debugButton.TabIndex = 1;
            this.debugButton.Text = "Test";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(22, 98);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(307, 26);
            this.startDate.TabIndex = 2;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(22, 178);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(307, 26);
            this.endDate.TabIndex = 3;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(18, 75);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(87, 20);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(22, 155);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(77, 20);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date";
            // 
            // analysisTypeLabel
            // 
            this.analysisTypeLabel.AutoSize = true;
            this.analysisTypeLabel.Location = new System.Drawing.Point(482, 38);
            this.analysisTypeLabel.Name = "analysisTypeLabel";
            this.analysisTypeLabel.Size = new System.Drawing.Size(109, 20);
            this.analysisTypeLabel.TabIndex = 9;
            this.analysisTypeLabel.Text = "Analysis Type:";
            // 
            // analysisTypeListBox
            // 
            this.analysisTypeListBox.FormattingEnabled = true;
            this.analysisTypeListBox.ItemHeight = 20;
            this.analysisTypeListBox.Location = new System.Drawing.Point(47, 388);
            this.analysisTypeListBox.Name = "analysisTypeListBox";
            this.analysisTypeListBox.Size = new System.Drawing.Size(120, 84);
            this.analysisTypeListBox.TabIndex = 10;
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 20;
            this.nameListBox.Location = new System.Drawing.Point(47, 546);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(120, 84);
            this.nameListBox.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(417, 330);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // analysisTypeCheckBoxList
            // 
            this.analysisTypeCheckBoxList.FormattingEnabled = true;
            this.analysisTypeCheckBoxList.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.analysisTypeCheckBoxList.Location = new System.Drawing.Point(486, 116);
            this.analysisTypeCheckBoxList.Name = "analysisTypeCheckBoxList";
            this.analysisTypeCheckBoxList.Size = new System.Drawing.Size(175, 67);
            this.analysisTypeCheckBoxList.TabIndex = 13;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(297, 644);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(83, 30);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 712);
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
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button debugButton;
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
    }
}

