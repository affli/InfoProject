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
using MySql.Data.MySqlClient;

namespace KitBox
{
    public partial class UILogin : UserControl
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");

        public UILogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIRegister());
        }

        private void UIOrderManager_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please fill in your customer ID.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Dictionary<string, string> userInfo = new Dictionary<string, string>();

                try
                {
                    connection.Open();
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT * FROM client WHERE client_id='" + textBox1.Text + "'", connection);
                    MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                    while (myReader.Read())
                    {
                        userInfo.Add("client_id", myReader.GetString(0));
                        userInfo.Add("name", myReader.GetString(1));
                    }

                    string test = userInfo["client_id"];

                    if (test == textBox1.Text)
                    {
                        this.BackgroundImage = null;
                        this.Controls.Clear();
                        this.Controls.Add(new UIQS());
                    }
                    else
                    {
                        MessageBox.Show("Please check your customer ID.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                catch
                {
                    MessageBox.Show("Please check your customer ID.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development.\r\n", "KitBox");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new LaunchScreen());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
