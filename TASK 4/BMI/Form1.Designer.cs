
namespace BMI
{
    partial class BMIFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.FeetBox = new System.Windows.Forms.TextBox();
            this.InchesBox = new System.Windows.Forms.TextBox();
            this.FeetLabel = new System.Windows.Forms.Label();
            this.InchesLabel = new System.Windows.Forms.Label();
            this.CalBtn = new System.Windows.Forms.Button();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.Label();
            this.BMIlabel = new System.Windows.Forms.Label();
            this.BMIlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight (lbs.)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your Height";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(151, 92);
            this.WeightBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(197, 27);
            this.WeightBox.TabIndex = 3;
            // 
            // FeetBox
            // 
            this.FeetBox.Location = new System.Drawing.Point(151, 163);
            this.FeetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FeetBox.Name = "FeetBox";
            this.FeetBox.Size = new System.Drawing.Size(49, 27);
            this.FeetBox.TabIndex = 5;
            this.FeetBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // InchesBox
            // 
            this.InchesBox.Location = new System.Drawing.Point(258, 163);
            this.InchesBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InchesBox.Name = "InchesBox";
            this.InchesBox.Size = new System.Drawing.Size(49, 27);
            this.InchesBox.TabIndex = 6;
            this.InchesBox.TextChanged += new System.EventHandler(this.InchesBox_TextChanged);
            // 
            // FeetLabel
            // 
            this.FeetLabel.AutoSize = true;
            this.FeetLabel.Location = new System.Drawing.Point(218, 173);
            this.FeetLabel.Name = "FeetLabel";
            this.FeetLabel.Size = new System.Drawing.Size(22, 20);
            this.FeetLabel.TabIndex = 7;
            this.FeetLabel.Text = "ft.";
            this.FeetLabel.Click += new System.EventHandler(this.FeetLabel_Click);
            // 
            // InchesLabel
            // 
            this.InchesLabel.AutoSize = true;
            this.InchesLabel.Location = new System.Drawing.Point(328, 173);
            this.InchesLabel.Name = "InchesLabel";
            this.InchesLabel.Size = new System.Drawing.Size(24, 20);
            this.InchesLabel.TabIndex = 8;
            this.InchesLabel.Text = "in.";
            this.InchesLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // CalBtn
            // 
            this.CalBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CalBtn.Location = new System.Drawing.Point(362, 241);
            this.CalBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(86, 31);
            this.CalBtn.TabIndex = 9;
            this.CalBtn.Text = "Get BMI";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ClrBtn.Location = new System.Drawing.Point(479, 241);
            this.ClrBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(86, 31);
            this.ClrBtn.TabIndex = 11;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Results.Location = new System.Drawing.Point(15, 241);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(97, 27);
            this.Results.TabIndex = 12;
            this.Results.Text = "Results:";
            // 
            // BMIlabel
            // 
            this.BMIlabel.AutoSize = true;
            this.BMIlabel.Location = new System.Drawing.Point(128, 241);
            this.BMIlabel.Name = "BMIlabel";
            this.BMIlabel.Size = new System.Drawing.Size(0, 20);
            this.BMIlabel.TabIndex = 13;
            // 
            // BMIlbl
            // 
            this.BMIlbl.AutoSize = true;
            this.BMIlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BMIlbl.Location = new System.Drawing.Point(128, 248);
            this.BMIlbl.Name = "BMIlbl";
            this.BMIlbl.Size = new System.Drawing.Size(0, 20);
            this.BMIlbl.TabIndex = 14;
            // 
            // BMIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(594, 600);
            this.Controls.Add(this.BMIlbl);
            this.Controls.Add(this.BMIlabel);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.CalBtn);
            this.Controls.Add(this.InchesLabel);
            this.Controls.Add(this.FeetLabel);
            this.Controls.Add(this.InchesBox);
            this.Controls.Add(this.FeetBox);
            this.Controls.Add(this.WeightBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BMIFrm";
            this.Text = "BMI CHECKER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TextBox FeetBox;
        private System.Windows.Forms.TextBox InchesBox;
        private System.Windows.Forms.Label FeetLabel;
        private System.Windows.Forms.Label InchesLabel;
        private System.Windows.Forms.Button CalBtn;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Label BMIlabel;
        private System.Windows.Forms.Label BMIlbl;
    }
}

