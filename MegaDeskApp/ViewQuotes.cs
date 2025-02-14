using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskApp
{
    public partial class ViewQuotes : Form
    {
        public ViewQuotes()
        {
            InitializeComponent();
        }
        private void return_to_main()
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            return_to_main();
        }

        private void ViewQuotes_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString();
            WidthReq.Text = "Your width must be between 24 and 96 inches.";
        }
    }
}
