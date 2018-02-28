using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KitBox
{
    public partial class UIQS : UserControl
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");

        public UIQS()
        {
            InitializeComponent();
        }

        private void UIQS_Load(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand sqlCmd2 = new MySqlCommand("SELECT floor FROM floor", connection);
            MySqlDataReader myReader2 = sqlCmd2.ExecuteReader();

            while (myReader2.Read())
            {
                this.comboBox1.Items.Add(myReader2.GetString(0));
            }
            connection.Close();

            connection.Open();
            MySqlCommand sqlCmd3 = new MySqlCommand("SELECT width FROM width", connection);
            MySqlDataReader myReader3 = sqlCmd3.ExecuteReader();

            while (myReader3.Read())
            {
                this.comboBox2.Items.Add(myReader3.GetString(0));
            }
            connection.Close();

            connection.Open();
            MySqlCommand sqlCmd4 = new MySqlCommand("SELECT depth FROM depth", connection);
            MySqlDataReader myReader4 = sqlCmd4.ExecuteReader();

            while (myReader4.Read())
            {
                this.comboBox3.Items.Add(myReader4.GetString(0));
            }
            connection.Close();
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
                this.Controls.Add(new UIUser(comboBox1.Text));
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
