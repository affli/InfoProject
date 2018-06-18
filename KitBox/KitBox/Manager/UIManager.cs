using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBox
{
    public partial class UIManager : UserControl
    {
        public UIManager()
        {
            InitializeComponent();
        }

        private void catalogue_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UINewOrder("Manager"));
        }

        private void providers_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIProviders());
        }

        private void stocks_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIStock());
        }

        private void orders_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIOrders());
        }

        private void catalogue_button_MouseEnter(object sender, EventArgs e)
        {
            catalogue_button.Cursor = Cursors.Hand;
        }

        private void providers_button_MouseEnter(object sender, EventArgs e)
        {
            providers_button.Cursor = Cursors.Hand;
        }

        private void stocks_button_MouseEnter(object sender, EventArgs e)
        {
            stocks_button.Cursor = Cursors.Hand;
        }

        private void orders_button_MouseEnter(object sender, EventArgs e)
        {
            orders_button.Cursor = Cursors.Hand;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new LaunchScreen());
        }
    }
}
