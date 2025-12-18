namespace DSAL01E_MORATA
{
    partial class Lesson14_Activity8_Cashier1
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
            this.exit_button = new System.Windows.Forms.Button();
            this.option_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.optionInput_textBox = new System.Windows.Forms.TextBox();
            this.option_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.option_comboBox);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.search_button);
            this.panel1.Controls.Add(this.optionInput_textBox);
            this.panel1.Controls.Add(this.option_label);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1454, 513);
            this.panel1.TabIndex = 0;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.IndianRed;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(1090, 28);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(132, 30);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // option_comboBox
            // 
            this.option_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_comboBox.FormattingEnabled = true;
            this.option_comboBox.Items.AddRange(new object[] {
            "employee_number",
            "surname",
            "firstname",
            "gross_income",
            "net_income",
            "pay_date"});
            this.option_comboBox.Location = new System.Drawing.Point(172, 28);
            this.option_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.option_comboBox.Name = "option_comboBox";
            this.option_comboBox.Size = new System.Drawing.Size(311, 26);
            this.option_comboBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1447, 443);
            this.dataGridView1.TabIndex = 5;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(949, 28);
            this.back_button.Margin = new System.Windows.Forms.Padding(4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(132, 30);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.LightGreen;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.Black;
            this.search_button.Location = new System.Drawing.Point(809, 28);
            this.search_button.Margin = new System.Windows.Forms.Padding(4);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(132, 30);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // optionInput_textBox
            // 
            this.optionInput_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionInput_textBox.Location = new System.Drawing.Point(491, 31);
            this.optionInput_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.optionInput_textBox.Name = "optionInput_textBox";
            this.optionInput_textBox.Size = new System.Drawing.Size(310, 24);
            this.optionInput_textBox.TabIndex = 2;
            // 
            // option_label
            // 
            this.option_label.AutoSize = true;
            this.option_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_label.Location = new System.Drawing.Point(29, 31);
            this.option_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.option_label.Name = "option_label";
            this.option_label.Size = new System.Drawing.Size(135, 18);
            this.option_label.TabIndex = 1;
            this.option_label.Text = "Select an option:";
            // 
            // Lesson14_Activity8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 543);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lesson14_Activity8";
            this.Text = "Sales Reports (Cashier 1)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lesson14_Activity8_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox optionInput_textBox;
        private System.Windows.Forms.Label option_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.ComboBox option_comboBox;
        private System.Windows.Forms.Button exit_button;
    }
}