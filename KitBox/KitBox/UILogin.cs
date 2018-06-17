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
    public partial class UILogin : UserControl
    {
        public UILogin()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new LaunchScreen());
        }

        private void new_customer_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UINewCustomer());
        }

        private void continue_order_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UINewOrder());
        }

        private void new_customer_button_MouseEnter(object sender, EventArgs e)
        {
            new_customer_button.Cursor = Cursors.Hand;
        }

        private void back_button_MouseEnter(object sender, EventArgs e)
        {
            back_button.Cursor = Cursors.Hand;
        }

        private void forget_id_button_MouseEnter(object sender, EventArgs e)
        {
            forget_id_button.Cursor = Cursors.Hand;
        }

        private void continue_order_button_MouseEnter(object sender, EventArgs e)
        {
            continue_order_button.Cursor = Cursors.Hand;
        }
    }
}
