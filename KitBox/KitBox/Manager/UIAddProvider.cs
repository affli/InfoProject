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
    public partial class UIAddProvider : UserControl
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");

        public UIAddProvider()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO provider(name,adress,website) VALUES('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {

                }
                else
                {
                    MessageBox.Show("Data Not Inserted.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch
            {
                MessageBox.Show("Please don't forget to import the database to PHPMYADMIN!.\n\nData Not Inserted.", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            this.Controls.Clear();
            this.Controls.Add(new UIProviders());
        }
    }
}
