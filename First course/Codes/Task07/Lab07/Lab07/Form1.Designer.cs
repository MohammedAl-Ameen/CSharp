
namespace Lab07
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rock4 = new System.Windows.Forms.PictureBox();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.rock2 = new System.Windows.Forms.PictureBox();
            this.rock0 = new System.Windows.Forms.PictureBox();
            this.rock3 = new System.Windows.Forms.PictureBox();
            this.rock1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.fire = new System.Windows.Forms.PictureBox();
            this.lblView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rock4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rock4
            // 
            this.rock4.BackColor = System.Drawing.Color.Transparent;
            this.rock4.Image = global::Lab07.Properties.Resources.stone;
            this.rock4.Location = new System.Drawing.Point(205, 117);
            this.rock4.Name = "rock4";
            this.rock4.Size = new System.Drawing.Size(85, 76);
            this.rock4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rock4.TabIndex = 2;
            this.rock4.TabStop = false;
            this.rock4.Visible = false;
            // 
            // rocket
            // 
            this.rocket.BackColor = System.Drawing.Color.Transparent;
            this.rocket.Image = global::Lab07.Properties.Resources.rocket2;
            this.rocket.Location = new System.Drawing.Point(205, 336);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(69, 82);
            this.rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocket.TabIndex = 5;
            this.rocket.TabStop = false;
            // 
            // rock2
            // 
            this.rock2.BackColor = System.Drawing.Color.Transparent;
            this.rock2.Image = global::Lab07.Properties.Resources.stone;
            this.rock2.Location = new System.Drawing.Point(333, 281);
            this.rock2.Name = "rock2";
            this.rock2.Size = new System.Drawing.Size(85, 76);
            this.rock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rock2.TabIndex = 6;
            this.rock2.TabStop = false;
            this.rock2.Visible = false;
            // 
            // rock0
            // 
            this.rock0.BackColor = System.Drawing.Color.Transparent;
            this.rock0.Image = global::Lab07.Properties.Resources.stone;
            this.rock0.Location = new System.Drawing.Point(639, 188);
            this.rock0.Name = "rock0";
            this.rock0.Size = new System.Drawing.Size(85, 76);
            this.rock0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rock0.TabIndex = 7;
            this.rock0.TabStop = false;
            this.rock0.Visible = false;
            // 
            // rock3
            // 
            this.rock3.BackColor = System.Drawing.Color.Transparent;
            this.rock3.Image = global::Lab07.Properties.Resources.stone;
            this.rock3.Location = new System.Drawing.Point(242, 199);
            this.rock3.Name = "rock3";
            this.rock3.Size = new System.Drawing.Size(85, 76);
            this.rock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rock3.TabIndex = 8;
            this.rock3.TabStop = false;
            this.rock3.Visible = false;
            // 
            // rock1
            // 
            this.rock1.BackColor = System.Drawing.Color.Transparent;
            this.rock1.Image = global::Lab07.Properties.Resources.stone;
            this.rock1.Location = new System.Drawing.Point(534, 201);
            this.rock1.Name = "rock1";
            this.rock1.Size = new System.Drawing.Size(85, 76);
            this.rock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rock1.TabIndex = 9;
            this.rock1.TabStop = false;
            this.rock1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // fire
            // 
            this.fire.BackColor = System.Drawing.Color.Transparent;
            this.fire.Image = global::Lab07.Properties.Resources.Layer_1;
            this.fire.Location = new System.Drawing.Point(520, 371);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(29, 30);
            this.fire.TabIndex = 10;
            this.fire.TabStop = false;
            this.fire.Visible = false;
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Location = new System.Drawing.Point(37, 9);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(44, 17);
            this.lblView.TabIndex = 11;
            this.lblView.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab07.Properties.Resources.space2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 478);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.rock1);
            this.Controls.Add(this.rock3);
            this.Controls.Add(this.rock0);
            this.Controls.Add(this.rock2);
            this.Controls.Add(this.rocket);
            this.Controls.Add(this.rock4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rock4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox rock4;
        private System.Windows.Forms.PictureBox rocket;
        private System.Windows.Forms.PictureBox rock2;
        private System.Windows.Forms.PictureBox rock0;
        private System.Windows.Forms.PictureBox rock3;
        private System.Windows.Forms.PictureBox rock1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox fire;
        private System.Windows.Forms.Label lblView;
    }
}

