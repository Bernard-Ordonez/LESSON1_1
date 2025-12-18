namespace DSAL01E_MORATA
{
    partial class Lesson13_Example1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.new_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dept_label = new System.Windows.Forms.Label();
            this.studName_label = new System.Windows.Forms.Label();
            this.studNum_label = new System.Windows.Forms.Label();
            this.dept_textBox = new System.Windows.Forms.TextBox();
            this.studName_textBox = new System.Windows.Forms.TextBox();
            this.studNum_textBox = new System.Windows.Forms.TextBox();
            this.picPath_textBox = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.picPath_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPath_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.new_button);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.edit_button);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.search_button);
            this.panel1.Controls.Add(this.save_button);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dept_label);
            this.panel1.Controls.Add(this.studName_label);
            this.panel1.Controls.Add(this.studNum_label);
            this.panel1.Controls.Add(this.dept_textBox);
            this.panel1.Controls.Add(this.studName_textBox);
            this.panel1.Controls.Add(this.studNum_textBox);
            this.panel1.Controls.Add(this.picPath_textBox);
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Controls.Add(this.picPath_pictureBox);
            this.panel1.Location = new System.Drawing.Point(18, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1703, 642);
            this.panel1.TabIndex = 0;
            // 
            // new_button
            // 
            this.new_button.BackColor = System.Drawing.Color.Ivory;
            this.new_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_button.Location = new System.Drawing.Point(1359, 572);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(333, 54);
            this.new_button.TabIndex = 15;
            this.new_button.Text = "New";
            this.new_button.UseVisualStyleBackColor = false;
            this.new_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.LightGray;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Location = new System.Drawing.Point(1017, 572);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(333, 54);
            this.cancel_button.TabIndex = 14;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.Orange;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(675, 572);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(333, 54);
            this.edit_button.TabIndex = 13;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Firebrick;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(1359, 510);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(333, 54);
            this.delete_button.TabIndex = 12;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(1017, 510);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(333, 54);
            this.search_button.TabIndex = 11;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.ForestGreen;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.ForeColor = System.Drawing.Color.White;
            this.save_button.Location = new System.Drawing.Point(675, 510);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(333, 54);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(675, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1017, 247);
            this.dataGridView1.TabIndex = 10;
            // 
            // dept_label
            // 
            this.dept_label.AutoSize = true;
            this.dept_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_label.Location = new System.Drawing.Point(668, 218);
            this.dept_label.Name = "dept_label";
            this.dept_label.Size = new System.Drawing.Size(109, 20);
            this.dept_label.TabIndex = 9;
            this.dept_label.Text = "Department:";
            // 
            // studName_label
            // 
            this.studName_label.AutoSize = true;
            this.studName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studName_label.Location = new System.Drawing.Point(668, 179);
            this.studName_label.Name = "studName_label";
            this.studName_label.Size = new System.Drawing.Size(129, 20);
            this.studName_label.TabIndex = 8;
            this.studName_label.Text = "Student Name:";
            // 
            // studNum_label
            // 
            this.studNum_label.AutoSize = true;
            this.studNum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studNum_label.Location = new System.Drawing.Point(668, 140);
            this.studNum_label.Name = "studNum_label";
            this.studNum_label.Size = new System.Drawing.Size(145, 20);
            this.studNum_label.TabIndex = 7;
            this.studNum_label.Text = "Student Number:";
            // 
            // dept_textBox
            // 
            this.dept_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_textBox.Location = new System.Drawing.Point(821, 214);
            this.dept_textBox.Name = "dept_textBox";
            this.dept_textBox.Size = new System.Drawing.Size(868, 26);
            this.dept_textBox.TabIndex = 6;
            // 
            // studName_textBox
            // 
            this.studName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studName_textBox.Location = new System.Drawing.Point(821, 174);
            this.studName_textBox.Name = "studName_textBox";
            this.studName_textBox.Size = new System.Drawing.Size(868, 26);
            this.studName_textBox.TabIndex = 5;
            // 
            // studNum_textBox
            // 
            this.studNum_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studNum_textBox.Location = new System.Drawing.Point(821, 137);
            this.studNum_textBox.Name = "studNum_textBox";
            this.studNum_textBox.Size = new System.Drawing.Size(670, 26);
            this.studNum_textBox.TabIndex = 4;
            // 
            // picPath_textBox
            // 
            this.picPath_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picPath_textBox.Location = new System.Drawing.Point(821, 96);
            this.picPath_textBox.Name = "picPath_textBox";
            this.picPath_textBox.Size = new System.Drawing.Size(670, 26);
            this.picPath_textBox.TabIndex = 3;
            this.picPath_textBox.Visible = false;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("BankGothic Md BT", 42.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(670, 42);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(1019, 59);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "L13 - E1 | SAMPLE PROGRAM";
            // 
            // picPath_pictureBox
            // 
            this.picPath_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPath_pictureBox.Location = new System.Drawing.Point(17, 13);
            this.picPath_pictureBox.Name = "picPath_pictureBox";
            this.picPath_pictureBox.Size = new System.Drawing.Size(640, 613);
            this.picPath_pictureBox.TabIndex = 0;
            this.picPath_pictureBox.TabStop = false;
            this.picPath_pictureBox.Click += new System.EventHandler(this.browsePic_button_Click);
            // 
            // Lesson13_Example1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1777, 724);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Lesson13_Example1";
            this.Text = "SampleLongMethod";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lesson13_Example1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPath_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPath_pictureBox;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label dept_label;
        private System.Windows.Forms.Label studName_label;
        private System.Windows.Forms.Label studNum_label;
        private System.Windows.Forms.TextBox dept_textBox;
        private System.Windows.Forms.TextBox studName_textBox;
        private System.Windows.Forms.TextBox studNum_textBox;
        private System.Windows.Forms.TextBox picPath_textBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button search_button;
    }
}