using System;
using System.Linq;

namespace LESSON1_1
{
    public class PayrollClass1
    {
        // ---- Contribution Tables ----
        private readonly double[] sssRanges = {
            0, 5250, 5750, 6250, 6750, 7250, 7750, 8250, 8750, 9250,
            9750, 10250, 10750, 11250, 11750, 12250, 12750, 13250, 13750, 14250,
            14750, 15250, 15750, 16250, 16750, 17250, 17750, 18250, 18750, 19250,
            19750, 20250, 20750, 21250, 21750, 22250, 22750, 23250, 23750, 24250,
            24750, 25250, 25750, 26250, 26750, 27250, 27750, 28250, 28750, 29250,
            29750, 30250, 30750, 31250, 31750, 32250, 32750, 33250, 33750, 34250, 34750
        };

        private readonly double[] sssAmounts = {
            250, 275, 300, 325, 350, 375, 400, 425, 450, 475,
            500, 525, 550, 575, 600, 625, 650, 675, 700, 725,
            750, 775, 800, 825, 850, 875, 900, 925, 950, 975,
            1000, 1025, 1050, 1075, 1100, 1125, 1150, 1175, 1200, 1225,
            1250, 1275, 1300, 1325, 1350, 1375, 1400, 1425, 1450, 1475,
            1500, 1525, 1550, 1575, 1600, 1625, 1650, 1675, 1700, 1725, 1750
        };

        // ---- COMPUTATION METHODS ----

        public double ComputeBasicIncome(double rate, double hours) => rate * hours;

        public double ComputeGrossIncome(double basic, double honorarium, double other) =>
            basic + honorarium + other;

        public double ComputeCutoff(double income) => income / 2.0;

        public double GetSSSContribution(double income)
        {
            // Defensive: if arrays mismatch, handle gracefully
            if (sssRanges == null || sssAmounts == null || sssRanges.Length != sssAmounts.Length)
                return 0;

            // Default to last amount (highest bracket)
            double contribution = sssAmounts[sssAmounts.Length - 1];

            for (int i = 0; i < sssRanges.Length; i++)
            {
                if (income <= sssRanges[i])
                {
                    contribution = sssAmounts[i];
                    break;
                }
            }
            return contribution;
        }

        public double GetPhilHealthContribution(double income)
        {
            double philhealth = income * 0.05;
            if (philhealth < 500) philhealth = 500;
            if (philhealth > 5000) philhealth = 5000;
            return philhealth;
        }

        public double GetPagibigContribution() => 100;

        public double GetWithholdingTax(double income)
        {
            if (income <= 20832)
                return 0;
            else if (income <= 33333)
                return (income - 20833) * 0.20;
            else if (income <= 66667)
                return 2500 + (income - 33333) * 0.25;
            else if (income <= 166667)
                return 10833 + (income - 66667) * 0.30;
            else if (income <= 666667)
                return 40833 + (income - 166667) * 0.32;
            else
                return 200833 + (income - 666667) * 0.35;
        }

        public double ComputeTotalDeductions(params double[] deductions) =>
            (deductions == null || deductions.Length == 0) ? 0 : deductions.Sum();

        public double ComputeNetIncome(double gross, double deductions)
        {
            double net = gross - deductions;
            return net < 0 ? 0 : net;
        }
    }
}
