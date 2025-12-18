namespace DSAL01E_MORATA
{
    partial class Lesson5_Example2
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
            this.productPrice_label = new System.Windows.Forms.Label();
            this.seniorCitizenDisc_label = new System.Windows.Forms.Label();
            this.productPrice_textBox = new System.Windows.Forms.TextBox();
            this.seniorCitizenDisc_textBox = new System.Windows.Forms.TextBox();
            this.compute_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productPrice_label
            // 
            this.productPrice_label.AutoSize = true;
            this.productPrice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice_label.Location = new System.Drawing.Point(86, 69);
            this.productPrice_label.Name = "productPrice_label";
            this.productPrice_label.Size = new System.Drawing.Size(346, 31);
            this.productPrice_label.TabIndex = 0;
            this.productPrice_label.Text = "Write a price of the product:";
            // 
            // seniorCitizenDisc_label
            // 
            this.seniorCitizenDisc_label.AutoSize = true;
            this.seniorCitizenDisc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniorCitizenDisc_label.Location = new System.Drawing.Point(66, 122);
            this.seniorCitizenDisc_label.Name = "seniorCitizenDisc_label";
            this.seniorCitizenDisc_label.Size = new System.Drawing.Size(366, 31);
            this.seniorCitizenDisc_label.TabIndex = 1;
            this.seniorCitizenDisc_label.Text = "20% Senior Citizen Discount:";
            // 
            // productPrice_textBox
            // 
            this.productPrice_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice_textBox.Location = new System.Drawing.Point(438, 60);
            this.productPrice_textBox.Name = "productPrice_textBox";
            this.productPrice_textBox.Size = new System.Drawing.Size(249, 47);
            this.productPrice_textBox.TabIndex = 2;
            this.productPrice_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // seniorCitizenDisc_textBox
            // 
            this.seniorCitizenDisc_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniorCitizenDisc_textBox.Location = new System.Drawing.Point(438, 113);
            this.seniorCitizenDisc_textBox.Name = "seniorCitizenDisc_textBox";
            this.seniorCitizenDisc_textBox.Size = new System.Drawing.Size(249, 47);
            this.seniorCitizenDisc_textBox.TabIndex = 3;
            this.seniorCitizenDisc_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // compute_button
            // 
            this.compute_button.BackColor = System.Drawing.Color.LightGreen;
            this.compute_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compute_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compute_button.Location = new System.Drawing.Point(72, 194);
            this.compute_button.Name = "compute_button";
            this.compute_button.Size = new System.Drawing.Size(276, 55);
            this.compute_button.TabIndex = 4;
            this.compute_button.Text = "Compute Discount";
            this.compute_button.UseVisualStyleBackColor = false;
            this.compute_button.Click += new System.EventHandler(this.compute_button_Click);
            // 
            // new_button
            // 
            this.new_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.new_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_button.Location = new System.Drawing.Point(354, 194);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(162, 55);
            this.new_button.TabIndex = 5;
            this.new_button.Text = "New";
            this.new_button.UseVisualStyleBackColor = false;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Crimson;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.Location = new System.Drawing.Point(522, 194);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(165, 55);
            this.close_button.TabIndex = 6;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Lesson5_Example2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.compute_button);
            this.Controls.Add(this.seniorCitizenDisc_textBox);
            this.Controls.Add(this.productPrice_textBox);
            this.Controls.Add(this.seniorCitizenDisc_label);
            this.Controls.Add(this.productPrice_label);
            this.Name = "Lesson5_Example2";
            this.Text = "Lesson5_Example2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productPrice_label;
        private System.Windows.Forms.Label seniorCitizenDisc_label;
        private System.Windows.Forms.TextBox productPrice_textBox;
        private System.Windows.Forms.TextBox seniorCitizenDisc_textBox;
        private System.Windows.Forms.Button compute_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button close_button;
    }
}