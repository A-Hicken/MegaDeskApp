using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskApp
{
    public partial class DisplayQuote : Form
    {
        public DeskQuote DeskQuote;
        public DisplayQuote(DeskQuote deskQuote)
        {
            DeskQuote = deskQuote;
            InitializeComponent();
        }
        private void return_to_main()
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            return_to_main();
        }
        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            CustomerName.Text = DeskQuote.customerName;
            QuoteDate.Text = DeskQuote.orderDate;
            string width = Convert.ToString(DeskQuote.desk.Width);
            string depth = Convert.ToString(DeskQuote.desk.Depth);
            string drawers = Convert.ToString(DeskQuote.desk.DrawerNumber);
            string shippingdays = Convert.ToString(DeskQuote.desk.ShippingDays);
            string material = DeskQuote.desk.Material;
            int SurfaceTotal = DeskQuote.desk.Width * DeskQuote.desk.Depth;

            string total = Convert.ToString(SurfaceTotal);

            WidthLabel.Text = width;
            DepthLabel.Text = depth;
            DrawerLable.Text = drawers + " drawers";
            MaterialLabel.Text = material;
            DeliveryLabel.Text = shippingdays + " days";
            TotalSizeLable.Text = total + " in^2";

        }


    }
}
