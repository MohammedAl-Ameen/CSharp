
namespace Lab04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Search_button = new System.Windows.Forms.Button();
            this.RichBox = new System.Windows.Forms.RichTextBox();
            this.Contact_List = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Search_Text = new System.Windows.Forms.TextBox();
            this.type_text = new System.Windows.Forms.ComboBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.city_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.mobile_text = new System.Windows.Forms.TextBox();
            this.Contact_Info = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Contact_List.SuspendLayout();
            this.Contact_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(541, 34);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(94, 29);
            this.Search_button.TabIndex = 0;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // RichBox
            // 
            this.RichBox.Location = new System.Drawing.Point(15, 84);
            this.RichBox.Name = "RichBox";
            this.RichBox.Size = new System.Drawing.Size(741, 198);
            this.RichBox.TabIndex = 1;
            this.RichBox.Text = "";
            // 
            // Contact_List
            // 
            this.Contact_List.Controls.Add(this.Search);
            this.Contact_List.Controls.Add(this.Clear_button);
            this.Contact_List.Controls.Add(this.Search_button);
            this.Contact_List.Controls.Add(this.Search_Text);
            this.Contact_List.Controls.Add(this.RichBox);
            this.Contact_List.Location = new System.Drawing.Point(19, 12);
            this.Contact_List.Name = "Contact_List";
            this.Contact_List.Size = new System.Drawing.Size(809, 306);
            this.Contact_List.TabIndex = 2;
            this.Contact_List.TabStop = false;
            this.Contact_List.Text = "Contact List";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(42, 37);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(53, 20);
            this.Search.TabIndex = 7;
            this.Search.Text = "Search";
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(641, 34);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(94, 29);
            this.Clear_button.TabIndex = 6;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Search_Text
            // 
            this.Search_Text.Location = new System.Drawing.Point(116, 34);
            this.Search_Text.Multiline = true;
            this.Search_Text.Name = "Search_Text";
            this.Search_Text.Size = new System.Drawing.Size(415, 27);
            this.Search_Text.TabIndex = 4;
            // 
            // type_text
            // 
            this.type_text.FormattingEnabled = true;
            this.type_text.Items.AddRange(new object[] {
            "Family",
            "Friends",
            "Business"});
            this.type_text.Location = new System.Drawing.Point(128, 92);
            this.type_text.Name = "type_text";
            this.type_text.Size = new System.Drawing.Size(151, 28);
            this.type_text.TabIndex = 5;
            // 
            // Add_button
            // 
            this.Add_button.Enabled = false;
            this.Add_button.Location = new System.Drawing.Point(34, 367);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(152, 41);
            this.Add_button.TabIndex = 6;
            this.Add_button.Text = "Add New Contact";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(319, 97);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(94, 29);
            this.ok_button.TabIndex = 7;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Visible = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(319, 62);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(94, 29);
            this.update_button.TabIndex = 8;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Visible = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(319, 27);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(94, 29);
            this.delete_button.TabIndex = 9;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Visible = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // city_text
            // 
            this.city_text.Location = new System.Drawing.Point(128, 59);
            this.city_text.Multiline = true;
            this.city_text.Name = "city_text";
            this.city_text.Size = new System.Drawing.Size(151, 27);
            this.city_text.TabIndex = 10;
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(128, 28);
            this.name_text.Multiline = true;
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(151, 27);
            this.name_text.TabIndex = 11;
            // 
            // mobile_text
            // 
            this.mobile_text.Location = new System.Drawing.Point(128, 126);
            this.mobile_text.Multiline = true;
            this.mobile_text.Name = "mobile_text";
            this.mobile_text.Size = new System.Drawing.Size(151, 27);
            this.mobile_text.TabIndex = 12;
            // 
            // Contact_Info
            // 
            this.Contact_Info.Controls.Add(this.label6);
            this.Contact_Info.Controls.Add(this.label5);
            this.Contact_Info.Controls.Add(this.label4);
            this.Contact_Info.Controls.Add(this.label3);
            this.Contact_Info.Controls.Add(this.name_text);
            this.Contact_Info.Controls.Add(this.ok_button);
            this.Contact_Info.Controls.Add(this.update_button);
            this.Contact_Info.Controls.Add(this.delete_button);
            this.Contact_Info.Controls.Add(this.mobile_text);
            this.Contact_Info.Controls.Add(this.city_text);
            this.Contact_Info.Controls.Add(this.type_text);
            this.Contact_Info.Location = new System.Drawing.Point(241, 367);
            this.Contact_Info.Name = "Contact_Info";
            this.Contact_Info.Size = new System.Drawing.Size(425, 169);
            this.Contact_Info.TabIndex = 13;
            this.Contact_Info.TabStop = false;
            this.Contact_Info.Text = "Contact Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 548);
            this.Controls.Add(this.Contact_Info);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Contact_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Contact_List.ResumeLayout(false);
            this.Contact_List.PerformLayout();
            this.Contact_Info.ResumeLayout(false);
            this.Contact_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.RichTextBox RichBox;
        private System.Windows.Forms.GroupBox Contact_List;
        private System.Windows.Forms.TextBox Search_Text;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.ComboBox type_text;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox city_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox mobile_text;
        private System.Windows.Forms.GroupBox Contact_Info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

