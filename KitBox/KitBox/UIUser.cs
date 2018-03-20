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
        string width;
        string depth;
        string frame_color;

        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
        Dictionary<string, string> items = new Dictionary<string, string>();
        Button button;

        public UIUser(string floorNumbers, string width, string depth, string frame_color)
        {
            InitializeComponent();
            this.floorNumbers = floorNumbers;
            this.width = width;
            this.depth = depth;
            this.frame_color = frame_color;
        }

        private void UIUser_Load(object sender, EventArgs e)
        {
            try
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
                    button.Location = new Point(296 + 50 * i, 86);
                    button.Size = new Size(50, 30);
                    button.Name = "button_" + (i);
                    button.Text = i.ToString();
                    button.Click += new System.EventHandler(this.Button_Click);
                    this.Controls.Add(button);
                }

                label3.Text += " #";
            }

            catch
            {
                MessageBox.Show("Please don't forget to import the database to PHPMYADMIN!.\n\nVerify connection.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void verify()
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            button = (sender as Button);
            label3.Text = "Cabinet number " + button.Text;

            if (items.ContainsKey("Height " + button.Text))
            {
                comboBox1.Text = items["Height " + button.Text];
            }
            else
            {
                comboBox1.Text = "";
            }

            if (items.ContainsKey("Door Color " + button.Text) && comboBox4.Text == "")
            {
                comboBox2.Text = items["Door Color " + button.Text];
            }

            else
            {
                if (items.ContainsKey("Top Panel Color " + button.Text) && comboBox4.SelectedIndex == 0)
                {
                    comboBox2.Text = items["Top Panel Color " + button.Text];
                }
                else
                {
                    if (items.ContainsKey("Left Panel Color " + button.Text) && comboBox4.SelectedIndex == 1)
                    {
                        comboBox2.Text = items["Left Panel Color " + button.Text];
                    }
                    else
                    {
                        if (items.ContainsKey("Back Panel Color " + button.Text) && comboBox4.SelectedIndex == 2)
                        {
                            comboBox2.Text = items["Back Panel Color " + button.Text];
                        }
                        else
                        {
                            comboBox2.Text = "";
                        }
                    }
                }
            }

            if (items.ContainsKey("Low Panel Color " + button.Text) && comboBox4.SelectedIndex == 0)
            {
                comboBox3.Text = items["Low Panel Color " + button.Text];
            }
            else
            {
                if (items.ContainsKey("Right Panel Color " + button.Text) && comboBox4.SelectedIndex == 1)
                {
                    comboBox3.Text = items["Right Panel Color " + button.Text];
                }
                else
                {
                    comboBox3.Text = "";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(label3.Text == "Cabinet number #")
            {
                MessageBox.Show("Please choose the cabinet number.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if(items.ContainsKey("Height " + button.Text))
                    {
                        items["Height " + button.Text] = comboBox1.Text;
                        Console.WriteLine("0 " + items["Height " + button.Text]);
                    }
                    else
                    {
                        items.Add("Height " + button.Text, comboBox1.Text);
                        verify();
                        Console.WriteLine("1 " + items["Height " + button.Text]);

                    }

                }
                catch
                {
                    MessageBox.Show("In dev", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIUser(floorNumbers, width, depth, frame_color));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if ()
            //{
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new UIValidation(items));
            //}
            //else
            //{
            //    MessageBox.Show("some options have been omitted, are you sure you want to continue ?.", "Confirm",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


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
            this.Controls.Add(new UIQS());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (label3.Text == "Cabinet number #")
            {
                MessageBox.Show("Please choose the cabinet number.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (comboBox4.SelectedIndex == 0)
                    {

                        label4.Text = "Top Panel Color :";
                        label2.Text = "Low Panel Color :";

                        label2.Visible = true;
                        comboBox3.Visible = true;

                        if (items.ContainsKey("Height " + button.Text))
                        {
                            comboBox1.Text = items["Height " + button.Text];
                        }
                        else
                        {
                            comboBox1.Text = "";
                        }

                        if (items.ContainsKey("Top Panel Color " + button.Text))
                        {
                            comboBox2.Text = items["Top Panel Color " + button.Text];
                        }
                        else
                        {
                            comboBox2.Text = "";
                        }

                        if (items.ContainsKey("Low Panel Color " + button.Text))
                        {
                            comboBox3.Text = items["Low Panel Color " + button.Text];
                        }
                        else
                        {
                            comboBox3.Text = "";
                        }
                    }

                    if (comboBox4.SelectedIndex == 1)
                    {
                        label4.Text = "Left Panel Color :";
                        label2.Text = "Right Panel Color :";
                        label2.Visible = true;
                        comboBox3.Visible = true;

                        if (items.ContainsKey("Height " + button.Text))
                        {
                            comboBox1.Text = items["Height " + button.Text];
                        }
                        else
                        {
                            comboBox1.Text = "";
                        }

                        if (items.ContainsKey("Left Panel Color " + button.Text))
                        {
                            comboBox2.Text = items["Left Panel Color " + button.Text];
                        }
                        else
                        {
                            comboBox2.Text = "";
                        }

                        if (items.ContainsKey("Right Panel Color " + button.Text))
                        {
                            comboBox3.Text = items["Right Panel Color " + button.Text];
                        }
                        else
                        {
                            comboBox3.Text = "";
                        }
                    }

                    if (comboBox4.SelectedIndex == 2)
                    {
                        label2.Visible = false;
                        label4.Text = "Back Panel Color :";
                        comboBox3.Visible = false;

                        if (items.ContainsKey("Height " + button.Text))
                        {
                            comboBox1.Text = items["Height " + button.Text];
                        }
                        else
                        {
                            comboBox1.Text = "";
                        }

                        if (items.ContainsKey("Back Panel Color " + button.Text))
                        {
                            comboBox2.Text = items["Back Panel Color " + button.Text];
                        }
                        else
                        {
                            comboBox2.Text = "";
                        }
                    }
                }

                catch
                {
                    MessageBox.Show("In dev", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Door Color :";
            label2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Text = "";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label4.Text = "Door Color :";
            label2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(label4.Text == "Door Color :")
            {
                if (items.ContainsKey("Door Color " + button.Text))
                {
                    items["Door Color " + button.Text] = comboBox2.Text;
                }
                else
                {
                    items.Add("Door Color " + button.Text, comboBox2.Text);
                    verify();
                }
            }
            else if(label4.Text == "Top Panel Color :")
            {
                if (items.ContainsKey("Top Panel Color " + button.Text))
                {
                    items["Top Panel Color " + button.Text] = comboBox2.Text;
                }
                else
                {
                    items.Add("Top Panel Color " + button.Text, comboBox2.Text);
                    verify();
                }
            }

            else if (label4.Text == "Left Panel Color :")
            {
                if (items.ContainsKey("Left Panel Color " + button.Text))
                {
                    items["Left Panel Color " + button.Text] = comboBox2.Text;
                }
                else
                {
                    items.Add("Left Panel Color " + button.Text, comboBox2.Text);
                    verify();
                }
            }

            else if (label4.Text == "Back Panel Color :")
            {
                if (items.ContainsKey("Back Panel Color " + button.Text))
                {
                    items["Back Panel Color " + button.Text] = comboBox2.Text;
                }
                else
                {
                    items.Add("Back Panel Color " + button.Text, comboBox2.Text);
                    verify();
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (label2.Text == "Low Panel Color :")
            {
                if (items.ContainsKey("Low Panel Color " + button.Text))
                {
                    items["Low Panel Color " + button.Text] = comboBox3.Text;
                }
                else
                {
                    items.Add("Low Panel Color " + button.Text, comboBox3.Text);
                    verify();
                }
            }
            else if (label2.Text == "Right Panel Color :")
            {
                if (items.ContainsKey("Right Panel Color " + button.Text))
                {
                    items["Right Panel Color " + button.Text] = comboBox2.Text;
                }
                else
                {
                    items.Add("Right Panel Color " + button.Text, comboBox2.Text);
                    verify();
                }
            }
            
        }
    }
}
