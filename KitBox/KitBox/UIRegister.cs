using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace KitBox
{
    public partial class UIRegister : UserControl
    {
        //MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");

        public UIRegister()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
            {
                MessageBox.Show("Please fill in all the boxes.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //try
                //{
                //    string insertQuery = "INSERT INTO client(name, email, phonenum) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                //    connection.Open();
                //    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                //    if (command.ExecuteNonQuery() == 1)
                //    {
                this.Controls.Clear();
                this.Controls.Add(new UIQS());
                //    }
                //    else
                //    {
                //        MessageBox.Show("Data Not Inserted.", "Error",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}

                //catch
                //{
                //    MessageBox.Show("Please don't forget to import the database to PHPMYADMIN!.\n\nData Not Inserted.", "Error",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                //connection.Close();
            }

        }

        private void UIRegister_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development.\r\n", "KitBox");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UILogin());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}