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
    public partial class UIUser : UserControl
    {
        string floorNumbers;

        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");

        public UIUser(string floorNumbers)
        {
            InitializeComponent();
            this.floorNumbers = floorNumbers;
        }

        private void UIUser_Load(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand sqlCmd2 = new MySqlCommand("SELECT heights FROM heights", connection);
            MySqlDataReader myReader2 = sqlCmd2.ExecuteReader();

            while (myReader2.Read())
            {
                this.comboBox1.Items.Add(myReader2.GetString(0));
            }

            for (int i = 1; i < Convert.ToInt32(floorNumbers) + 1; i++)
            {
                Button button = new Button();
                button.Location = new Point(312 +50*i, 56);
                button.Size = new Size(50, 30);
                button.Name = "button_" + (i);
                button.Text = i.ToString();
                button.Click += new System.EventHandler(this.Button_Click);
                this.Controls.Add(button);
            }

            label3.Text += " #";

            

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            label3.Text = "Cabinet number " + button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new LaunchScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIQS());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
