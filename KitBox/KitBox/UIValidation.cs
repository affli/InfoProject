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
    public partial class UIValidation : UserControl
    {
        Dictionary<string, string> items;

        public UIValidation(Dictionary<string, string> items)
        {
            this.items = items;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIFinal());
        }

        private void UIValidation_Load(object sender, EventArgs e)
        {
            Console.WriteLine("passed " + items["Height 1"]);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new LaunchScreen());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
