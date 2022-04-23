
namespace Lab06
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fall = new System.Windows.Forms.RichTextBox();
            this.pass = new System.Windows.Forms.RichTextBox();
            this.avg = new System.Windows.Forms.RichTextBox();
            this.Min = new System.Windows.Forms.RichTextBox();
            this.Max = new System.Windows.Forms.RichTextBox();
            this.list = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.RichTextBox();
            this.Mark = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fall);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.avg);
            this.groupBox1.Controls.Add(this.Min);
            this.groupBox1.Controls.Add(this.Max);
            this.groupBox1.Location = new System.Drawing.Point(82, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Stats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Faild";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Passed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Average";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Minimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maximum";
            // 
            // fall
            // 
            this.fall.Location = new System.Drawing.Point(93, 218);
            this.fall.Name = "fall";
            this.fall.ReadOnly = true;
            this.fall.Size = new System.Drawing.Size(129, 26);
            this.fall.TabIndex = 9;
            this.fall.Text = "";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(93, 186);
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Size = new System.Drawing.Size(129, 26);
            this.pass.TabIndex = 8;
            this.pass.Text = "";
            // 
            // avg
            // 
            this.avg.Location = new System.Drawing.Point(93, 122);
            this.avg.Name = "avg";
            this.avg.ReadOnly = true;
            this.avg.Size = new System.Drawing.Size(129, 26);
            this.avg.TabIndex = 7;
            this.avg.Text = "";
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(93, 90);
            this.Min.Name = "Min";
            this.Min.ReadOnly = true;
            this.Min.Size = new System.Drawing.Size(129, 26);
            this.Min.TabIndex = 6;
            this.Min.Text = "";
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(93, 58);
            this.Max.Name = "Max";
            this.Max.ReadOnly = true;
            this.Max.Size = new System.Drawing.Size(129, 26);
            this.Max.TabIndex = 5;
            this.Max.Text = "";
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(465, 85);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(441, 423);
            this.list.TabIndex = 1;
            this.list.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Name";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(144, 48);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(160, 25);
            this.Name.TabIndex = 4;
            this.Name.Text = "";
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(144, 85);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(160, 25);
            this.Mark.TabIndex = 5;
            this.Mark.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student Mark";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Course Student List";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.groupBox1);
     
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Name;
        private System.Windows.Forms.RichTextBox Mark;
        private System.Windows.Forms.RichTextBox Min;
        private System.Windows.Forms.RichTextBox Max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox fall;
        private System.Windows.Forms.RichTextBox pass;
        private System.Windows.Forms.RichTextBox avg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}

