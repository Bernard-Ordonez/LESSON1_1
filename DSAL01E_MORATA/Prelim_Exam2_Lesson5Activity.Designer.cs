
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAL01E_MORATA
{
    partial class Prelim_Exam2_Lesson5Activity
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.empBasicInf_label = new System.Windows.Forms.Label();
            this.empPicBox = new System.Windows.Forms.PictureBox();
            this.empNum_label = new System.Windows.Forms.Label();
            this.empNum_textBox = new System.Windows.Forms.TextBox();
            this.Department_textBox = new System.Windows.Forms.TextBox();
            this.Department_label = new System.Windows.Forms.Label();
            this.BasicInc_label = new System.Windows.Forms.Label();
            this.rateHour_label = new System.Windows.Forms.Label();
            this.rateHour_textBox = new System.Windows.Forms.TextBox();
            this.numHours_textBox = new System.Windows.Forms.TextBox();
            this.income_textBox = new System.Windows.Forms.TextBox();
            this.numHours_label = new System.Windows.Forms.Label();
            this.income_label = new System.Windows.Forms.Label();
            this.income_label2 = new System.Windows.Forms.Label();
            this.numHours_label2 = new System.Windows.Forms.Label();
            this.income_textBox2 = new System.Windows.Forms.TextBox();
            this.numHours_textBox2 = new System.Windows.Forms.TextBox();
            this.rateHour_textBox2 = new System.Windows.Forms.TextBox();
            this.rateHour_label2 = new System.Windows.Forms.Label();
            this.honorariumInc_label = new System.Windows.Forms.Label();
            this.income_label3 = new System.Windows.Forms.Label();
            this.numHours_label3 = new System.Windows.Forms.Label();
            this.income_textBox3 = new System.Windows.Forms.TextBox();
            this.numHours_textBox3 = new System.Windows.Forms.TextBox();
            this.rateHour_textBox3 = new System.Windows.Forms.TextBox();
            this.rateHour_label3 = new System.Windows.Forms.Label();
            this.otherInc_label = new System.Windows.Forms.Label();
            this.netIncome_label = new System.Windows.Forms.Label();
            this.netInc_textBox = new System.Windows.Forms.TextBox();
            this.grossInc_textBox = new System.Windows.Forms.TextBox();
            this.grossIncome_label = new System.Windows.Forms.Label();
            this.summaryInc_label = new System.Windows.Forms.Label();
            this.firstname_textBox = new System.Windows.Forms.TextBox();
            this.firstname_label = new System.Windows.Forms.Label();
            this.middleName_textBox = new System.Windows.Forms.TextBox();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.civilStatus_textBox = new System.Windows.Forms.TextBox();
            this.designation_textBox = new System.Windows.Forms.TextBox();
            this.empStat_textBox = new System.Windows.Forms.TextBox();
            this.paydate_textBox = new System.Windows.Forms.TextBox();
            this.qualDepStat_textBox = new System.Windows.Forms.TextBox();
            this.middleName_label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.civilStatus_label = new System.Windows.Forms.Label();
            this.qualDepStat_label = new System.Windows.Forms.Label();
            this.paydate_label = new System.Windows.Forms.Label();
            this.empStat_label = new System.Windows.Forms.Label();
            this.designation_label = new System.Windows.Forms.Label();
            this.regularDeduc_label = new System.Windows.Forms.Label();
            this.SSSContrib_textBox = new System.Windows.Forms.TextBox();
            this.philHealthCont_textBox = new System.Windows.Forms.TextBox();
            this.pagibigCont_textBox = new System.Windows.Forms.TextBox();
            this.incomeTaxCont_textBox = new System.Windows.Forms.TextBox();
            this.philHealthCont_label = new System.Windows.Forms.Label();
            this.pagIbigCont_label = new System.Windows.Forms.Label();
            this.incomeTaxCont_label = new System.Windows.Forms.Label();
            this.otherDeduc_label = new System.Windows.Forms.Label();
            this.SSSLoan_textBox = new System.Windows.Forms.TextBox();
            this.salaryLoan_textBox = new System.Windows.Forms.TextBox();
            this.facultySavingsLoan_textBox = new System.Windows.Forms.TextBox();
            this.facultySavingsDep_textBox = new System.Windows.Forms.TextBox();
            this.pagIbigLoan_textBox = new System.Windows.Forms.TextBox();
            this.otherLoans_textBox = new System.Windows.Forms.TextBox();
            this.SSSContrib_label = new System.Windows.Forms.Label();
            this.SSSLoan_label = new System.Windows.Forms.Label();
            this.pagibigLoan_label = new System.Windows.Forms.Label();
            this.facultySavingsDep_label = new System.Windows.Forms.Label();
            this.facultySavingsLoan_label = new System.Windows.Forms.Label();
            this.salaryLoan_label = new System.Windows.Forms.Label();
            this.otherLoan_label = new System.Windows.Forms.Label();
            this.deducSummary_label = new System.Windows.Forms.Label();
            this.totalDeduc_label = new System.Windows.Forms.Label();
            this.totalDeduc_textBox = new System.Windows.Forms.TextBox();
            this.new_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.netIncome_button = new System.Windows.Forms.Button();
            this.grossInc_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.empPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(271, 21);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(440, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "SE-RI\'S CHOICE PAYROLL";
            // 
            // empBasicInf_label
            // 
            this.empBasicInf_label.AutoSize = true;
            this.empBasicInf_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empBasicInf_label.Location = new System.Drawing.Point(28, 71);
            this.empBasicInf_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empBasicInf_label.Name = "empBasicInf_label";
            this.empBasicInf_label.Size = new System.Drawing.Size(136, 15);
            this.empBasicInf_label.TabIndex = 1;
            this.empBasicInf_label.Text = "EMPLOYEE BASIC INFO:";
            // 
            // empPicBox
            // 
            this.empPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.empPicBox.Location = new System.Drawing.Point(28, 90);
            this.empPicBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empPicBox.Name = "empPicBox";
            this.empPicBox.Size = new System.Drawing.Size(171, 138);
            this.empPicBox.TabIndex = 2;
            this.empPicBox.TabStop = false;
            // 
            // empNum_label
            // 
            this.empNum_label.AutoSize = true;
            this.empNum_label.Location = new System.Drawing.Point(28, 256);
            this.empNum_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empNum_label.Name = "empNum_label";
            this.empNum_label.Size = new System.Drawing.Size(123, 16);
            this.empNum_label.TabIndex = 3;
            this.empNum_label.Text = "Employee Number:";
            // 
            // empNum_textBox
            // 
            this.empNum_textBox.Location = new System.Drawing.Point(184, 247);
            this.empNum_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empNum_textBox.Name = "empNum_textBox";
            this.empNum_textBox.Size = new System.Drawing.Size(253, 22);
            this.empNum_textBox.TabIndex = 4;
            // 
            // Department_textBox
            // 
            this.Department_textBox.BackColor = System.Drawing.Color.LightGray;
            this.Department_textBox.Location = new System.Drawing.Point(184, 278);
            this.Department_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Department_textBox.Name = "Department_textBox";
            this.Department_textBox.Size = new System.Drawing.Size(253, 22);
            this.Department_textBox.TabIndex = 5;
            // 
            // Department_label
            // 
            this.Department_label.AutoSize = true;
            this.Department_label.Location = new System.Drawing.Point(28, 287);
            this.Department_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Department_label.Name = "Department_label";
            this.Department_label.Size = new System.Drawing.Size(80, 16);
            this.Department_label.TabIndex = 6;
            this.Department_label.Text = "Department:";
            // 
            // BasicInc_label
            // 
            this.BasicInc_label.AutoSize = true;
            this.BasicInc_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicInc_label.Location = new System.Drawing.Point(28, 330);
            this.BasicInc_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BasicInc_label.Name = "BasicInc_label";
            this.BasicInc_label.Size = new System.Drawing.Size(90, 15);
            this.BasicInc_label.TabIndex = 7;
            this.BasicInc_label.Text = "BASIC INCOME";
            // 
            // rateHour_label
            // 
            this.rateHour_label.AutoSize = true;
            this.rateHour_label.Location = new System.Drawing.Point(28, 361);
            this.rateHour_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rateHour_label.Name = "rateHour_label";
            this.rateHour_label.Size = new System.Drawing.Size(78, 16);
            this.rateHour_label.TabIndex = 8;
            this.rateHour_label.Text = "Rate / Hour:";
            // 
            // rateHour_textBox
            // 
            this.rateHour_textBox.Location = new System.Drawing.Point(184, 352);
            this.rateHour_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rateHour_textBox.Name = "rateHour_textBox";
            this.rateHour_textBox.Size = new System.Drawing.Size(253, 22);
            this.rateHour_textBox.TabIndex = 9;
            // 
            // numHours_textBox
            // 
            this.numHours_textBox.Location = new System.Drawing.Point(184, 384);
            this.numHours_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numHours_textBox.Name = "numHours_textBox";
            this.numHours_textBox.Size = new System.Drawing.Size(253, 22);
            this.numHours_textBox.TabIndex = 10;
            // 
            // income_textBox
            // 
            this.income_textBox.BackColor = System.Drawing.Color.LightGray;
            this.income_textBox.Location = new System.Drawing.Point(184, 415);
            this.income_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.income_textBox.Name = "income_textBox";
            this.income_textBox.Size = new System.Drawing.Size(253, 22);
            this.income_textBox.TabIndex = 11;
            // 
            // numHours_label
            // 
            this.numHours_label.AutoSize = true;
            this.numHours_label.Location = new System.Drawing.Point(28, 393);
            this.numHours_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numHours_label.Name = "numHours_label";
            this.numHours_label.Size = new System.Drawing.Size(133, 16);
            this.numHours_label.TabIndex = 12;
            this.numHours_label.Text = "No. of Hours / Cut-Off:";
            // 
            // income_label
            // 
            this.income_label.AutoSize = true;
            this.income_label.Location = new System.Drawing.Point(28, 423);
            this.income_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.income_label.Name = "income_label";
            this.income_label.Size = new System.Drawing.Size(102, 16);
            this.income_label.TabIndex = 13;
            this.income_label.Text = "Income / Cut Off:";
            // 
            // income_label2
            // 
            this.income_label2.AutoSize = true;
            this.income_label2.Location = new System.Drawing.Point(28, 558);
            this.income_label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.income_label2.Name = "income_label2";
            this.income_label2.Size = new System.Drawing.Size(103, 16);
            this.income_label2.TabIndex = 20;
            this.income_label2.Text = "Income / Cut-Off:";
            // 
            // numHours_label2
            // 
            this.numHours_label2.AutoSize = true;
            this.numHours_label2.Location = new System.Drawing.Point(28, 527);
            this.numHours_label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numHours_label2.Name = "numHours_label2";
            this.numHours_label2.Size = new System.Drawing.Size(133, 16);
            this.numHours_label2.TabIndex = 19;
            this.numHours_label2.Text = "No. of Hours / Cut-Off:";
            // 
            // income_textBox2
            // 
            this.income_textBox2.BackColor = System.Drawing.Color.LightGray;
            this.income_textBox2.Location = new System.Drawing.Point(184, 549);
            this.income_textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.income_textBox2.Name = "income_textBox2";
            this.income_textBox2.Size = new System.Drawing.Size(253, 22);
            this.income_textBox2.TabIndex = 18;
            // 
            // numHours_textBox2
            // 
            this.numHours_textBox2.Location = new System.Drawing.Point(184, 518);
            this.numHours_textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numHours_textBox2.Name = "numHours_textBox2";
            this.numHours_textBox2.Size = new System.Drawing.Size(253, 22);
            this.numHours_textBox2.TabIndex = 17;
            // 
            // rateHour_textBox2
            // 
            this.rateHour_textBox2.Location = new System.Drawing.Point(184, 487);
            this.rateHour_textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rateHour_textBox2.Name = "rateHour_textBox2";
            this.rateHour_textBox2.Size = new System.Drawing.Size(253, 22);
            this.rateHour_textBox2.TabIndex = 16;
            // 
            // rateHour_label2
            // 
            this.rateHour_label2.AutoSize = true;
            this.rateHour_label2.Location = new System.Drawing.Point(28, 496);
            this.rateHour_label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rateHour_label2.Name = "rateHour_label2";
            this.rateHour_label2.Size = new System.Drawing.Size(78, 16);
            this.rateHour_label2.TabIndex = 15;
            this.rateHour_label2.Text = "Rate / Hour:";
            // 
            // honorariumInc_label
            // 
            this.honorariumInc_label.AutoSize = true;
            this.honorariumInc_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.honorariumInc_label.Location = new System.Drawing.Point(28, 464);
            this.honorariumInc_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.honorariumInc_label.Name = "honorariumInc_label";
            this.honorariumInc_label.Size = new System.Drawing.Size(143, 15);
            this.honorariumInc_label.TabIndex = 14;
            this.honorariumInc_label.Text = "HONORARIUM INCOME:";
            // 
            // income_label3
            // 
            this.income_label3.AutoSize = true;
            this.income_label3.Location = new System.Drawing.Point(28, 694);
            this.income_label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.income_label3.Name = "income_label3";
            this.income_label3.Size = new System.Drawing.Size(103, 16);
            this.income_label3.TabIndex = 27;
            this.income_label3.Text = "Income / Cut-Off:";
            // 
            // numHours_label3
            // 
            this.numHours_label3.AutoSize = true;
            this.numHours_label3.Location = new System.Drawing.Point(28, 663);
            this.numHours_label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numHours_label3.Name = "numHours_label3";
            this.numHours_label3.Size = new System.Drawing.Size(133, 16);
            this.numHours_label3.TabIndex = 26;
            this.numHours_label3.Text = "No. of Hours / Cut-Off:";
            // 
            // income_textBox3
            // 
            this.income_textBox3.BackColor = System.Drawing.Color.LightGray;
            this.income_textBox3.Location = new System.Drawing.Point(184, 686);
            this.income_textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.income_textBox3.Name = "income_textBox3";
            this.income_textBox3.Size = new System.Drawing.Size(253, 22);
            this.income_textBox3.TabIndex = 25;
            // 
            // numHours_textBox3
            // 
            this.numHours_textBox3.Location = new System.Drawing.Point(184, 656);
            this.numHours_textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numHours_textBox3.Name = "numHours_textBox3";
            this.numHours_textBox3.Size = new System.Drawing.Size(253, 22);
            this.numHours_textBox3.TabIndex = 24;
            // 
            // rateHour_textBox3
            // 
            this.rateHour_textBox3.Location = new System.Drawing.Point(184, 624);
            this.rateHour_textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rateHour_textBox3.Name = "rateHour_textBox3";
            this.rateHour_textBox3.Size = new System.Drawing.Size(253, 22);
            this.rateHour_textBox3.TabIndex = 23;
            // 
            // rateHour_label3
            // 
            this.rateHour_label3.AutoSize = true;
            this.rateHour_label3.Location = new System.Drawing.Point(28, 633);
            this.rateHour_label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rateHour_label3.Name = "rateHour_label3";
            this.rateHour_label3.Size = new System.Drawing.Size(78, 16);
            this.rateHour_label3.TabIndex = 22;
            this.rateHour_label3.Text = "Rate / Hour:";
            // 
            // otherInc_label
            // 
            this.otherInc_label.AutoSize = true;
            this.otherInc_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherInc_label.Location = new System.Drawing.Point(28, 601);
            this.otherInc_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.otherInc_label.Name = "otherInc_label";
            this.otherInc_label.Size = new System.Drawing.Size(98, 15);
            this.otherInc_label.TabIndex = 21;
            this.otherInc_label.Text = "OTHER INCOME:";
            // 
            // netIncome_label
            // 
            this.netIncome_label.AutoSize = true;
            this.netIncome_label.Location = new System.Drawing.Point(28, 800);
            this.netIncome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.netIncome_label.Name = "netIncome_label";
            this.netIncome_label.Size = new System.Drawing.Size(93, 16);
            this.netIncome_label.TabIndex = 32;
            this.netIncome_label.Text = "NET INCOME:";
            // 
            // netInc_textBox
            // 
            this.netInc_textBox.BackColor = System.Drawing.Color.LightGray;
            this.netInc_textBox.Location = new System.Drawing.Point(184, 793);
            this.netInc_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.netInc_textBox.Name = "netInc_textBox";
            this.netInc_textBox.Size = new System.Drawing.Size(253, 22);
            this.netInc_textBox.TabIndex = 31;
            // 
            // grossInc_textBox
            // 
            this.grossInc_textBox.BackColor = System.Drawing.Color.White;
            this.grossInc_textBox.Location = new System.Drawing.Point(184, 761);
            this.grossInc_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grossInc_textBox.Name = "grossInc_textBox";
            this.grossInc_textBox.Size = new System.Drawing.Size(253, 22);
            this.grossInc_textBox.TabIndex = 30;
            // 
            // grossIncome_label
            // 
            this.grossIncome_label.AutoSize = true;
            this.grossIncome_label.Location = new System.Drawing.Point(28, 769);
            this.grossIncome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grossIncome_label.Name = "grossIncome_label";
            this.grossIncome_label.Size = new System.Drawing.Size(113, 16);
            this.grossIncome_label.TabIndex = 29;
            this.grossIncome_label.Text = "GROSS INCOME:";
            // 
            // summaryInc_label
            // 
            this.summaryInc_label.AutoSize = true;
            this.summaryInc_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryInc_label.Location = new System.Drawing.Point(28, 738);
            this.summaryInc_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.summaryInc_label.Name = "summaryInc_label";
            this.summaryInc_label.Size = new System.Drawing.Size(120, 15);
            this.summaryInc_label.TabIndex = 28;
            this.summaryInc_label.Text = "SUMMARY INCOME:";
            // 
            // firstname_textBox
            // 
            this.firstname_textBox.BackColor = System.Drawing.Color.LightGray;
            this.firstname_textBox.Location = new System.Drawing.Point(661, 96);
            this.firstname_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstname_textBox.Name = "firstname_textBox";
            this.firstname_textBox.Size = new System.Drawing.Size(256, 22);
            this.firstname_textBox.TabIndex = 33;
            this.firstname_textBox.TextChanged += new System.EventHandler(this.firstname_textBox_TextChanged);
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Location = new System.Drawing.Point(493, 105);
            this.firstname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(69, 16);
            this.firstname_label.TabIndex = 34;
            this.firstname_label.Text = "Firstname:";
            // 
            // middleName_textBox
            // 
            this.middleName_textBox.BackColor = System.Drawing.Color.LightGray;
            this.middleName_textBox.Location = new System.Drawing.Point(661, 127);
            this.middleName_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.middleName_textBox.Name = "middleName_textBox";
            this.middleName_textBox.Size = new System.Drawing.Size(256, 22);
            this.middleName_textBox.TabIndex = 35;
            // 
            // surname_textBox
            // 
            this.surname_textBox.BackColor = System.Drawing.Color.LightGray;
            this.surname_textBox.Location = new System.Drawing.Point(661, 158);
            this.surname_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(256, 22);
            this.surname_textBox.TabIndex = 36;
            // 
            // civilStatus_textBox
            // 
            this.civilStatus_textBox.BackColor = System.Drawing.Color.LightGray;
            this.civilStatus_textBox.Location = new System.Drawing.Point(661, 188);
            this.civilStatus_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.civilStatus_textBox.Name = "civilStatus_textBox";
            this.civilStatus_textBox.Size = new System.Drawing.Size(256, 22);
            this.civilStatus_textBox.TabIndex = 37;
            // 
            // designation_textBox
            // 
            this.designation_textBox.BackColor = System.Drawing.Color.LightGray;
            this.designation_textBox.Location = new System.Drawing.Point(661, 318);
            this.designation_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.designation_textBox.Name = "designation_textBox";
            this.designation_textBox.Size = new System.Drawing.Size(256, 22);
            this.designation_textBox.TabIndex = 41;
            // 
            // empStat_textBox
            // 
            this.empStat_textBox.BackColor = System.Drawing.Color.LightGray;
            this.empStat_textBox.Location = new System.Drawing.Point(661, 287);
            this.empStat_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empStat_textBox.Name = "empStat_textBox";
            this.empStat_textBox.Size = new System.Drawing.Size(256, 22);
            this.empStat_textBox.TabIndex = 40;
            // 
            // paydate_textBox
            // 
            this.paydate_textBox.Location = new System.Drawing.Point(661, 256);
            this.paydate_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paydate_textBox.Name = "paydate_textBox";
            this.paydate_textBox.Size = new System.Drawing.Size(256, 22);
            this.paydate_textBox.TabIndex = 39;
            // 
            // qualDepStat_textBox
            // 
            this.qualDepStat_textBox.Location = new System.Drawing.Point(661, 219);
            this.qualDepStat_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qualDepStat_textBox.Name = "qualDepStat_textBox";
            this.qualDepStat_textBox.Size = new System.Drawing.Size(256, 22);
            this.qualDepStat_textBox.TabIndex = 38;
            // 
            // middleName_label
            // 
            this.middleName_label.AutoSize = true;
            this.middleName_label.Location = new System.Drawing.Point(493, 135);
            this.middleName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.middleName_label.Name = "middleName_label";
            this.middleName_label.Size = new System.Drawing.Size(91, 16);
            this.middleName_label.TabIndex = 42;
            this.middleName_label.Text = "Middle Name:";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Location = new System.Drawing.Point(493, 166);
            this.surname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(64, 16);
            this.surname_label.TabIndex = 43;
            this.surname_label.Text = "Surname:";
            // 
            // civilStatus_label
            // 
            this.civilStatus_label.AutoSize = true;
            this.civilStatus_label.Location = new System.Drawing.Point(493, 197);
            this.civilStatus_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.civilStatus_label.Name = "civilStatus_label";
            this.civilStatus_label.Size = new System.Drawing.Size(75, 16);
            this.civilStatus_label.TabIndex = 44;
            this.civilStatus_label.Text = "Civil Status:";
            // 
            // qualDepStat_label
            // 
            this.qualDepStat_label.AutoSize = true;
            this.qualDepStat_label.Location = new System.Drawing.Point(493, 219);
            this.qualDepStat_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qualDepStat_label.Name = "qualDepStat_label";
            this.qualDepStat_label.Size = new System.Drawing.Size(137, 32);
            this.qualDepStat_label.TabIndex = 45;
            this.qualDepStat_label.Text = "Qualified Dependents\r\nStatus:\r\n";
            // 
            // paydate_label
            // 
            this.paydate_label.AutoSize = true;
            this.paydate_label.Location = new System.Drawing.Point(493, 265);
            this.paydate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paydate_label.Name = "paydate_label";
            this.paydate_label.Size = new System.Drawing.Size(61, 16);
            this.paydate_label.TabIndex = 46;
            this.paydate_label.Text = "Paydate:\r\n";
            // 
            // empStat_label
            // 
            this.empStat_label.AutoSize = true;
            this.empStat_label.Location = new System.Drawing.Point(493, 295);
            this.empStat_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empStat_label.Name = "empStat_label";
            this.empStat_label.Size = new System.Drawing.Size(112, 16);
            this.empStat_label.TabIndex = 47;
            this.empStat_label.Text = "Employee Status:";
            // 
            // designation_label
            // 
            this.designation_label.AutoSize = true;
            this.designation_label.Location = new System.Drawing.Point(493, 326);
            this.designation_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.designation_label.Name = "designation_label";
            this.designation_label.Size = new System.Drawing.Size(82, 16);
            this.designation_label.TabIndex = 48;
            this.designation_label.Text = "Designation:";
            // 
            // regularDeduc_label
            // 
            this.regularDeduc_label.AutoSize = true;
            this.regularDeduc_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularDeduc_label.Location = new System.Drawing.Point(493, 368);
            this.regularDeduc_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regularDeduc_label.Name = "regularDeduc_label";
            this.regularDeduc_label.Size = new System.Drawing.Size(143, 15);
            this.regularDeduc_label.TabIndex = 49;
            this.regularDeduc_label.Text = "REGULAR DEDUCTIONS:";
            // 
            // SSSContrib_textBox
            // 
            this.SSSContrib_textBox.BackColor = System.Drawing.Color.LightGray;
            this.SSSContrib_textBox.Location = new System.Drawing.Point(661, 391);
            this.SSSContrib_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SSSContrib_textBox.Name = "SSSContrib_textBox";
            this.SSSContrib_textBox.Size = new System.Drawing.Size(256, 22);
            this.SSSContrib_textBox.TabIndex = 50;
            // 
            // philHealthCont_textBox
            // 
            this.philHealthCont_textBox.BackColor = System.Drawing.Color.LightGray;
            this.philHealthCont_textBox.Location = new System.Drawing.Point(661, 422);
            this.philHealthCont_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.philHealthCont_textBox.Name = "philHealthCont_textBox";
            this.philHealthCont_textBox.Size = new System.Drawing.Size(256, 22);
            this.philHealthCont_textBox.TabIndex = 52;
            // 
            // pagibigCont_textBox
            // 
            this.pagibigCont_textBox.BackColor = System.Drawing.Color.LightGray;
            this.pagibigCont_textBox.Location = new System.Drawing.Point(661, 453);
            this.pagibigCont_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pagibigCont_textBox.Name = "pagibigCont_textBox";
            this.pagibigCont_textBox.Size = new System.Drawing.Size(256, 22);
            this.pagibigCont_textBox.TabIndex = 53;
            // 
            // incomeTaxCont_textBox
            // 
            this.incomeTaxCont_textBox.BackColor = System.Drawing.Color.LightGray;
            this.incomeTaxCont_textBox.Location = new System.Drawing.Point(661, 484);
            this.incomeTaxCont_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.incomeTaxCont_textBox.Name = "incomeTaxCont_textBox";
            this.incomeTaxCont_textBox.Size = new System.Drawing.Size(256, 22);
            this.incomeTaxCont_textBox.TabIndex = 54;
            // 
            // philHealthCont_label
            // 
            this.philHealthCont_label.AutoSize = true;
            this.philHealthCont_label.Location = new System.Drawing.Point(493, 431);
            this.philHealthCont_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.philHealthCont_label.Name = "philHealthCont_label";
            this.philHealthCont_label.Size = new System.Drawing.Size(144, 16);
            this.philHealthCont_label.TabIndex = 55;
            this.philHealthCont_label.Text = "PhilHealth Contribution:";
            // 
            // pagIbigCont_label
            // 
            this.pagIbigCont_label.AutoSize = true;
            this.pagIbigCont_label.Location = new System.Drawing.Point(493, 462);
            this.pagIbigCont_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pagIbigCont_label.Name = "pagIbigCont_label";
            this.pagIbigCont_label.Size = new System.Drawing.Size(134, 16);
            this.pagIbigCont_label.TabIndex = 56;
            this.pagIbigCont_label.Text = "Pag-ibig Contribution:";
            // 
            // incomeTaxCont_label
            // 
            this.incomeTaxCont_label.AutoSize = true;
            this.incomeTaxCont_label.Location = new System.Drawing.Point(493, 492);
            this.incomeTaxCont_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomeTaxCont_label.Name = "incomeTaxCont_label";
            this.incomeTaxCont_label.Size = new System.Drawing.Size(153, 16);
            this.incomeTaxCont_label.TabIndex = 57;
            this.incomeTaxCont_label.Text = "Income Tax Contribution:";
            // 
            // otherDeduc_label
            // 
            this.otherDeduc_label.AutoSize = true;
            this.otherDeduc_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherDeduc_label.Location = new System.Drawing.Point(493, 537);
            this.otherDeduc_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.otherDeduc_label.Name = "otherDeduc_label";
            this.otherDeduc_label.Size = new System.Drawing.Size(128, 15);
            this.otherDeduc_label.TabIndex = 58;
            this.otherDeduc_label.Text = "OTHER DEDUCTIONS:";
            // 
            // SSSLoan_textBox
            // 
            this.SSSLoan_textBox.Location = new System.Drawing.Point(661, 554);
            this.SSSLoan_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SSSLoan_textBox.Name = "SSSLoan_textBox";
            this.SSSLoan_textBox.Size = new System.Drawing.Size(256, 22);
            this.SSSLoan_textBox.TabIndex = 59;
            // 
            // salaryLoan_textBox
            // 
            this.salaryLoan_textBox.Location = new System.Drawing.Point(661, 678);
            this.salaryLoan_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salaryLoan_textBox.Name = "salaryLoan_textBox";
            this.salaryLoan_textBox.Size = new System.Drawing.Size(256, 22);
            this.salaryLoan_textBox.TabIndex = 63;
            // 
            // facultySavingsLoan_textBox
            // 
            this.facultySavingsLoan_textBox.Location = new System.Drawing.Point(661, 647);
            this.facultySavingsLoan_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.facultySavingsLoan_textBox.Name = "facultySavingsLoan_textBox";
            this.facultySavingsLoan_textBox.Size = new System.Drawing.Size(256, 22);
            this.facultySavingsLoan_textBox.TabIndex = 62;
            // 
            // facultySavingsDep_textBox
            // 
            this.facultySavingsDep_textBox.Location = new System.Drawing.Point(661, 617);
            this.facultySavingsDep_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.facultySavingsDep_textBox.Name = "facultySavingsDep_textBox";
            this.facultySavingsDep_textBox.Size = new System.Drawing.Size(256, 22);
            this.facultySavingsDep_textBox.TabIndex = 61;
            // 
            // pagIbigLoan_textBox
            // 
            this.pagIbigLoan_textBox.Location = new System.Drawing.Point(661, 585);
            this.pagIbigLoan_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pagIbigLoan_textBox.Name = "pagIbigLoan_textBox";
            this.pagIbigLoan_textBox.Size = new System.Drawing.Size(256, 22);
            this.pagIbigLoan_textBox.TabIndex = 60;
            // 
            // otherLoans_textBox
            // 
            this.otherLoans_textBox.Location = new System.Drawing.Point(661, 709);
            this.otherLoans_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.otherLoans_textBox.Name = "otherLoans_textBox";
            this.otherLoans_textBox.Size = new System.Drawing.Size(256, 22);
            this.otherLoans_textBox.TabIndex = 64;
            // 
            // SSSContrib_label
            // 
            this.SSSContrib_label.AutoSize = true;
            this.SSSContrib_label.Location = new System.Drawing.Point(493, 400);
            this.SSSContrib_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SSSContrib_label.Name = "SSSContrib_label";
            this.SSSContrib_label.Size = new System.Drawing.Size(110, 16);
            this.SSSContrib_label.TabIndex = 51;
            this.SSSContrib_label.Text = "SSS Contribution:";
            // 
            // SSSLoan_label
            // 
            this.SSSLoan_label.AutoSize = true;
            this.SSSLoan_label.Location = new System.Drawing.Point(493, 562);
            this.SSSLoan_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SSSLoan_label.Name = "SSSLoan_label";
            this.SSSLoan_label.Size = new System.Drawing.Size(70, 16);
            this.SSSLoan_label.TabIndex = 65;
            this.SSSLoan_label.Text = "SSS Loan:";
            // 
            // pagibigLoan_label
            // 
            this.pagibigLoan_label.AutoSize = true;
            this.pagibigLoan_label.Location = new System.Drawing.Point(493, 593);
            this.pagibigLoan_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pagibigLoan_label.Name = "pagibigLoan_label";
            this.pagibigLoan_label.Size = new System.Drawing.Size(94, 16);
            this.pagibigLoan_label.TabIndex = 66;
            this.pagibigLoan_label.Text = "Pag-ibig Loan:";
            // 
            // facultySavingsDep_label
            // 
            this.facultySavingsDep_label.AutoSize = true;
            this.facultySavingsDep_label.Location = new System.Drawing.Point(493, 624);
            this.facultySavingsDep_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.facultySavingsDep_label.Name = "facultySavingsDep_label";
            this.facultySavingsDep_label.Size = new System.Drawing.Size(155, 16);
            this.facultySavingsDep_label.TabIndex = 67;
            this.facultySavingsDep_label.Text = "Faculty Savings Deposit:";
            // 
            // facultySavingsLoan_label
            // 
            this.facultySavingsLoan_label.AutoSize = true;
            this.facultySavingsLoan_label.Location = new System.Drawing.Point(493, 656);
            this.facultySavingsLoan_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.facultySavingsLoan_label.Name = "facultySavingsLoan_label";
            this.facultySavingsLoan_label.Size = new System.Drawing.Size(138, 16);
            this.facultySavingsLoan_label.TabIndex = 68;
            this.facultySavingsLoan_label.Text = "Faculty Savings Loan:";
            // 
            // salaryLoan_label
            // 
            this.salaryLoan_label.AutoSize = true;
            this.salaryLoan_label.Location = new System.Drawing.Point(493, 687);
            this.salaryLoan_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryLoan_label.Name = "salaryLoan_label";
            this.salaryLoan_label.Size = new System.Drawing.Size(82, 16);
            this.salaryLoan_label.TabIndex = 69;
            this.salaryLoan_label.Text = "Salary Loan:";
            // 
            // otherLoan_label
            // 
            this.otherLoan_label.AutoSize = true;
            this.otherLoan_label.Location = new System.Drawing.Point(493, 718);
            this.otherLoan_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.otherLoan_label.Name = "otherLoan_label";
            this.otherLoan_label.Size = new System.Drawing.Size(82, 16);
            this.otherLoan_label.TabIndex = 70;
            this.otherLoan_label.Text = "Other Loans:";
            // 
            // deducSummary_label
            // 
            this.deducSummary_label.AutoSize = true;
            this.deducSummary_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deducSummary_label.Location = new System.Drawing.Point(493, 761);
            this.deducSummary_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deducSummary_label.Name = "deducSummary_label";
            this.deducSummary_label.Size = new System.Drawing.Size(143, 15);
            this.deducSummary_label.TabIndex = 71;
            this.deducSummary_label.Text = "DEDUCTION SUMMARY:";
            // 
            // totalDeduc_label
            // 
            this.totalDeduc_label.AutoSize = true;
            this.totalDeduc_label.Location = new System.Drawing.Point(493, 793);
            this.totalDeduc_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalDeduc_label.Name = "totalDeduc_label";
            this.totalDeduc_label.Size = new System.Drawing.Size(112, 16);
            this.totalDeduc_label.TabIndex = 72;
            this.totalDeduc_label.Text = "Total Deductions:";
            // 
            // totalDeduc_textBox
            // 
            this.totalDeduc_textBox.BackColor = System.Drawing.Color.LightGray;
            this.totalDeduc_textBox.Location = new System.Drawing.Point(661, 784);
            this.totalDeduc_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalDeduc_textBox.Name = "totalDeduc_textBox";
            this.totalDeduc_textBox.Size = new System.Drawing.Size(256, 22);
            this.totalDeduc_textBox.TabIndex = 73;
            // 
            // new_button
            // 
            this.new_button.BackColor = System.Drawing.Color.SlateBlue;
            this.new_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_button.ForeColor = System.Drawing.Color.White;
            this.new_button.Location = new System.Drawing.Point(823, 825);
            this.new_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(96, 42);
            this.new_button.TabIndex = 74;
            this.new_button.Text = "NEW";
            this.new_button.UseVisualStyleBackColor = false;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Crimson;
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(719, 825);
            this.update_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(96, 42);
            this.update_button.TabIndex = 75;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = false;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(615, 825);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(96, 42);
            this.save_button.TabIndex = 76;
            this.save_button.Text = "SAVE";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // netIncome_button
            // 
            this.netIncome_button.BackColor = System.Drawing.Color.Lime;
            this.netIncome_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netIncome_button.Location = new System.Drawing.Point(469, 825);
            this.netIncome_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.netIncome_button.Name = "netIncome_button";
            this.netIncome_button.Size = new System.Drawing.Size(137, 42);
            this.netIncome_button.TabIndex = 77;
            this.netIncome_button.Text = "NET INCOME:";
            this.netIncome_button.UseVisualStyleBackColor = false;
            this.netIncome_button.Click += new System.EventHandler(this.netIncome_button_Click);
            // 
            // grossInc_button
            // 
            this.grossInc_button.BackColor = System.Drawing.Color.Gold;
            this.grossInc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossInc_button.Location = new System.Drawing.Point(296, 825);
            this.grossInc_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grossInc_button.Name = "grossInc_button";
            this.grossInc_button.Size = new System.Drawing.Size(165, 42);
            this.grossInc_button.TabIndex = 78;
            this.grossInc_button.Text = "GROSS INCOME:";
            this.grossInc_button.UseVisualStyleBackColor = false;
            this.grossInc_button.Click += new System.EventHandler(this.grossInc_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.grossInc_button);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.netIncome_button);
            this.panel1.Controls.Add(this.empBasicInf_label);
            this.panel1.Controls.Add(this.save_button);
            this.panel1.Controls.Add(this.empPicBox);
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Controls.Add(this.empNum_label);
            this.panel1.Controls.Add(this.new_button);
            this.panel1.Controls.Add(this.empNum_textBox);
            this.panel1.Controls.Add(this.totalDeduc_textBox);
            this.panel1.Controls.Add(this.Department_textBox);
            this.panel1.Controls.Add(this.totalDeduc_label);
            this.panel1.Controls.Add(this.Department_label);
            this.panel1.Controls.Add(this.deducSummary_label);
            this.panel1.Controls.Add(this.BasicInc_label);
            this.panel1.Controls.Add(this.otherLoan_label);
            this.panel1.Controls.Add(this.rateHour_label);
            this.panel1.Controls.Add(this.salaryLoan_label);
            this.panel1.Controls.Add(this.rateHour_textBox);
            this.panel1.Controls.Add(this.facultySavingsLoan_label);
            this.panel1.Controls.Add(this.numHours_textBox);
            this.panel1.Controls.Add(this.facultySavingsDep_label);
            this.panel1.Controls.Add(this.income_textBox);
            this.panel1.Controls.Add(this.pagibigLoan_label);
            this.panel1.Controls.Add(this.numHours_label);
            this.panel1.Controls.Add(this.SSSLoan_label);
            this.panel1.Controls.Add(this.income_label);
            this.panel1.Controls.Add(this.otherLoans_textBox);
            this.panel1.Controls.Add(this.honorariumInc_label);
            this.panel1.Controls.Add(this.salaryLoan_textBox);
            this.panel1.Controls.Add(this.rateHour_label2);
            this.panel1.Controls.Add(this.facultySavingsLoan_textBox);
            this.panel1.Controls.Add(this.rateHour_textBox2);
            this.panel1.Controls.Add(this.facultySavingsDep_textBox);
            this.panel1.Controls.Add(this.numHours_textBox2);
            this.panel1.Controls.Add(this.pagIbigLoan_textBox);
            this.panel1.Controls.Add(this.income_textBox2);
            this.panel1.Controls.Add(this.SSSLoan_textBox);
            this.panel1.Controls.Add(this.numHours_label2);
            this.panel1.Controls.Add(this.otherDeduc_label);
            this.panel1.Controls.Add(this.income_label2);
            this.panel1.Controls.Add(this.incomeTaxCont_label);
            this.panel1.Controls.Add(this.otherInc_label);
            this.panel1.Controls.Add(this.pagIbigCont_label);
            this.panel1.Controls.Add(this.rateHour_label3);
            this.panel1.Controls.Add(this.philHealthCont_label);
            this.panel1.Controls.Add(this.rateHour_textBox3);
            this.panel1.Controls.Add(this.incomeTaxCont_textBox);
            this.panel1.Controls.Add(this.numHours_textBox3);
            this.panel1.Controls.Add(this.pagibigCont_textBox);
            this.panel1.Controls.Add(this.income_textBox3);
            this.panel1.Controls.Add(this.philHealthCont_textBox);
            this.panel1.Controls.Add(this.numHours_label3);
            this.panel1.Controls.Add(this.SSSContrib_label);
            this.panel1.Controls.Add(this.income_label3);
            this.panel1.Controls.Add(this.SSSContrib_textBox);
            this.panel1.Controls.Add(this.summaryInc_label);
            this.panel1.Controls.Add(this.regularDeduc_label);
            this.panel1.Controls.Add(this.grossIncome_label);
            this.panel1.Controls.Add(this.designation_label);
            this.panel1.Controls.Add(this.grossInc_textBox);
            this.panel1.Controls.Add(this.empStat_label);
            this.panel1.Controls.Add(this.netInc_textBox);
            this.panel1.Controls.Add(this.paydate_label);
            this.panel1.Controls.Add(this.netIncome_label);
            this.panel1.Controls.Add(this.qualDepStat_label);
            this.panel1.Controls.Add(this.firstname_textBox);
            this.panel1.Controls.Add(this.civilStatus_label);
            this.panel1.Controls.Add(this.firstname_label);
            this.panel1.Controls.Add(this.surname_label);
            this.panel1.Controls.Add(this.middleName_textBox);
            this.panel1.Controls.Add(this.middleName_label);
            this.panel1.Controls.Add(this.surname_textBox);
            this.panel1.Controls.Add(this.designation_textBox);
            this.panel1.Controls.Add(this.civilStatus_textBox);
            this.panel1.Controls.Add(this.empStat_textBox);
            this.panel1.Controls.Add(this.qualDepStat_textBox);
            this.panel1.Controls.Add(this.paydate_textBox);
            this.panel1.Location = new System.Drawing.Point(24, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 879);
            this.panel1.TabIndex = 79;
            // 
            // Prelim_Exam2_Lesson5Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(972, 902);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Prelim_Exam2_Lesson5Activity";
            this.Text = "Lesson5Activity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Prelim_Exam2_Lesson5Activity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void surname_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void middleName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstname_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private Label titleLabel;
        private Label empBasicInf_label;
        private PictureBox empPicBox;
        private Label empNum_label;
        private TextBox empNum_textBox;
        private TextBox Department_textBox;
        private Label Department_label;
        private Label BasicInc_label;
        private Label rateHour_label;
        private TextBox rateHour_textBox;
        private TextBox numHours_textBox;
        private TextBox income_textBox;
        private Label numHours_label;
        private Label income_label;
        private Label income_label2;
        private Label numHours_label2;
        private TextBox income_textBox2;
        private TextBox numHours_textBox2;
        private TextBox rateHour_textBox2;
        private Label rateHour_label2;
        private Label honorariumInc_label;
        private Label income_label3;
        private Label numHours_label3;
        private TextBox income_textBox3;
        private TextBox numHours_textBox3;
        private TextBox rateHour_textBox3;
        private Label rateHour_label3;
        private Label otherInc_label;
        private Label netIncome_label;
        private TextBox netInc_textBox;
        private TextBox grossInc_textBox;
        private Label grossIncome_label;
        private Label summaryInc_label;
        private TextBox firstname_textBox;
        private Label firstname_label;
        private TextBox middleName_textBox;
        private TextBox surname_textBox;
        private TextBox civilStatus_textBox;
        private TextBox designation_textBox;
        private TextBox empStat_textBox;
        private TextBox paydate_textBox;
        private TextBox qualDepStat_textBox;
        private Label middleName_label;
        private Label surname_label;
        private Label civilStatus_label;
        private Label qualDepStat_label;
        private Label paydate_label;
        private Label empStat_label;
        private Label designation_label;
        private Label regularDeduc_label;
        private TextBox SSSContrib_textBox;
        private TextBox philHealthCont_textBox;
        private TextBox pagibigCont_textBox;
        private TextBox incomeTaxCont_textBox;
        private Label philHealthCont_label;
        private Label pagIbigCont_label;
        private Label incomeTaxCont_label;
        private Label otherDeduc_label;
        private TextBox SSSLoan_textBox;
        private TextBox salaryLoan_textBox;
        private TextBox facultySavingsLoan_textBox;
        private TextBox facultySavingsDep_textBox;
        private TextBox pagIbigLoan_textBox;
        private TextBox otherLoans_textBox;
        private Label SSSContrib_label;
        private Label SSSLoan_label;
        private Label pagibigLoan_label;
        private Label facultySavingsDep_label;
        private Label facultySavingsLoan_label;
        private Label salaryLoan_label;
        private Label otherLoan_label;
        private Label deducSummary_label;
        private Label totalDeduc_label;
        private TextBox totalDeduc_textBox;
        private Button new_button;
        private Button update_button;
        private Button save_button;
        private Button netIncome_button;
        private Button grossInc_button;
        private Panel panel1;
    }
}