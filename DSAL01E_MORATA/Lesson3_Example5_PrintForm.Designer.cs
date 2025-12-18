namespace DSAL01E_MORATA
{
    partial class Lesson3_Example5_PrintForm
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
            this.SuspendLayout();
            // 
            // printDisplayListBox
            // 
            this.printDisplayListBox.FormattingEnabled = true;
            this.printDisplayListBox.Location = new System.Drawing.Point(12, 12);
            this.printDisplayListBox.Name = "printDisplayListBox";
            this.printDisplayListBox.Size = new System.Drawing.Size(331, 446);
            this.printDisplayListBox.TabIndex = 0;
            // 
            // Lesson3_Example5_PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 466);
            this.Controls.Add(this.printDisplayListBox);
            this.Name = "Lesson3_Example5_PrintForm";
            this.Text = "Lesson3_Example5_PrintForm";
            this.Load += new System.EventHandler(this.Lesson3_Example5_PrintForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox printDisplayListBox;
    }
}