namespace ProductionServicesAnalyticsProgram
{
    partial class Scratchpad
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
            this.submit = new System.Windows.Forms.Button();
            this.events = new System.Windows.Forms.ListView();
            this.addToShift = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.students = new System.Windows.Forms.ListView();
            this.editedShifts = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(758, 519);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(568, 64);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit Changes";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // events
            // 
            this.events.Cursor = System.Windows.Forms.Cursors.Cross;
            this.events.HideSelection = false;
            this.events.Location = new System.Drawing.Point(758, 75);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(568, 438);
            this.events.TabIndex = 2;
            this.events.UseCompatibleStateImageBehavior = false;
            this.events.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // addToShift
            // 
            this.addToShift.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.addToShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToShift.Location = new System.Drawing.Point(409, 166);
            this.addToShift.Name = "addToShift";
            this.addToShift.Size = new System.Drawing.Size(343, 108);
            this.addToShift.TabIndex = 3;
            this.addToShift.Text = "Add Students to Selected Shift ->";
            this.addToShift.UseVisualStyleBackColor = false;
            this.addToShift.Click += new System.EventHandler(this.addToShift_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1024, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shifts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Available Students";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 120);
            this.button3.TabIndex = 6;
            this.button3.Text = "Display Selected Shift Data, TEST USE ONLY";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // students
            // 
            this.students.Cursor = System.Windows.Forms.Cursors.Hand;
            this.students.Location = new System.Drawing.Point(13, 75);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(390, 508);
            this.students.TabIndex = 7;
            this.students.UseCompatibleStateImageBehavior = false;
            // 
            // editedShifts
            // 
            this.editedShifts.Cursor = System.Windows.Forms.Cursors.No;
            this.editedShifts.FormattingEnabled = true;
            this.editedShifts.ItemHeight = 20;
            this.editedShifts.Location = new System.Drawing.Point(409, 339);
            this.editedShifts.Name = "editedShifts";
            this.editedShifts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.editedShifts.Size = new System.Drawing.Size(343, 244);
            this.editedShifts.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Assigned, Unsubmitted Shifts";
            // 
            // Scratchpad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editedShifts);
            this.Controls.Add(this.students);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addToShift);
            this.Controls.Add(this.events);
            this.Controls.Add(this.submit);
            this.Name = "Scratchpad";
            this.Text = "Scratchpad";
            this.Load += new System.EventHandler(this.Scratchpad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ListView events;
        private System.Windows.Forms.Button addToShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView students;
        private System.Windows.Forms.ListBox editedShifts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip;
    }
}