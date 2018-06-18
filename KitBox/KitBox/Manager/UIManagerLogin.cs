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
    public partial class UIManagerLogin : UserControl
    {
        public UIManagerLogin()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            if (password_textbox.Text == "manager")
            {
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new UIManager());
            }

            else
            {
                MessageBox.Show("Please enter a valid password.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void enter_button_MouseEnter(object sender, EventArgs e)
        {
            enter_button.Cursor = Cursors.Hand;
        }

        private void password_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enter_button.PerformClick();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new LaunchScreen());
        }
    }
}
