namespace Main_Window
{
    partial class Attendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.radioAbsent = new System.Windows.Forms.RadioButton();
            this.radioPresent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.DateAttendance = new System.Windows.Forms.DateTimePicker();
            this.groupAttendance = new System.Windows.Forms.GroupBox();
            this.groupBatch = new System.Windows.Forms.GroupBox();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupAttendance.SuspendLayout();
            this.groupBatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(382, 546);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(186, 35);
            this.btnAttendance.TabIndex = 78;
            this.btnAttendance.Text = "Mark Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(636, 546);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 35);
            this.btnClear.TabIndex = 77;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(14, 614);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1101, 15);
            this.label12.TabIndex = 57;
            // 
            // radioAbsent
            // 
            this.radioAbsent.AutoSize = true;
            this.radioAbsent.Location = new System.Drawing.Point(210, 29);
            this.radioAbsent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioAbsent.Name = "radioAbsent";
            this.radioAbsent.Size = new System.Drawing.Size(85, 24);
            this.radioAbsent.TabIndex = 56;
            this.radioAbsent.TabStop = true;
            this.radioAbsent.Text = "Absent";
            this.radioAbsent.UseVisualStyleBackColor = true;
            this.radioAbsent.CheckedChanged += new System.EventHandler(this.radioAbsent_CheckedChanged);
            // 
            // radioPresent
            // 
            this.radioPresent.AutoSize = true;
            this.radioPresent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioPresent.Location = new System.Drawing.Point(81, 29);
            this.radioPresent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioPresent.Name = "radioPresent";
            this.radioPresent.Size = new System.Drawing.Size(89, 24);
            this.radioPresent.TabIndex = 55;
            this.radioPresent.TabStop = true;
            this.radioPresent.Text = "Present";
            this.radioPresent.UseVisualStyleBackColor = true;
            this.radioPresent.CheckedChanged += new System.EventHandler(this.radioPresent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(536, 203);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(211, 26);
            this.txtStudentName.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Student Name:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(564, 152);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(148, 26);
            this.txtStudentID.TabIndex = 45;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Student ID:";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(4, 451);
            this.label5.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(254, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(873, 5);
            this.label4.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Attendance Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 55);
            this.panel1.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(454, 358);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 24);
            this.label9.TabIndex = 79;
            this.label9.Text = "Date:";
            // 
            // DateAttendance
            // 
            this.DateAttendance.CustomFormat = "yyyy-MM-dd";
            this.DateAttendance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateAttendance.Location = new System.Drawing.Point(549, 357);
            this.DateAttendance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateAttendance.Name = "DateAttendance";
            this.DateAttendance.Size = new System.Drawing.Size(163, 26);
            this.DateAttendance.TabIndex = 80;
            // 
            // groupAttendance
            // 
            this.groupAttendance.Controls.Add(this.radioPresent);
            this.groupAttendance.Controls.Add(this.radioAbsent);
            this.groupAttendance.Location = new System.Drawing.Point(396, 414);
            this.groupAttendance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupAttendance.Name = "groupAttendance";
            this.groupAttendance.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupAttendance.Size = new System.Drawing.Size(366, 85);
            this.groupAttendance.TabIndex = 81;
            this.groupAttendance.TabStop = false;
            this.groupAttendance.Text = "Attendance Status";
            // 
            // groupBatch
            // 
            this.groupBatch.Controls.Add(this.radio3);
            this.groupBatch.Controls.Add(this.radio2);
            this.groupBatch.Controls.Add(this.radio1);
            this.groupBatch.Location = new System.Drawing.Point(402, 242);
            this.groupBatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBatch.Name = "groupBatch";
            this.groupBatch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBatch.Size = new System.Drawing.Size(348, 100);
            this.groupBatch.TabIndex = 85;
            this.groupBatch.TabStop = false;
            this.groupBatch.Text = "Batch";
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio3.Location = new System.Drawing.Point(243, 43);
            this.radio3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(65, 24);
            this.radio3.TabIndex = 59;
            this.radio3.TabStop = true;
            this.radio3.Text = "20.1";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio3_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio2.Location = new System.Drawing.Point(147, 43);
            this.radio2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(65, 24);
            this.radio2.TabIndex = 58;
            this.radio2.TabStop = true;
            this.radio2.Text = "19.2";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio1.Location = new System.Drawing.Point(57, 43);
            this.radio1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(65, 24);
            this.radio1.TabIndex = 57;
            this.radio1.TabStop = true;
            this.radio1.Text = "19.1";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.DateAttendance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupAttendance);
            this.Controls.Add(this.groupBatch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Attendance";
            this.Size = new System.Drawing.Size(1140, 629);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupAttendance.ResumeLayout(false);
            this.groupAttendance.PerformLayout();
            this.groupBatch.ResumeLayout(false);
            this.groupBatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioAbsent;
        private System.Windows.Forms.RadioButton radioPresent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DateAttendance;
        private System.Windows.Forms.GroupBox groupAttendance;
        private System.Windows.Forms.GroupBox groupBatch;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
    }
}
