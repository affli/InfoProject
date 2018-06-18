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
    public partial class LaunchScreen : UserControl
    {
        public LaunchScreen()
        {
            InitializeComponent();
        }

        private void new_order_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UILogin());
        }

        private void storekeeper_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIManagerLogin());
        }

        private void new_order_button_MouseEnter(object sender, EventArgs e)
        {
            new_order_button.Cursor = Cursors.Hand;
        }

        private void storekeeper_button_MouseEnter(object sender, EventArgs e)
        {
            storekeeper_button.Cursor = Cursors.Hand;
        }
    }
}
