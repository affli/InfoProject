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
    public partial class UIAddStock : UserControl
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; ; database = kitbox;");

        public UIAddStock()
        {
            InitializeComponent();
        }

        private void UIAddStock_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Classic door");
            this.comboBox1.Items.Add("Cleat");
            this.comboBox1.Items.Add("Client");
            this.comboBox1.Items.Add("Door");
            this.comboBox1.Items.Add("Glass door");
            this.comboBox1.Items.Add("Panel");
            this.comboBox1.Items.Add("Support angle");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string insertQuery = "INSERT INTO stock (stuff,color,height,width) VALUES ('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox7.Text + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    this.BackgroundImage = null;
                    this.Controls.Clear();
                    this.Controls.Add(new UIStock());

                }
                else
                {
                    MessageBox.Show("Data Not Inserted.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIStock());
        }
    }
}
