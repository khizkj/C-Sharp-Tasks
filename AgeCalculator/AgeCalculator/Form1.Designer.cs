namespace AgeCalculator
{
    partial class Form1
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
            label1 = new Label();
            current = new Label();
            birthyear = new Label();
            box2 = new TextBox();
            box1 = new TextBox();
            label4 = new Label();
            year = new Label();
            month = new Label();
            label7 = new Label();
            week = new Label();
            label9 = new Label();
            day = new Label();
            label11 = new Label();
            hour = new Label();
            label13 = new Label();
            minute = new Label();
            label15 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label1.Location = new Point(349, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 39);
            label1.TabIndex = 0;
            label1.Text = "Age Calculator";
            // 
            // current
            // 
            current.AutoSize = true;
            current.Font = new Font("Segoe UI", 14.25F);
            current.Location = new Point(210, 117);
            current.Name = "current";
            current.Size = new Size(117, 25);
            current.TabIndex = 1;
            current.Text = "Current year";
            // 
            // birthyear
            // 
            birthyear.AutoSize = true;
            birthyear.Font = new Font("Segoe UI", 14.25F);
            birthyear.Location = new Point(234, 160);
            birthyear.Name = "birthyear";
            birthyear.Size = new Size(93, 25);
            birthyear.TabIndex = 2;
            birthyear.Text = "Birth year";
            birthyear.Click += label3_Click;
            // 
            // box2
            // 
            box2.Location = new Point(334, 162);
            box2.Name = "box2";
            box2.Size = new Size(225, 23);
            box2.TabIndex = 3;
            box2.TextChanged += textBox1_TextChanged;
            // 
            // box1
            // 
            box1.Location = new Point(334, 117);
            box1.Name = "box1";
            box1.Size = new Size(225, 23);
            box1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(193, 299);
            label4.Name = "label4";
            label4.Size = new Size(52, 27);
            label4.TabIndex = 5;
            label4.Text = "Year";
            label4.Click += label4_Click;
            // 
            // year
            // 
            year.AutoSize = true;
            year.BackColor = SystemColors.Control;
            year.BorderStyle = BorderStyle.FixedSingle;
            year.Font = new Font("Segoe UI", 14.25F);
            year.Location = new Point(251, 299);
            year.Name = "year";
            year.Size = new Size(26, 27);
            year.TabIndex = 7;
            year.Text = "...";
            // 
            // month
            // 
            month.AutoSize = true;
            month.BackColor = SystemColors.Control;
            month.BorderStyle = BorderStyle.FixedSingle;
            month.Font = new Font("Segoe UI", 14.25F);
            month.Location = new Point(437, 299);
            month.Name = "month";
            month.Size = new Size(26, 27);
            month.TabIndex = 9;
            month.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(358, 299);
            label7.Name = "label7";
            label7.Size = new Size(74, 27);
            label7.TabIndex = 8;
            label7.Text = "Month";
            // 
            // week
            // 
            week.AutoSize = true;
            week.BackColor = SystemColors.Control;
            week.BorderStyle = BorderStyle.FixedSingle;
            week.Font = new Font("Segoe UI", 14.25F);
            week.Location = new Point(594, 299);
            week.Name = "week";
            week.Size = new Size(26, 27);
            week.TabIndex = 11;
            week.Text = "...";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(525, 299);
            label9.Name = "label9";
            label9.Size = new Size(63, 27);
            label9.TabIndex = 10;
            label9.Text = "Week";
            // 
            // day
            // 
            day.AutoSize = true;
            day.BackColor = SystemColors.Control;
            day.BorderStyle = BorderStyle.FixedSingle;
            day.Font = new Font("Segoe UI", 14.25F);
            day.Location = new Point(251, 360);
            day.Name = "day";
            day.Size = new Size(26, 27);
            day.TabIndex = 13;
            day.Text = "...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(195, 360);
            label11.Name = "label11";
            label11.Size = new Size(48, 27);
            label11.TabIndex = 12;
            label11.Text = "Day";
            label11.Click += label11_Click;
            // 
            // hour
            // 
            hour.AutoSize = true;
            hour.BackColor = SystemColors.Control;
            hour.BorderStyle = BorderStyle.FixedSingle;
            hour.Font = new Font("Segoe UI", 14.25F);
            hour.Location = new Point(425, 360);
            hour.Name = "hour";
            hour.Size = new Size(26, 27);
            hour.TabIndex = 15;
            hour.Text = "...";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(358, 360);
            label13.Name = "label13";
            label13.Size = new Size(61, 27);
            label13.TabIndex = 14;
            label13.Text = "Hour";
            // 
            // minute
            // 
            minute.AutoSize = true;
            minute.BackColor = SystemColors.Control;
            minute.BorderStyle = BorderStyle.FixedSingle;
            minute.Font = new Font("Segoe UI", 14.25F);
            minute.Location = new Point(607, 360);
            minute.Name = "minute";
            minute.Size = new Size(26, 27);
            minute.TabIndex = 17;
            minute.Text = "...";
            minute.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.Control;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(525, 360);
            label15.Name = "label15";
            label15.Size = new Size(78, 27);
            label15.TabIndex = 16;
            label15.Text = "Minute";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(403, 215);
            button1.Name = "button1";
            button1.Size = new Size(85, 28);
            button1.TabIndex = 18;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(948, 477);
            Controls.Add(button1);
            Controls.Add(minute);
            Controls.Add(label15);
            Controls.Add(hour);
            Controls.Add(label13);
            Controls.Add(day);
            Controls.Add(label11);
            Controls.Add(week);
            Controls.Add(label9);
            Controls.Add(month);
            Controls.Add(label7);
            Controls.Add(year);
            Controls.Add(label4);
            Controls.Add(box1);
            Controls.Add(box2);
            Controls.Add(birthyear);
            Controls.Add(current);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label current;
        private Label birthyear;
        private TextBox box2;
        private TextBox box1;
        private Label label4;
        private Label year;
        private Label month;
        private Label label7;
        private Label week;
        private Label label9;
        private Label day;
        private Label label11;
        private Label hour;
        private Label label13;
        private Label minute;
        private Label label15;
        private Button button1;
    }
}
