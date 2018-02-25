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
    public partial class UIUser : UserControl
    {
        public UIUser()
        {
            InitializeComponent();
        }

        private void UIUser_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Heights");
            dt.Columns.Add("Heights");

            dt.Rows.Add("32");
            dt.Rows.Add("42");
            dt.Rows.Add("52");

            for (int j = 0; j < dt.Rows.Count; j++)

            {
                string text = dt.Rows[j]["Heights"].ToString();
                this.comboBox1.Items.Add(text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new LaunchScreen());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIQS());
        }
    }
}
