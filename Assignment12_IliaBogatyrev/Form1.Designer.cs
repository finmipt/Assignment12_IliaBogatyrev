namespace Assignment12_IliaBogatyrev
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeNumber = new System.Windows.Forms.TextBox();
            this.textBoxShiftNumber = new System.Windows.Forms.TextBox();
            this.textBoxHourlyPayRate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(154, 91);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxEmployeeNumber
            // 
            this.textBoxEmployeeNumber.Location = new System.Drawing.Point(154, 131);
            this.textBoxEmployeeNumber.Name = "textBoxEmployeeNumber";
            this.textBoxEmployeeNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxEmployeeNumber.TabIndex = 1;
            // 
            // textBoxShiftNumber
            // 
            this.textBoxShiftNumber.Location = new System.Drawing.Point(154, 176);
            this.textBoxShiftNumber.Name = "textBoxShiftNumber";
            this.textBoxShiftNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxShiftNumber.TabIndex = 2;
            // 
            // textBoxHourlyPayRate
            // 
            this.textBoxHourlyPayRate.Location = new System.Drawing.Point(154, 222);
            this.textBoxHourlyPayRate.Name = "textBoxHourlyPayRate";
            this.textBoxHourlyPayRate.Size = new System.Drawing.Size(100, 23);
            this.textBoxHourlyPayRate.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(345, 99);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(48, 15);
            this.labelOutput.TabIndex = 5;
            this.labelOutput.Text = "Waiting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Shift Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hourly Pay Rate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxHourlyPayRate);
            this.Controls.Add(this.textBoxShiftNumber);
            this.Controls.Add(this.textBoxEmployeeNumber);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxEmployeeNumber;
        private TextBox textBoxShiftNumber;
        private TextBox textBoxHourlyPayRate;
        private Button button1;
        private Label labelOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}