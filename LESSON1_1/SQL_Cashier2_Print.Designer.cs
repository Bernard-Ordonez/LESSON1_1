namespace LESSON1_1
{
    partial class SQL_Cashier2_Print
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
            this.title_label = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.printDisplayListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(107, 30);
            this.title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(458, 37);
            this.title_label.TabIndex = 5;
            this.title_label.Text = "Chicken, Pork, and Beef Restaurant!";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(495, 501);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(9, 4);
            this.checkedListBox1.TabIndex = 4;
            // 
            // printDisplayListBox
            // 
            this.printDisplayListBox.FormattingEnabled = true;
            this.printDisplayListBox.ItemHeight = 16;
            this.printDisplayListBox.Location = new System.Drawing.Point(31, 71);
            this.printDisplayListBox.Margin = new System.Windows.Forms.Padding(4);
            this.printDisplayListBox.Name = "printDisplayListBox";
            this.printDisplayListBox.Size = new System.Drawing.Size(617, 500);
            this.printDisplayListBox.TabIndex = 3;
            // 
            // SQL_Cashier2_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 806);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.printDisplayListBox);
            this.Name = "SQL_Cashier2_Print";
            this.Text = "SQL_Cashier2_Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        public System.Windows.Forms.ListBox printDisplayListBox;
    }
}