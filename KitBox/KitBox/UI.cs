using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBox
{
    partial class UI : Form
    {
        static Cabinet furniture = new Cabinet();
        static Client client = new Client();

        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            this.Controls.Add(new LaunchScreen());
        }

        public static Cabinet Cabinet()
        {
            return furniture;
        }

        public static Client Client()
        {
            return client;
        }
    }
}
