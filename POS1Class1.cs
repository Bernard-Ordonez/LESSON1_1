using System;
using System.Collections.Generic;

namespace LESSON1_1
{
    public class POS1Class1
    {
        // Fields for tracking totals
        public int TotalQuantity { get; private set; }
        public decimal TotalDiscount { get; private set; }
        public decimal TotalDiscountedAmount { get; private set; }

        // Current item
        public string CurrentItem { get; private set; }
        public decimal CurrentPrice { get; private set; }

        // Food list
        private readonly Dictionary<string, decimal> foodMenu;

        // Constructor
        public POS1Class1()
        {
            foodMenu = new Dictionary<string, decimal>
            {
                { "Nashville Hot Chicken", 150 },
                { "Indian Chicken 65", 180 },
                { "Taiwanese Popcorn Chicken", 160 },
                { "Korean Fried Chicken", 200 },
                { "Southern Fried Chicken", 170 },
                { "Chili-Honey Glazed Lechon Kawali", 220 },
                { "Bacon-Wrapped Pork Chop", 190 },
                { "Pork Tonkatsu", 180 },
                { "Fried Calamansi Pork Chops", 175 },
                { "Breaded Pork Chop", 160 },
                { "Caramelized Onions and Blue Cheese Beef", 250 },
                { "Prime Rib Roast", 300 },
                { "Beef Wellington", 350 },
                { "The Filet Mignon", 320 },
                { "Steak Au Poivre", 280 },
                { "Hawaiian Shoyu Chicken", 200 },
                { "Chicken & Rice Casserole", 180 },
                { "Orange Chicken", 190 },
                { "Chicken Enchiladas", 210 },
                { "Caprese Chicken Gnocchi Skillet", 230 }
            };

            ResetAll();
        }

        // --- Set Selected Food Item ---
        public bool SetFoodItem(string itemName)
        {
            if (foodMenu.ContainsKey(itemName))
            {
                CurrentItem = itemName;
                CurrentPrice = foodMenu[itemName];
                return true;
            }
            return false;
        }

        // --- Compute Discount and Discounted Amount ---
        public (decimal discountAmount, decimal discountedAmount) ComputeDiscount(decimal price, int qty, decimal discountRate)
        {
            decimal subtotal = price * qty;
            decimal discountAmount = subtotal * discountRate;
            decimal discountedAmount = subtotal - discountAmount;
            return (discountAmount, discountedAmount);
        }

        // --- Compute Change ---
        public decimal ComputeChange(decimal cash, decimal discountedAmount)
        {
            if (cash < discountedAmount)
                throw new Exception("Insufficient cash.");
            return cash - discountedAmount;
        }

        // --- Update Totals ---
        public void UpdateTotals(int qty, decimal discountAmount, decimal discountedAmount)
        {
            TotalQuantity += qty;
            TotalDiscount += discountAmount;
            TotalDiscountedAmount += discountedAmount;
        }

        // --- Reset Current Item ---
        public void ResetCurrentItem()
        {
            CurrentItem = string.Empty;
            CurrentPrice = 0;
        }

        // --- Reset Totals ---
        public void ResetTotals()
        {
            TotalQuantity = 0;
            TotalDiscount = 0;
            TotalDiscountedAmount = 0;
        }

        // --- Full Reset (for new transaction) ---
        public void ResetAll()
        {
            ResetTotals();
            ResetCurrentItem();
        }
    }
}
