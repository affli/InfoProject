using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KitBox
{
    public partial class FH : Form
    {
        UIUpdateCatalogue UC;
        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");

        public UIUpdateCatalogue UIUpdateCatalogue
        {
            get { return UC; }
            set { UC = value; }
        }

        public FH()
        {
            InitializeComponent();
        }

        private void FH_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please fill in the boxe.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string insertQuery = "INSERT INTO heights(heights) VALUES('" + textBox1.Text + "')";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        UC.BackgroundImage = null;
                        UC.Controls.Clear();
                        UC.Controls.Add(new UIUpdateCatalogue());
                        this.Close();
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
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
