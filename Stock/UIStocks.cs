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
    public partial class UIStocks : UserControl

    {
		MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
		Button button;
		DataSet DS = new DataSet();

		public UIStocks()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new LaunchScreen());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIManager());
        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void UIStocks_Load(object sender, EventArgs e)
		{
			try
			{
				
				connection.Open();
				MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM stock ", connection);
				msda.Fill(DS);
				dataGridView1.DataSource = DS.Tables[0]; ;

			
				connection.Close();

				for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
				{
					Button button = new Button();
					button.Location = new Point(750, 220 + 43 * i);
					button.Size = new Size(70, 20);
					button.Name = "Del_" + DS.Tables[0].Rows[i][0].ToString();
					button.Text = "Delete " + (i + 1).ToString();
					button.Click += new EventHandler(this.Button_Click);
					this.Controls.Add(button);
				}
			}
			catch
			{
				MessageBox.Show("Please don't forget to import the database to PHPMYADMIN!.\n\nVerify connection.", "Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			connection.Close();
		}
		private void button1_Click(object sender, EventArgs e)

		{
			this.BackgroundImage = null;
			this.Controls.Clear();
			this.Controls.Add(new Manager.UIAddStock());

		}
		private void Button_Click(object sender, EventArgs e)
		{
			button = (sender as Button);
			try
			{
				string[] n = button.Name.Split('_');
                string[] m = button.Text.Split(' ');
				DS.Tables[0].Rows[Convert.ToInt16(m[1])-1].Delete();
                string insertQuery = "DELETE FROM stock WHERE stock_id = " + n[1];
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

        }

			

	}
}

