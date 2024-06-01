namespace date_time_checker_cs
{
    partial class Date
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormClosing += new FormClosingEventHandler(Date_FormClosing);

            label1 = new Label();
            colorDialog1 = new ColorDialog();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dayTextBox = new TextBox();
            monthTextBox = new TextBox();
            yearTextBox = new TextBox();
            btnClear = new Button();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 0;
            label1.Text = "Date Time Checker";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 53);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Day";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 83);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Month";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 113);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 3;
            label4.Text = "Year";
            // 
            // dayTextBox
            // 
            dayTextBox.Location = new Point(118, 50);
            dayTextBox.Name = "dayTextBox";
            dayTextBox.Size = new Size(114, 23);
            dayTextBox.TabIndex = 4;
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(118, 80);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(114, 23);
            monthTextBox.TabIndex = 5;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(118, 110);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(114, 23);
            yearTextBox.TabIndex = 6;
            yearTextBox.TextChanged += year_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(59, 149);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(157, 149);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // Date
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 201);
            Controls.Add(btnCheck);
            Controls.Add(btnClear);
            Controls.Add(yearTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(dayTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Date";
            Text = "Date TIme Checker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ColorDialog colorDialog1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox dayTextBox;
        private TextBox monthTextBox;
        private TextBox yearTextBox;
        private Button btnClear;
        private Button btnCheck;
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text in the TextBox fields
            dayTextBox.Text = "";
            monthTextBox.Text = "";
            yearTextBox.Text = "";
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Get the text from the TextBox fields
            string day = dayTextBox.Text;
            string month = monthTextBox.Text;
            string year = yearTextBox.Text;

            // Call the CheckDate method
            Program.CheckDate(day, month, year);
        }
        private void Date_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }

}
