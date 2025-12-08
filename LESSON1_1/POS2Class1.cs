using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LESSON1_1
{
    public class POS2Class1
    {
        private readonly Form parent;

        public POS2Class1(Form parentForm)
        {
            parent = parentForm ?? throw new ArgumentNullException(nameof(parentForm));
        }

        // Set Enabled state for multiple controls (DRY)
        public void SetControlStates(bool enabled, params Control[] controls)
        {
            if (controls == null) return;
            foreach (var c in controls)
            {
                if (c != null) c.Enabled = enabled;
            }
        }

        // Load multiple images safely (tuples of (PictureBox, path))
        public void LoadImages(params (PictureBox pb, string path)[] images)
        {
            foreach (var item in images)
            {
                try
                {
                    if (item.pb == null || string.IsNullOrWhiteSpace(item.path))
                        continue;

                    if (File.Exists(item.path))
                    {
                        item.pb.Image = Image.FromFile(item.path);
                        item.pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        // if missing, clear or set null to avoid crash
                        item.pb.Image = null;
                    }
                }
                catch
                {
                    // ignore load errors — caller can handle missing images
                    item.pb.Image = null;
                }
            }
        }

        // Apply bundle configuration (mirrors your original inline logic)
        // groupSelected: checkboxes that should be checked for the chosen bundle
        // groupUnselected: checkboxes that should be unchecked for the other bundle
        public void ApplyBundle(
            RadioButton bundleRadio,
            double price,
            double discount,
            Color background,
            CheckBox[] groupSelected,
            CheckBox[] groupUnselected,
            PictureBox bundlePictureBox,
            string bundleImagePath,
            TextBox priceBox,
            RichTextBox discountAmountBox,
            ListBox list,
            TextBox qtyBox)
        {
            if (bundleRadio == null || !bundleRadio.Checked) return;

            // Change background
            parent.BackColor = background;

            if (groupSelected != null)
            {
                foreach (var cb in groupSelected) if (cb != null) cb.Checked = true;
            }

            if (groupUnselected != null)
            {
                foreach (var cb in groupUnselected) if (cb != null) cb.Checked = false;
            }

            // Load bundle image
            try
            {
                if (bundlePictureBox != null && !string.IsNullOrWhiteSpace(bundleImagePath) && File.Exists(bundleImagePath))
                {
                    bundlePictureBox.Image = Image.FromFile(bundleImagePath);
                    bundlePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (bundlePictureBox != null)
                {
                    bundlePictureBox.Image = null;
                }
            }
            catch
            {
                if (bundlePictureBox != null) bundlePictureBox.Image = null;
            }

            // Disable price/discount editing as in original
            if (priceBox != null) priceBox.Enabled = false;
            if (discountAmountBox != null) discountAmountBox.Enabled = false;

            // Fill values
            if (priceBox != null) priceBox.Text = price.ToString("N2");
            if (discountAmountBox != null) discountAmountBox.Text = discount.ToString("N2");

            // Add to listbox same formatting as original
            if (list != null)
            {
                list.Items.Add(bundleRadio.Text + " " + (priceBox?.Text ?? price.ToString("N2")));
                list.Items.Add("         Discount Amount: " + (discountAmountBox?.Text ?? discount.ToString("N2")));
            }

            // Reset quantity and set focus
            if (qtyBox != null)
            {
                qtyBox.Text = "0";
                qtyBox.Focus();
            }
        }

        // Handle checkbox item selection (mirrors original HandleCheckBoxClick)
        // Note: we pass references for updatingQuantity, currentItemLastQuantity and amount from the form
        public void HandleCheckBoxClick(
            CheckBox chk,
            double price,
            TextBox priceBox,
            RichTextBox discountBox,
            ListBox list,
            TextBox qtyBox,
            ref bool updatingQuantity,
            ref int currentItemLastQuantity,
            ref double currentItemLastAmount)
        {
            if (chk == null) return;

            // Set price & discount as original
            if (priceBox != null) priceBox.Text = price.ToString("N2");
            if (discountBox != null) discountBox.Text = "0.00";

            // Add item to listbox
            list?.Items.Add(chk.Text + " " + priceBox?.Text);

            // Reset quantity editing sequence similar to original
            updatingQuantity = true;
            if (qtyBox != null) qtyBox.Text = "0";
            updatingQuantity = false;

            currentItemLastQuantity = 0;
            currentItemLastAmount = 0.0;

            qtyBox?.Focus();
        }

        // Reset all controls to initial state (mirrors your original reset behavior)
        public void ResetAll(Form frm)
        {
            if (frm == null) return;

            // Reset common numeric fields if they exist on form
            var tbPrice = frm.Controls.Find("textBox1", true).FirstOrDefault() as TextBox;
            var tbQty = frm.Controls.Find("textBox2", true).FirstOrDefault() as TextBox;
            var rtbDiscount = frm.Controls.Find("richTextBox1", true).FirstOrDefault() as RichTextBox;
            var rtbDiscAmount = frm.Controls.Find("richTextBox2", true).FirstOrDefault() as RichTextBox;
            var rtbTotalBills = frm.Controls.Find("richTextBox3", true).FirstOrDefault() as RichTextBox;
            var rtbTotalQty = frm.Controls.Find("richTextBox4", true).FirstOrDefault() as RichTextBox;
            var rtbCashGiven = frm.Controls.Find("richTextBox5", true).FirstOrDefault() as RichTextBox;
            var rtbChange = frm.Controls.Find("richTextBox6", true).FirstOrDefault() as RichTextBox;
            var pictureBox22 = frm.Controls.Find("pictureBox22", true).FirstOrDefault() as PictureBox;

            // Reset radio buttons
            var rb1 = frm.Controls.Find("radioButton1", true).FirstOrDefault() as RadioButton;
            var rb2 = frm.Controls.Find("radioButton2", true).FirstOrDefault() as RadioButton;
            if (rb1 != null) rb1.Checked = false;
            if (rb2 != null) rb2.Checked = false;
            if (rb1 != null) rb1.Enabled = true;
            if (rb2 != null) rb2.Enabled = true;

            // Reset many checkboxes (16..30 and 1..15) — try find them by name
            for (int i = 1; i <= 30; i++)
            {
                var cb = frm.Controls.Find("checkBox" + i, true).FirstOrDefault() as CheckBox;
                if (cb != null) cb.Checked = false;
            }

            // Reset textboxes/richtextboxes
            if (tbPrice != null) tbPrice.Text = "";
            if (tbQty != null) tbQty.Text = "0";
            if (rtbDiscount != null) rtbDiscount.Text = "";
            if (rtbDiscAmount != null) rtbDiscAmount.Text = "";
            if (rtbTotalBills != null) rtbTotalBills.Text = "";
            if (rtbTotalQty != null) rtbTotalQty.Text = "";
            if (rtbCashGiven != null) rtbCashGiven.Text = "";
            if (rtbChange != null) rtbChange.Text = "";

            // Reset product image to default if exists
            try
            {
                string defaultPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "Resources", "images.jpg"); // fallback relative path 
                if (pictureBox22 != null && File.Exists(defaultPath))
                {
                    pictureBox22.Image = Image.FromFile(defaultPath);
                    pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch
            {
                // ignore
            }

            // Clear listbox if exists
            var lb = frm.Controls.Find("listBox1", true).FirstOrDefault() as ListBox;
            lb?.Items.Clear();

            // Reset background color
            frm.BackColor = SystemColors.Control;
        }
    }
}
