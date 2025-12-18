using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAL01E_MORATA
{
    partial class Payroll_functionForm_SaveForm
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
            this.earnings_label = new System.Windows.Forms.Label();
            this.basicPay_label = new System.Windows.Forms.Label();
            this.overtime_label = new System.Windows.Forms.Label();
            this.honorarium_label = new System.Windows.Forms.Label();
            this.honorAdjust_label = new System.Windows.Forms.Label();
            this.substitution_label = new System.Windows.Forms.Label();
            this.tardy_label = new System.Windows.Forms.Label();
            this.dayHrs_label = new System.Windows.Forms.Label();
            this.taxable_label = new System.Windows.Forms.Label();
            this.nonTaxable_label = new System.Windows.Forms.Label();
            this.earnings_label2 = new System.Windows.Forms.Label();
            this.amount_label = new System.Windows.Forms.Label();
            this.SSSwisp_label = new System.Windows.Forms.Label();
            this.philHealth_label = new System.Windows.Forms.Label();
            this.HDMF_label = new System.Windows.Forms.Label();
            this.sssContrib_label = new System.Windows.Forms.Label();
            this.withholding_label = new System.Windows.Forms.Label();
            this.deductions_label = new System.Windows.Forms.Label();
            this.deductions_label2 = new System.Windows.Forms.Label();
            this.overtime_label2 = new System.Windows.Forms.Label();
            this.overtime_label1 = new System.Windows.Forms.Label();
            this.zeroPoint_label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payPeriod_textBox = new System.Windows.Forms.TextBox();
            this.empName_textBox = new System.Windows.Forms.TextBox();
            this.payPeriod_label = new System.Windows.Forms.Label();
            this.empName_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cuOff_textBox = new System.Windows.Forms.TextBox();
            this.empCode_textBox = new System.Windows.Forms.TextBox();
            this.cutOff_label = new System.Windows.Forms.Label();
            this.empCode_label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.department_textBox = new System.Windows.Forms.TextBox();
            this.company_textBox = new System.Windows.Forms.TextBox();
            this.department_label = new System.Windows.Forms.Label();
            this.company_label = new System.Windows.Forms.Label();
            this.grossEarnings_label = new System.Windows.Forms.Label();
            this.deductions_label3 = new System.Windows.Forms.Label();
            this.netPay_label = new System.Windows.Forms.Label();
            this.reminder_label = new System.Windows.Forms.Label();
            this.withholding_textBox = new System.Windows.Forms.TextBox();
            this.sssContrib_textBox = new System.Windows.Forms.TextBox();
            this.HDMF_textBox = new System.Windows.Forms.TextBox();
            this.philHealth_textBox = new System.Windows.Forms.TextBox();
            this.WISP_textBox = new System.Windows.Forms.TextBox();
            this.substitution_textBox = new System.Windows.Forms.TextBox();
            this.honorAdj_textBox = new System.Windows.Forms.TextBox();
            this.honor_textBox = new System.Windows.Forms.TextBox();
            this.overtime_textBox = new System.Windows.Forms.TextBox();
            this.basicPay_textBox = new System.Windows.Forms.TextBox();
            this.tardy_textBox = new System.Windows.Forms.TextBox();
            this.grossEarnings_textBox = new System.Windows.Forms.TextBox();
            this.deductions_textBox = new System.Windows.Forms.TextBox();
            this.netPay_textBox = new System.Windows.Forms.TextBox();
            this.deductions_textBox2 = new System.Windows.Forms.TextBox();
            this.earnings_textBox = new System.Windows.Forms.TextBox();
            this.hrs_textBox = new System.Windows.Forms.TextBox();
            this.hrs_textBox2 = new System.Windows.Forms.TextBox();
            this.hrs_textBox3 = new System.Windows.Forms.TextBox();
            this.hrs_textBox4 = new System.Windows.Forms.TextBox();
            this.hrs_textBox5 = new System.Windows.Forms.TextBox();
            this.hrs_textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // earnings_label
            // 
            this.earnings_label.AutoSize = true;
            this.earnings_label.BackColor = System.Drawing.Color.LightGray;
            this.earnings_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnings_label.Location = new System.Drawing.Point(10, 157);
            this.earnings_label.Name = "earnings_label";
            this.earnings_label.Padding = new System.Windows.Forms.Padding(129, 9, 129, 9);
            this.earnings_label.Size = new System.Drawing.Size(325, 33);
            this.earnings_label.TabIndex = 0;
            this.earnings_label.Text = "EARNINGS";
            // 
            // basicPay_label
            // 
            this.basicPay_label.AutoSize = true;
            this.basicPay_label.Location = new System.Drawing.Point(10, 205);
            this.basicPay_label.Name = "basicPay_label";
            this.basicPay_label.Size = new System.Drawing.Size(54, 13);
            this.basicPay_label.TabIndex = 1;
            this.basicPay_label.Text = "Basic Pay";
            // 
            // overtime_label
            // 
            this.overtime_label.AutoSize = true;
            this.overtime_label.Location = new System.Drawing.Point(10, 231);
            this.overtime_label.Name = "overtime_label";
            this.overtime_label.Size = new System.Drawing.Size(49, 13);
            this.overtime_label.TabIndex = 2;
            this.overtime_label.Text = "Overtime";
            // 
            // honorarium_label
            // 
            this.honorarium_label.AutoSize = true;
            this.honorarium_label.Location = new System.Drawing.Point(10, 256);
            this.honorarium_label.Name = "honorarium_label";
            this.honorarium_label.Size = new System.Drawing.Size(61, 13);
            this.honorarium_label.TabIndex = 3;
            this.honorarium_label.Text = "Honorarium";
            // 
            // honorAdjust_label
            // 
            this.honorAdjust_label.AutoSize = true;
            this.honorAdjust_label.Location = new System.Drawing.Point(10, 281);
            this.honorAdjust_label.Name = "honorAdjust_label";
            this.honorAdjust_label.Size = new System.Drawing.Size(116, 13);
            this.honorAdjust_label.TabIndex = 4;
            this.honorAdjust_label.Text = "Honorarium Adjustment";
            // 
            // substitution_label
            // 
            this.substitution_label.AutoSize = true;
            this.substitution_label.Location = new System.Drawing.Point(10, 306);
            this.substitution_label.Name = "substitution_label";
            this.substitution_label.Size = new System.Drawing.Size(91, 13);
            this.substitution_label.TabIndex = 5;
            this.substitution_label.Text = "Substitution (LAB)";
            // 
            // tardy_label
            // 
            this.tardy_label.AutoSize = true;
            this.tardy_label.Location = new System.Drawing.Point(10, 331);
            this.tardy_label.Name = "tardy_label";
            this.tardy_label.Size = new System.Drawing.Size(34, 13);
            this.tardy_label.TabIndex = 6;
            this.tardy_label.Text = "Tardy";
            // 
            // dayHrs_label
            // 
            this.dayHrs_label.AutoSize = true;
            this.dayHrs_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayHrs_label.Location = new System.Drawing.Point(164, 187);
            this.dayHrs_label.Name = "dayHrs_label";
            this.dayHrs_label.Size = new System.Drawing.Size(52, 15);
            this.dayHrs_label.TabIndex = 8;
            this.dayHrs_label.Text = "Day/Hrs";
            // 
            // taxable_label
            // 
            this.taxable_label.AutoSize = true;
            this.taxable_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxable_label.Location = new System.Drawing.Point(213, 187);
            this.taxable_label.Name = "taxable_label";
            this.taxable_label.Size = new System.Drawing.Size(49, 15);
            this.taxable_label.TabIndex = 9;
            this.taxable_label.Text = "Taxable";
            // 
            // nonTaxable_label
            // 
            this.nonTaxable_label.AutoSize = true;
            this.nonTaxable_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonTaxable_label.Location = new System.Drawing.Point(261, 187);
            this.nonTaxable_label.Name = "nonTaxable_label";
            this.nonTaxable_label.Size = new System.Drawing.Size(75, 15);
            this.nonTaxable_label.TabIndex = 10;
            this.nonTaxable_label.Text = "Non Taxable";
            // 
            // earnings_label2
            // 
            this.earnings_label2.AutoSize = true;
            this.earnings_label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnings_label2.Location = new System.Drawing.Point(10, 362);
            this.earnings_label2.Name = "earnings_label2";
            this.earnings_label2.Size = new System.Drawing.Size(67, 15);
            this.earnings_label2.TabIndex = 11;
            this.earnings_label2.Text = "EARNINGS";
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label.Location = new System.Drawing.Point(614, 187);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(52, 15);
            this.amount_label.TabIndex = 22;
            this.amount_label.Text = "Amount";
            // 
            // SSSwisp_label
            // 
            this.SSSwisp_label.AutoSize = true;
            this.SSSwisp_label.Location = new System.Drawing.Point(330, 306);
            this.SSSwisp_label.Name = "SSSwisp_label";
            this.SSSwisp_label.Size = new System.Drawing.Size(124, 13);
            this.SSSwisp_label.TabIndex = 18;
            this.SSSwisp_label.Text = "SSS WISP - Contribution";
            // 
            // philHealth_label
            // 
            this.philHealth_label.AutoSize = true;
            this.philHealth_label.Location = new System.Drawing.Point(330, 281);
            this.philHealth_label.Name = "philHealth_label";
            this.philHealth_label.Size = new System.Drawing.Size(118, 13);
            this.philHealth_label.TabIndex = 17;
            this.philHealth_label.Text = "Philhealth - Contribution";
            // 
            // HDMF_label
            // 
            this.HDMF_label.AutoSize = true;
            this.HDMF_label.Location = new System.Drawing.Point(330, 256);
            this.HDMF_label.Name = "HDMF_label";
            this.HDMF_label.Size = new System.Drawing.Size(103, 13);
            this.HDMF_label.TabIndex = 16;
            this.HDMF_label.Text = "HDMF - Contribution";
            // 
            // sssContrib_label
            // 
            this.sssContrib_label.AutoSize = true;
            this.sssContrib_label.Location = new System.Drawing.Point(330, 231);
            this.sssContrib_label.Name = "sssContrib_label";
            this.sssContrib_label.Size = new System.Drawing.Size(93, 13);
            this.sssContrib_label.TabIndex = 15;
            this.sssContrib_label.Text = "SSS - Contribution";
            // 
            // withholding_label
            // 
            this.withholding_label.AutoSize = true;
            this.withholding_label.Location = new System.Drawing.Point(330, 205);
            this.withholding_label.Name = "withholding_label";
            this.withholding_label.Size = new System.Drawing.Size(78, 13);
            this.withholding_label.TabIndex = 14;
            this.withholding_label.Text = "Witholding Tax";
            // 
            // deductions_label
            // 
            this.deductions_label.AutoSize = true;
            this.deductions_label.BackColor = System.Drawing.Color.LightGray;
            this.deductions_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductions_label.Location = new System.Drawing.Point(330, 157);
            this.deductions_label.Name = "deductions_label";
            this.deductions_label.Padding = new System.Windows.Forms.Padding(129, 9, 129, 9);
            this.deductions_label.Size = new System.Drawing.Size(341, 33);
            this.deductions_label.TabIndex = 13;
            this.deductions_label.Text = "DEDUCTIONS";
            // 
            // deductions_label2
            // 
            this.deductions_label2.AutoSize = true;
            this.deductions_label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductions_label2.Location = new System.Drawing.Point(330, 362);
            this.deductions_label2.Name = "deductions_label2";
            this.deductions_label2.Size = new System.Drawing.Size(83, 15);
            this.deductions_label2.TabIndex = 23;
            this.deductions_label2.Text = "DEDUCTIONS";
            // 
            // overtime_label2
            // 
            this.overtime_label2.AutoSize = true;
            this.overtime_label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overtime_label2.Location = new System.Drawing.Point(663, 362);
            this.overtime_label2.Name = "overtime_label2";
            this.overtime_label2.Size = new System.Drawing.Size(66, 15);
            this.overtime_label2.TabIndex = 31;
            this.overtime_label2.Text = "OVERTIME";
            // 
            // overtime_label1
            // 
            this.overtime_label1.AutoSize = true;
            this.overtime_label1.BackColor = System.Drawing.Color.LightGray;
            this.overtime_label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overtime_label1.Location = new System.Drawing.Point(663, 157);
            this.overtime_label1.Name = "overtime_label1";
            this.overtime_label1.Padding = new System.Windows.Forms.Padding(67, 9, 67, 9);
            this.overtime_label1.Size = new System.Drawing.Size(352, 33);
            this.overtime_label1.TabIndex = 24;
            this.overtime_label1.Text = "OVERTIME AND NIGHT DIFFERENTIAL";
            // 
            // zeroPoint_label2
            // 
            this.zeroPoint_label2.AutoSize = true;
            this.zeroPoint_label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroPoint_label2.Location = new System.Drawing.Point(957, 362);
            this.zeroPoint_label2.Name = "zeroPoint_label2";
            this.zeroPoint_label2.Size = new System.Drawing.Size(31, 15);
            this.zeroPoint_label2.TabIndex = 32;
            this.zeroPoint_label2.Text = "0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.payPeriod_textBox);
            this.groupBox1.Controls.Add(this.empName_textBox);
            this.groupBox1.Controls.Add(this.payPeriod_label);
            this.groupBox1.Controls.Add(this.empName_label);
            this.groupBox1.Location = new System.Drawing.Point(10, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(974, 43);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // payPeriod_textBox
            // 
            this.payPeriod_textBox.BackColor = System.Drawing.Color.White;
            this.payPeriod_textBox.Location = new System.Drawing.Point(653, 14);
            this.payPeriod_textBox.Name = "payPeriod_textBox";
            this.payPeriod_textBox.Size = new System.Drawing.Size(316, 20);
            this.payPeriod_textBox.TabIndex = 40;
            this.payPeriod_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // empName_textBox
            // 
            this.empName_textBox.BackColor = System.Drawing.Color.White;
            this.empName_textBox.Location = new System.Drawing.Point(90, 16);
            this.empName_textBox.Name = "empName_textBox";
            this.empName_textBox.Size = new System.Drawing.Size(493, 20);
            this.empName_textBox.TabIndex = 40;
            this.empName_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.empName_textBox.TextChanged += new System.EventHandler(this.empName_textBox_TextChanged);
            // 
            // payPeriod_label
            // 
            this.payPeriod_label.AutoSize = true;
            this.payPeriod_label.Location = new System.Drawing.Point(587, 18);
            this.payPeriod_label.Name = "payPeriod_label";
            this.payPeriod_label.Size = new System.Drawing.Size(61, 13);
            this.payPeriod_label.TabIndex = 39;
            this.payPeriod_label.Text = "Pay Period:";
            // 
            // empName_label
            // 
            this.empName_label.AutoSize = true;
            this.empName_label.Location = new System.Drawing.Point(5, 18);
            this.empName_label.Name = "empName_label";
            this.empName_label.Size = new System.Drawing.Size(87, 13);
            this.empName_label.TabIndex = 34;
            this.empName_label.Text = "Employee Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cuOff_textBox);
            this.groupBox2.Controls.Add(this.empCode_textBox);
            this.groupBox2.Controls.Add(this.cutOff_label);
            this.groupBox2.Controls.Add(this.empCode_label);
            this.groupBox2.Location = new System.Drawing.Point(10, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(974, 43);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // cuOff_textBox
            // 
            this.cuOff_textBox.BackColor = System.Drawing.Color.White;
            this.cuOff_textBox.Location = new System.Drawing.Point(653, 16);
            this.cuOff_textBox.Name = "cuOff_textBox";
            this.cuOff_textBox.Size = new System.Drawing.Size(316, 20);
            this.cuOff_textBox.TabIndex = 39;
            this.cuOff_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // empCode_textBox
            // 
            this.empCode_textBox.BackColor = System.Drawing.Color.White;
            this.empCode_textBox.Location = new System.Drawing.Point(90, 16);
            this.empCode_textBox.Name = "empCode_textBox";
            this.empCode_textBox.Size = new System.Drawing.Size(493, 20);
            this.empCode_textBox.TabIndex = 39;
            this.empCode_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cutOff_label
            // 
            this.cutOff_label.AutoSize = true;
            this.cutOff_label.Location = new System.Drawing.Point(587, 18);
            this.cutOff_label.Name = "cutOff_label";
            this.cutOff_label.Size = new System.Drawing.Size(43, 13);
            this.cutOff_label.TabIndex = 38;
            this.cutOff_label.Text = "Cut-Off:";
            // 
            // empCode_label
            // 
            this.empCode_label.AutoSize = true;
            this.empCode_label.Location = new System.Drawing.Point(5, 18);
            this.empCode_label.Name = "empCode_label";
            this.empCode_label.Size = new System.Drawing.Size(84, 13);
            this.empCode_label.TabIndex = 34;
            this.empCode_label.Text = "Employee Code:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.department_textBox);
            this.groupBox3.Controls.Add(this.company_textBox);
            this.groupBox3.Controls.Add(this.department_label);
            this.groupBox3.Controls.Add(this.company_label);
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(974, 43);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // department_textBox
            // 
            this.department_textBox.BackColor = System.Drawing.Color.White;
            this.department_textBox.Location = new System.Drawing.Point(653, 16);
            this.department_textBox.Name = "department_textBox";
            this.department_textBox.Size = new System.Drawing.Size(316, 20);
            this.department_textBox.TabIndex = 42;
            this.department_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // company_textBox
            // 
            this.company_textBox.BackColor = System.Drawing.Color.White;
            this.company_textBox.Location = new System.Drawing.Point(90, 16);
            this.company_textBox.Name = "company_textBox";
            this.company_textBox.Size = new System.Drawing.Size(493, 20);
            this.company_textBox.TabIndex = 38;
            this.company_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Location = new System.Drawing.Point(587, 18);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(65, 13);
            this.department_label.TabIndex = 37;
            this.department_label.Text = "Department:";
            // 
            // company_label
            // 
            this.company_label.AutoSize = true;
            this.company_label.Location = new System.Drawing.Point(5, 18);
            this.company_label.Name = "company_label";
            this.company_label.Size = new System.Drawing.Size(54, 13);
            this.company_label.TabIndex = 34;
            this.company_label.Text = "Company:";
            // 
            // grossEarnings_label
            // 
            this.grossEarnings_label.AutoSize = true;
            this.grossEarnings_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossEarnings_label.Location = new System.Drawing.Point(663, 400);
            this.grossEarnings_label.Name = "grossEarnings_label";
            this.grossEarnings_label.Size = new System.Drawing.Size(110, 15);
            this.grossEarnings_label.TabIndex = 38;
            this.grossEarnings_label.Text = "GROSS EARNINGS";
            // 
            // deductions_label3
            // 
            this.deductions_label3.AutoSize = true;
            this.deductions_label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductions_label3.Location = new System.Drawing.Point(663, 425);
            this.deductions_label3.Name = "deductions_label3";
            this.deductions_label3.Size = new System.Drawing.Size(83, 15);
            this.deductions_label3.TabIndex = 39;
            this.deductions_label3.Text = "DEDUCTIONS";
            // 
            // netPay_label
            // 
            this.netPay_label.AutoSize = true;
            this.netPay_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netPay_label.Location = new System.Drawing.Point(663, 450);
            this.netPay_label.Name = "netPay_label";
            this.netPay_label.Size = new System.Drawing.Size(52, 15);
            this.netPay_label.TabIndex = 40;
            this.netPay_label.Text = "NET PAY";
            // 
            // reminder_label
            // 
            this.reminder_label.AutoSize = true;
            this.reminder_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminder_label.Location = new System.Drawing.Point(345, 485);
            this.reminder_label.Name = "reminder_label";
            this.reminder_label.Size = new System.Drawing.Size(365, 15);
            this.reminder_label.TabIndex = 41;
            this.reminder_label.Text = "THIS IS A SYSTEM-GENERATED PAYSLIP NO SIGNATURE REQUIRED.";
            // 
            // withholding_textBox
            // 
            this.withholding_textBox.BackColor = System.Drawing.Color.White;
            this.withholding_textBox.Location = new System.Drawing.Point(614, 203);
            this.withholding_textBox.Name = "withholding_textBox";
            this.withholding_textBox.Size = new System.Drawing.Size(45, 20);
            this.withholding_textBox.TabIndex = 42;
            this.withholding_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sssContrib_textBox
            // 
            this.sssContrib_textBox.BackColor = System.Drawing.Color.White;
            this.sssContrib_textBox.Location = new System.Drawing.Point(614, 228);
            this.sssContrib_textBox.Name = "sssContrib_textBox";
            this.sssContrib_textBox.Size = new System.Drawing.Size(45, 20);
            this.sssContrib_textBox.TabIndex = 43;
            this.sssContrib_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HDMF_textBox
            // 
            this.HDMF_textBox.BackColor = System.Drawing.Color.White;
            this.HDMF_textBox.Location = new System.Drawing.Point(614, 253);
            this.HDMF_textBox.Name = "HDMF_textBox";
            this.HDMF_textBox.Size = new System.Drawing.Size(45, 20);
            this.HDMF_textBox.TabIndex = 44;
            this.HDMF_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // philHealth_textBox
            // 
            this.philHealth_textBox.BackColor = System.Drawing.Color.White;
            this.philHealth_textBox.Location = new System.Drawing.Point(614, 278);
            this.philHealth_textBox.Name = "philHealth_textBox";
            this.philHealth_textBox.Size = new System.Drawing.Size(45, 20);
            this.philHealth_textBox.TabIndex = 45;
            this.philHealth_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WISP_textBox
            // 
            this.WISP_textBox.BackColor = System.Drawing.Color.White;
            this.WISP_textBox.Location = new System.Drawing.Point(614, 303);
            this.WISP_textBox.Name = "WISP_textBox";
            this.WISP_textBox.Size = new System.Drawing.Size(45, 20);
            this.WISP_textBox.TabIndex = 46;
            this.WISP_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // substitution_textBox
            // 
            this.substitution_textBox.BackColor = System.Drawing.Color.White;
            this.substitution_textBox.Location = new System.Drawing.Point(213, 303);
            this.substitution_textBox.Name = "substitution_textBox";
            this.substitution_textBox.Size = new System.Drawing.Size(112, 20);
            this.substitution_textBox.TabIndex = 51;
            this.substitution_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // honorAdj_textBox
            // 
            this.honorAdj_textBox.BackColor = System.Drawing.Color.White;
            this.honorAdj_textBox.Location = new System.Drawing.Point(213, 278);
            this.honorAdj_textBox.Name = "honorAdj_textBox";
            this.honorAdj_textBox.Size = new System.Drawing.Size(112, 20);
            this.honorAdj_textBox.TabIndex = 50;
            this.honorAdj_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // honor_textBox
            // 
            this.honor_textBox.BackColor = System.Drawing.Color.White;
            this.honor_textBox.Location = new System.Drawing.Point(213, 253);
            this.honor_textBox.Name = "honor_textBox";
            this.honor_textBox.Size = new System.Drawing.Size(112, 20);
            this.honor_textBox.TabIndex = 49;
            this.honor_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // overtime_textBox
            // 
            this.overtime_textBox.BackColor = System.Drawing.Color.White;
            this.overtime_textBox.Location = new System.Drawing.Point(213, 228);
            this.overtime_textBox.Name = "overtime_textBox";
            this.overtime_textBox.Size = new System.Drawing.Size(112, 20);
            this.overtime_textBox.TabIndex = 48;
            this.overtime_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // basicPay_textBox
            // 
            this.basicPay_textBox.BackColor = System.Drawing.Color.White;
            this.basicPay_textBox.Location = new System.Drawing.Point(213, 203);
            this.basicPay_textBox.Name = "basicPay_textBox";
            this.basicPay_textBox.Size = new System.Drawing.Size(112, 20);
            this.basicPay_textBox.TabIndex = 47;
            this.basicPay_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tardy_textBox
            // 
            this.tardy_textBox.BackColor = System.Drawing.Color.White;
            this.tardy_textBox.Location = new System.Drawing.Point(213, 328);
            this.tardy_textBox.Name = "tardy_textBox";
            this.tardy_textBox.Size = new System.Drawing.Size(112, 20);
            this.tardy_textBox.TabIndex = 52;
            this.tardy_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grossEarnings_textBox
            // 
            this.grossEarnings_textBox.BackColor = System.Drawing.Color.White;
            this.grossEarnings_textBox.Location = new System.Drawing.Point(908, 393);
            this.grossEarnings_textBox.Name = "grossEarnings_textBox";
            this.grossEarnings_textBox.Size = new System.Drawing.Size(77, 20);
            this.grossEarnings_textBox.TabIndex = 53;
            this.grossEarnings_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deductions_textBox
            // 
            this.deductions_textBox.BackColor = System.Drawing.Color.White;
            this.deductions_textBox.Location = new System.Drawing.Point(908, 418);
            this.deductions_textBox.Name = "deductions_textBox";
            this.deductions_textBox.Size = new System.Drawing.Size(77, 20);
            this.deductions_textBox.TabIndex = 54;
            this.deductions_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // netPay_textBox
            // 
            this.netPay_textBox.BackColor = System.Drawing.Color.White;
            this.netPay_textBox.Location = new System.Drawing.Point(908, 443);
            this.netPay_textBox.Name = "netPay_textBox";
            this.netPay_textBox.Size = new System.Drawing.Size(77, 20);
            this.netPay_textBox.TabIndex = 55;
            this.netPay_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deductions_textBox2
            // 
            this.deductions_textBox2.BackColor = System.Drawing.Color.White;
            this.deductions_textBox2.Location = new System.Drawing.Point(614, 355);
            this.deductions_textBox2.Name = "deductions_textBox2";
            this.deductions_textBox2.Size = new System.Drawing.Size(45, 20);
            this.deductions_textBox2.TabIndex = 56;
            this.deductions_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // earnings_textBox
            // 
            this.earnings_textBox.BackColor = System.Drawing.Color.White;
            this.earnings_textBox.Location = new System.Drawing.Point(213, 354);
            this.earnings_textBox.Name = "earnings_textBox";
            this.earnings_textBox.Size = new System.Drawing.Size(112, 20);
            this.earnings_textBox.TabIndex = 57;
            this.earnings_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hrs_textBox
            // 
            this.hrs_textBox.BackColor = System.Drawing.Color.White;
            this.hrs_textBox.Location = new System.Drawing.Point(164, 203);
            this.hrs_textBox.Name = "hrs_textBox";
            this.hrs_textBox.Size = new System.Drawing.Size(45, 20);
            this.hrs_textBox.TabIndex = 58;
            this.hrs_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hrs_textBox2
            // 
            this.hrs_textBox2.BackColor = System.Drawing.Color.White;
            this.hrs_textBox2.Location = new System.Drawing.Point(164, 228);
            this.hrs_textBox2.Name = "hrs_textBox2";
            this.hrs_textBox2.Size = new System.Drawing.Size(45, 20);
            this.hrs_textBox2.TabIndex = 59;
            this.hrs_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hrs_textBox3
            // 
            this.hrs_textBox3.BackColor = System.Drawing.Color.White;
            this.hrs_textBox3.Location = new System.Drawing.Point(164, 253);
            this.hrs_textBox3.Name = "hrs_textBox3";
            this.hrs_textBox3.Size = new System.Drawing.Size(45, 20);
            this.hrs_textBox3.TabIndex = 60;
            this.hrs_textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hrs_textBox4
            // 
            this.hrs_textBox4.BackColor = System.Drawing.Color.White;
            this.hrs_textBox4.Location = new System.Drawing.Point(164, 278);
            this.hrs_textBox4.Name = "hrs_textBox4";
            this.hrs_textBox4.Size = new System.Drawing.Size(45, 20);
            this.hrs_textBox4.TabIndex = 61;
            this.hrs_textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hrs_textBox5
            // 
            this.hrs_textBox5.BackColor = System.Drawing.Color.White;
            this.hrs_textBox5.Location = new System.Drawing.Point(164, 303);
            this.hrs_textBox5.Name = "hrs_textBox5";
            this.hrs_textBox5.Size = new System.Drawing.Size(45, 20);
            this.hrs_textBox5.TabIndex = 62;
            this.hrs_textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hrs_textBox6
            // 
            this.hrs_textBox6.BackColor = System.Drawing.Color.White;
            this.hrs_textBox6.Location = new System.Drawing.Point(164, 328);
            this.hrs_textBox6.Name = "hrs_textBox6";
            this.hrs_textBox6.Size = new System.Drawing.Size(45, 20);
            this.hrs_textBox6.TabIndex = 63;
            this.hrs_textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Payroll_functionForm_SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 506);
            this.Controls.Add(this.hrs_textBox6);
            this.Controls.Add(this.hrs_textBox5);
            this.Controls.Add(this.hrs_textBox4);
            this.Controls.Add(this.hrs_textBox3);
            this.Controls.Add(this.hrs_textBox2);
            this.Controls.Add(this.hrs_textBox);
            this.Controls.Add(this.earnings_textBox);
            this.Controls.Add(this.deductions_textBox2);
            this.Controls.Add(this.netPay_textBox);
            this.Controls.Add(this.deductions_textBox);
            this.Controls.Add(this.grossEarnings_textBox);
            this.Controls.Add(this.tardy_textBox);
            this.Controls.Add(this.substitution_textBox);
            this.Controls.Add(this.honorAdj_textBox);
            this.Controls.Add(this.honor_textBox);
            this.Controls.Add(this.overtime_textBox);
            this.Controls.Add(this.basicPay_textBox);
            this.Controls.Add(this.WISP_textBox);
            this.Controls.Add(this.philHealth_textBox);
            this.Controls.Add(this.HDMF_textBox);
            this.Controls.Add(this.sssContrib_textBox);
            this.Controls.Add(this.withholding_textBox);
            this.Controls.Add(this.reminder_label);
            this.Controls.Add(this.netPay_label);
            this.Controls.Add(this.deductions_label3);
            this.Controls.Add(this.grossEarnings_label);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zeroPoint_label2);
            this.Controls.Add(this.overtime_label2);
            this.Controls.Add(this.overtime_label1);
            this.Controls.Add(this.deductions_label2);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.SSSwisp_label);
            this.Controls.Add(this.philHealth_label);
            this.Controls.Add(this.HDMF_label);
            this.Controls.Add(this.sssContrib_label);
            this.Controls.Add(this.withholding_label);
            this.Controls.Add(this.deductions_label);
            this.Controls.Add(this.earnings_label2);
            this.Controls.Add(this.nonTaxable_label);
            this.Controls.Add(this.taxable_label);
            this.Controls.Add(this.dayHrs_label);
            this.Controls.Add(this.tardy_label);
            this.Controls.Add(this.substitution_label);
            this.Controls.Add(this.honorAdjust_label);
            this.Controls.Add(this.honorarium_label);
            this.Controls.Add(this.overtime_label);
            this.Controls.Add(this.basicPay_label);
            this.Controls.Add(this.earnings_label);
            this.Name = "Payroll_functionForm_SaveForm";
            this.Text = "Payroll_functionForm_SaveForm";
            this.Load += new System.EventHandler(this.Lesson5Actvity_SaveForm_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label earnings_label;
        private Label basicPay_label;
        private Label overtime_label;
        private Label honorarium_label;
        private Label honorAdjust_label;
        private Label substitution_label;
        private Label tardy_label;
        private Label dayHrs_label;
        private Label taxable_label;
        private Label nonTaxable_label;
        private Label earnings_label2;
        private Label amount_label;
        private Label SSSwisp_label;
        private Label philHealth_label;
        private Label HDMF_label;
        private Label sssContrib_label;
        private Label withholding_label;
        private Label deductions_label;
        private Label deductions_label2;
        private Label overtime_label2;
        private Label overtime_label1;
        private Label zeroPoint_label2;
        private GroupBox groupBox1;
        private Label empName_label;
        private Label payPeriod_label;
        private GroupBox groupBox2;
        private Label cutOff_label;
        private Label empCode_label;
        private GroupBox groupBox3;
        private Label department_label;
        private Label company_label;
        private Label grossEarnings_label;
        private Label deductions_label3;
        private Label netPay_label;
        private Label reminder_label;
        public TextBox company_textBox;
        public TextBox payPeriod_textBox;
        public TextBox empName_textBox;
        public TextBox cuOff_textBox;
        public TextBox empCode_textBox;
        public TextBox department_textBox;
        public TextBox withholding_textBox;
        public TextBox sssContrib_textBox;
        public TextBox HDMF_textBox;
        public TextBox philHealth_textBox;
        public TextBox WISP_textBox;
        public TextBox substitution_textBox;
        public TextBox honorAdj_textBox;
        public TextBox honor_textBox;
        public TextBox overtime_textBox;
        public TextBox basicPay_textBox;
        public TextBox tardy_textBox;
        public TextBox grossEarnings_textBox;
        public TextBox deductions_textBox;
        public TextBox netPay_textBox;
        public TextBox deductions_textBox2;
        public TextBox earnings_textBox;
        public TextBox hrs_textBox;
        public TextBox hrs_textBox2;
        public TextBox hrs_textBox3;
        public TextBox hrs_textBox4;
        public TextBox hrs_textBox5;
        public TextBox hrs_textBox6;
    }
}