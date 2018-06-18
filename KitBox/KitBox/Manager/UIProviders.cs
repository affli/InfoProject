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
    public partial class UIProviders : UserControl
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
        Button button;

        public UIProviders()
        {
            InitializeComponent();
        }

        private void UIProviders_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> Numb = new List<string>();
                connection.Open();
                MySqlCommand sqlCmd2 = new MySqlCommand("SELECT * FROM provider ", connection);
                MySqlDataReader myReader2 = sqlCmd2.ExecuteReader();

                while (myReader2.Read())
                {
                    Numb.Add(myReader2.GetString(0));
                    this.listBox1.Items.Add("-" + "    " + myReader2.GetString(1) + "    " + myReader2.GetString(2) + "    " + myReader2.GetString(3));
                }
                connection.Close();

                for (int i = 0; i < Numb.Count; i++)
                {
                    Button button = new Button();
                    button.Location = new Point(900, 100 + 43 * i);
                    button.Size = new Size(30, 30);
                    button.Name = "Del_" + Numb[i];
                    button.Text = "Del " + (i + 1).ToString();
                    button.Click += new EventHandler(this.Button_Click);
                    this.Controls.Add(button);
                }
            }
            catch
            {
                MessageBox.Show("Please don't forget to import the database to PHPMYADMIN!.\n\nVerify connection.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            button = (sender as Button);

            try
            {
                string[] n = button.Name.Split('_');
                string insertQuery = "DELETE FROM provider WHERE provider_id = " + n[1];
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
            this.Controls.Clear();
            this.Controls.Add(new UIProviders());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UIAddProvider());
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIManager());
        }
    }
}
