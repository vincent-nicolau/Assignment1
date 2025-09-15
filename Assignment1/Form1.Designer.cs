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
            txtFirstName.Location = new Point(96, 165);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(342, 173);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(601, 179);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(100, 23);
            txtHoursWorked.TabIndex = 2;
            // 
            // btnSummarize
            // 
            btnSummarize.Location = new Point(105, 238);
            btnSummarize.Name = "btnSummarize";
            btnSummarize.Size = new Size(75, 23);
            btnSummarize.TabIndex = 3;
            btnSummarize.Text = "button1";
            btnSummarize.UseVisualStyleBackColor = true;
            btnSummarize.Click += btnSummarize_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(231, 238);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "button2";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(96, 110);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(38, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "label1";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(362, 122);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(38, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "label2";
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.Location = new Point(596, 120);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(38, 15);
            lblHoursWorked.TabIndex = 7;
            lblHoursWorked.Text = "label3";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(347, 344);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(38, 15);
            lblOutput.TabIndex = 8;
            lblOutput.Text = "label4";
            // 
            // Assignment1
            // 
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
