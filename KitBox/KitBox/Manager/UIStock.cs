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
    public partial class UIStock : UserControl
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; ; database = kitbox;");
        Button button;
        DataSet DS = new DataSet();

        public UIStock()
        {
            InitializeComponent();
        }

        private void UIStock_Load(object sender, EventArgs e)
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
                    button.Location = new Point(900, 150 + 43 * i);
                    button.Size = new Size(30, 30);
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

        private void Button_Click(object sender, EventArgs e)
        {
            button = (sender as Button);

            try
            {
                string[] n = button.Text.Split(' ');
                string insertQuery = "DELETE FROM stock WHERE stock_id = " + (DS.Tables[0].Rows[Convert.ToInt16(n[1]) - 1][0]).ToString();

                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                DS.Tables[0].Rows[Convert.ToInt16(n[1]) - 1].Delete();
                if (command.ExecuteNonQuery() == 1)
                {
                    this.BackgroundImage = null;
                    this.Controls.Clear();
                    this.Controls.Add(new UIStock());
                }
                else
                {
                    MessageBox.Show("Data Not Deleted.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }

            catch
            {
                MessageBox.Show("LOLOLOL", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIAddStock());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIStockResearch());
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIManager());
        }
    }
}
