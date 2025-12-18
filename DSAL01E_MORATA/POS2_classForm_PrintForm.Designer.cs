namespace DSAL01E_MORATA
{
    partial class POS2_classForm_PrintForm
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
            this.printDisplayListBox = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.title_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printDisplayListBox
            // 
            this.printDisplayListBox.FormattingEnabled = true;
            this.printDisplayListBox.Location = new System.Drawing.Point(12, 59);
            this.printDisplayListBox.Name = "printDisplayListBox";
            this.printDisplayListBox.Size = new System.Drawing.Size(464, 407);
            this.printDisplayListBox.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(360, 409);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Algerian", 18F);
            this.title_label.Location = new System.Drawing.Point(43, 20);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(402, 26);
            this.title_label.TabIndex = 2;
            this.title_label.Text = "4JEE FOOD ORDERING APPLICATION";
            // 
            // POS2_classForm_PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 478);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.printDisplayListBox);
            this.Name = "POS2_classForm_PrintForm";
            this.Text = "POS2_classForm_PrintForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label title_label;
        public System.Windows.Forms.ListBox printDisplayListBox;
    }
}