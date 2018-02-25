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
    public partial class UIQS : UserControl
    {
        public UIQS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("") || comboBox2.Text.Equals("") || comboBox3.Text.Equals(""))
            {
                MessageBox.Show("Please fill in your choices.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new UIUser());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new LaunchScreen());
        }
    }
}
