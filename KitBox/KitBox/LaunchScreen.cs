using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace KitBox
{
    public partial class LaunchScreen : UserControl
    {
        public LaunchScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIOrderManager());
        }

        private void LaunchScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToString("dd/MMM/yyyy", new CultureInfo("en"));

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development.\r\n", "KitBox");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development.\r\n", "KitBox");
        }
    }
}
