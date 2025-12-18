using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAL01E_MORATA
{
    public class Income
    {
        public double BasicRate { get; set; }
        public double BasicHours { get; set; }
        public double HonorariumRate { get; set; }
        public double HonorariumHours { get; set; }
        public double OtherRate { get; set; }
        public double OtherHours { get; set; }

        public double BasicIncome => BasicRate * BasicHours;
        public double HonorariumIncome => HonorariumRate * HonorariumHours;
        public double OtherIncome => OtherRate * OtherHours;
        public double GrossIncome => BasicIncome + HonorariumIncome + OtherIncome;
    }

    public class Deductions
    {
        public double SSS { get; set; }
        public double PhilHealth { get; set; }
        public double Pagibig { get; set; } = 200.0;
        public double IncomeTax { get; set; }

        public double SSSLoan { get; set; }
        public double PagibigLoan { get; set; }
        public double FacultySavingsDep { get; set; }
        public double FacultySavingsLoan { get; set; }
        public double SalaryLoan { get; set; }
        public double OtherLoans { get; set; }

        public double TotalRegular => SSS + PhilHealth + Pagibig + IncomeTax;
        public double TotalOther => SSSLoan + PagibigLoan + FacultySavingsDep + FacultySavingsLoan + SalaryLoan + OtherLoans;
        public double Total => TotalRegular + TotalOther;
    }

    public class PayrollCalculator
    {
        public Income Income { get; set; }
        public Deductions Deductions { get; set; }

        public double NetIncome => Income.GrossIncome - Deductions.Total;
    }

    public class PayrollRecord
    {
        public string CompanyName { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string CutoffDate { get; set; }
        public string PayPeriod { get; set; }
        public string BasicPay { get; set; }
        public string Honorarium { get; set; }
        public string Overtime { get; set; }
        public string SSSContribution { get; set; }
        public string PhilHealth { get; set; }
        public string WithholdingTax { get; set; }
        public string Earnings { get; set; }
        public string GrossEarnings { get; set; }
        public string Deductions { get; set; }
        public string Deductions2 { get; set; }
        public string NetPay { get; set; }
        public string HoursBasic { get; set; }
        public string HoursHonorarium { get; set; }
        public string HoursOther { get; set; }
    }
}
