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
    public partial class UIOrders : UserControl
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
        Button button;
        DataSet DS = new DataSet();

        public UIOrders()
        {
            InitializeComponent();
        }

        private void UIOrders_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM command ", connection);
                msda.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                connection.Close();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    Button button = new Button();
                    button.Location = new Point(790, 193 + 24 * i);
                    button.Size = new Size(67, 19);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UINewOrder());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();

            if (changes != null)
            {
                connection.Open();

                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM command ", connection);
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(msda);
                msda.UpdateCommand = mcb.GetUpdateCommand();
                msda.Update(changes);

                ((DataTable)dataGridView1.DataSource).AcceptChanges();

                connection.Close();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            button = (sender as Button);
            try
            {
                string[] n = button.Text.Split(' ');
                DS.Tables[0].Rows[Convert.ToInt16(n[1]) - 1].Delete();
            }

            catch
            {
                MessageBox.Show("LOLOLOL", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
