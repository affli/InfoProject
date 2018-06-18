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
    public partial class UIStockResearch : UserControl
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; ; database = kitbox;");
        DataTable data = new DataTable();

        public UIStockResearch()
        {
            InitializeComponent();
        }

        private void UIStockResearch_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Stuff");
            this.comboBox1.Items.Add("Color");
            this.comboBox1.Items.Add("Height");
            this.comboBox1.Items.Add("Width");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            data.Clear();

            connection.Open();
            if (comboBox1.Text == "Stuff")
            {
                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT stuff,color,height,width FROM stock WHERE Stuff LIKE '" + textBox1.Text + "%'", connection);
                msda.Fill(data);
            }
            else if (comboBox1.Text == "Color")
            {

                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT stuff,color,height,width FROM stock WHERE Color LIKE '" + textBox1.Text + "%'", connection);
                msda.Fill(data);
            }
            else if (comboBox1.Text == "Height")
            {

                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT stuff,color,height,width FROM stock WHERE Height LIKE '" + textBox1.Text + "%'", connection);
                msda.Fill(data);
            }
            else if (comboBox1.Text == "Width")
            {

                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT stuff,color,height,width FROM stock WHERE Width LIKE '" + textBox1.Text + "%'", connection);
                msda.Fill(data);
            }

            dataGridView1.DataSource = data;

            connection.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIStock());
        }
    }
}
