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
    public partial class UIUpdateCatalogue : UserControl
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");

        public UIUpdateCatalogue()
        {
            InitializeComponent();
        }

        private void UIUpdateCatalogue_Load(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand sqlCmd1 = new MySqlCommand("SELECT heights FROM heights", connection);
            MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

            while (myReader1.Read())
            {
                this.comboBox1.Items.Add(myReader1.GetString(0));
            }
            connection.Close();

            connection.Open();
            MySqlCommand sqlCmd2 = new MySqlCommand("SELECT floor FROM floor", connection);
            MySqlDataReader myReader2 = sqlCmd2.ExecuteReader();

            while (myReader2.Read())
            {
                this.comboBox2.Items.Add(myReader2.GetString(0));
            }
            connection.Close();

            connection.Open();
            MySqlCommand sqlCmd3 = new MySqlCommand("SELECT width FROM width", connection);
            MySqlDataReader myReader3 = sqlCmd3.ExecuteReader();

            while (myReader3.Read())
            {
                this.comboBox3.Items.Add(myReader3.GetString(0));
            }
            connection.Close();

            connection.Open();
            MySqlCommand sqlCmd4 = new MySqlCommand("SELECT depth FROM depth", connection);
            MySqlDataReader myReader4 = sqlCmd4.ExecuteReader();

            while (myReader4.Read())
            {
                this.comboBox4.Items.Add(myReader4.GetString(0));
            }
            connection.Close();
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FH f1 = new FH();
            f1.UIUpdateCatalogue = this;
            f1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "DELETE FROM heights WHERE heights = " + comboBox1.Text;
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {

                }
                else
                {
                    MessageBox.Show("Data Not Deleted.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

                catch
                {
                    MessageBox.Show("Please don't forget to import the database to PHPMYADMIN!.\n\nData Not Deleted.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIManager());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new LaunchScreen());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
