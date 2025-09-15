namespace Assignment1
{
    partial class Assignment1
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtHoursWorked = new TextBox();
            btnSummarize = new Button();
            btnClear = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblHoursWorked = new Label();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(50, 100);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(300, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(550, 100);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(200, 23);
            txtHoursWorked.TabIndex = 2;
            // 
            // btnSummarize
            // 
            btnSummarize.Location = new Point(50, 175);
            btnSummarize.Name = "btnSummarize";
            btnSummarize.Size = new Size(75, 23);
            btnSummarize.TabIndex = 3;
            btnSummarize.Text = "Summarize";
            btnSummarize.UseVisualStyleBackColor = true;
            btnSummarize.Click += btnSummarize_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(130, 175);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(50, 85);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(300, 85);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.Location = new Point(550, 85);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(83, 15);
            lblHoursWorked.TabIndex = 7;
            lblHoursWorked.Text = "Hours Worked";
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Location = new Point(150, 240);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(500, 150);
            lblOutput.TabIndex = 8;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Assignment1
            // 
            AcceptButton = btnSummarize;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOutput);
            Controls.Add(lblHoursWorked);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnClear);
            Controls.Add(btnSummarize);
            Controls.Add(txtHoursWorked);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "Assignment1";
            Text = "Assignment1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtHoursWorked;
        private Button btnSummarize;
        private Button btnClear;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblHoursWorked;
        private Label lblOutput;
    }
}
