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

namespace KitBox.Manager
{
	public partial class UIAddStock : UserControl
	{
		MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
		
		public UIAddStock()
		{
			InitializeComponent();
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void UIAddStock_Load(object sender, EventArgs e)
		{
           
        }

		private void pictureBox3_Click(object sender, EventArgs e)
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
			this.BackgroundImage = null;
			this.Controls.Clear();
			this.Controls.Add(new UIStocks());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string insertQuery = "INSERT INTO stock (stuff,color,height,witdh) VALUES ('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox7.Text + "')";
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
            this.Controls.Add(new UIStocks());
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}


		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}