using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskApp
{
    public partial class AddQuote : Form
    {
        private DeskQuote deskQuote = new DeskQuote();
        public AddQuote()
        {
            InitializeComponent();
        }

        private void return_to_main()
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void GoBack(object sender, EventArgs e)
        {
            return_to_main();
        }

        private void WidthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newWidth;
                bool isNum = Int32.TryParse(input.Text, out newWidth);
                if (isNum)
                {
                    deskQuote.desk.Width = newWidth;
                    WidthErrorProvider.SetError(this.WidthBox, "");
                }
                else
                {
                    WidthErrorProvider.SetError(this.WidthBox, "Enter a number.");
                }
            }

            catch (Exception ex)
            {
                WidthErrorProvider.SetError(this.WidthBox, "Input must be between 24 and 96 inches.");
            }
        }
        private void DepthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newDepth;
                bool isNum = Int32.TryParse(input.Text, out newDepth);
                if (isNum)
                {
                    deskQuote.desk.Depth = newDepth;
                    DepthErrorProvider.SetError(this.DepthBox, "");
                }
                else
                {
                    DepthErrorProvider.SetError(this.DepthBox, "Enter a number.");
                }
            }

            catch (Exception ex)
            {
                DepthErrorProvider.SetError(this.DepthBox, "Input must be between 12 and 48 inches.");
            }
        }

        private void SubmitOrderBtn_Click(object sender, EventArgs e)
        {
            if (WidthBox.Text.Length == 0 || DepthBox.Text.Length == 0 || DrawerInput.Text.Length == 0) return;
            var thisDeskQuote = new DeskQuote();
            int surfaceArea = thisDeskQuote.desk.getSurfaceArea();
            string orderDate = DateTime.Now.ToShortDateString();
            int shipping = thisDeskQuote.desk.ShippingDays;
            DisplayQuote frm = new DisplayQuote(thisDeskQuote);
            frm.Show();
            Close();
        }

        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                //string newName = "";
                //bool isString = input.Text.Length > 0 || input.Text.Length < 20;
                if (input.Text.Length > 0)
                {
                    deskQuote.customerName = input.Text;
                    NameErrorProvider.SetError(this.NameBox, "");
                }
                else
                {
                    NameErrorProvider.SetError(this.NameBox, "Enter a name.");
                }
            }

            catch (Exception ex)
            {
                NameErrorProvider.SetError(this.NameBox, "Input must be more than 8 characters.");
            }
        }

        private void DrawerInput_Validating(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            try
            {
                int newDrawerAmount;
                bool isNumber = Int32.TryParse(input.Text, out newDrawerAmount) && input.Text.Length > 0 && input.Text.Length < 8;
                if (isNumber)
                {
                    deskQuote.desk.DrawerNumber = newDrawerAmount;
                    DrawerErrorProvider.SetError(this.DrawerInput, "");


                }
                else
                {
                    NameErrorProvider.SetError(this.DrawerInput, "Enter a name.");
                }
            }


            catch (Exception ex)
            {
                DrawerErrorProvider.SetError(this.DrawerInput, "Input must be less than 7.");
            }
        }

        private void MaterialComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;

            // List of valid materials
            List<string> validMaterials = new List<string> { "Pine", "Laminate", "Veneer", "Oak", "Rosewood" };

            // Check if the selected material is in the list of valid materials
            if (!validMaterials.Contains(input.Text))
            {
                // If the selected material is not in the list, show an error and cancel the event
                MessageBox.Show("Please select a valid material (Pine, Laminate, Veneer, Oak, or Rosewood).",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Prevent focus change and cancel the validation
                e.Cancel = true;
            }
            else
            {
                // If valid, you can proceed with further logic if needed
                // (e.g., enable other controls or save the data)
            }
        }

        private void ShippingComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            try
            {
                int newShippingTime;
                bool isNumber = Int32.TryParse(input.Text, out newShippingTime) && input.Text.Length > 0;
                if (isNumber)
                {
                    deskQuote.shippingDays = newShippingTime;
                    ShippingErrorProvider.SetError(this.ShippingComboBox, "");


                }
                else
                {
                    ShippingErrorProvider.SetError(this.DrawerInput, "Enter a number.");
                }
            }


            catch (Exception ex)
            {
                DrawerErrorProvider.SetError(this.DrawerInput, "Must pick number.");
            }
        }
    }
}
