namespace WriteHebrewDate
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
            DayInWeekComboBox = new ComboBox();
            DayInMonthComboBox = new ComboBox();
            MonthComboBox = new ComboBox();
            YearComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            EnterButton = new Button();
            SuspendLayout();
            // 
            // DayInWeekComboBox
            // 
            DayInWeekComboBox.FormattingEnabled = true;
            DayInWeekComboBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי", "שבת" });
            DayInWeekComboBox.Location = new Point(691, 157);
            DayInWeekComboBox.Name = "DayInWeekComboBox";
            DayInWeekComboBox.Size = new Size(121, 23);
            DayInWeekComboBox.TabIndex = 0;
            // 
            // DayInMonthComboBox
            // 
            DayInMonthComboBox.FormattingEnabled = true;
            DayInMonthComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            DayInMonthComboBox.Location = new Point(502, 157);
            DayInMonthComboBox.Name = "DayInMonthComboBox";
            DayInMonthComboBox.Size = new Size(121, 23);
            DayInMonthComboBox.TabIndex = 0;
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            MonthComboBox.Location = new Point(300, 157);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(121, 23);
            MonthComboBox.TabIndex = 0;
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Items.AddRange(new object[] { "תשפ'ד", "תשפ'ה", "תשפ'ו", "תשפ'ז", "תשפ'ח", "תשפ'ט", "תש'צ", "תשצ'א", "תשצ'ב", "תשצ'ג" });
            YearComboBox.Location = new Point(111, 157);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(121, 23);
            YearComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(722, 121);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "היום בשבוע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 121);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "היום בחודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 121);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 1;
            label3.Text = "חודש";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 121);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 1;
            label4.Text = "שנה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(398, 50);
            label5.Name = "label5";
            label5.Size = new Size(128, 32);
            label5.TabIndex = 1;
            label5.Text = "בחר תאריך";
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(145, 59);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(75, 23);
            EnterButton.TabIndex = 2;
            EnterButton.Text = "הכנס";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 599);
            Controls.Add(EnterButton);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(YearComboBox);
            Controls.Add(DayInMonthComboBox);
            Controls.Add(MonthComboBox);
            Controls.Add(DayInWeekComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DayInWeekComboBox;
        private ComboBox DayInMonthComboBox;
        private ComboBox MonthComboBox;
        private ComboBox YearComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button EnterButton;
    }
}
