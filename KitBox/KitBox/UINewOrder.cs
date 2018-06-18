using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBox
{
    public partial class UINewOrder : UserControl
    {
        Dictionary<string, string> items = new Dictionary<string, string>();
        DatabaseManager dbm = new DatabaseManager();
        Cabinet cabinet = UI.Cabinet();
        int totalheight = 0;
        bool button4__Click = false;
        int num_Cabinet = 1;
        int number_of_lockers = 3;

        private string manager;

        public UINewOrder(string manager = null)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void UILogin_Load(object sender, EventArgs e)
        {
            dbm.select_width();
            foreach (string s in dbm.list2)
            {
                this.comboBox1.Items.Add(s);
            }

            dbm.select_depth();
            foreach (string s in dbm.list2)
            {
                this.comboBox2.Items.Add(s);
            }

            dbm.select_suport_angles_color();
            foreach (string s in dbm.list2)
            {
                this.comboBox5.Items.Add(s);
            }

            items.Add("Width", comboBox1.Items[3].ToString());
            items.Add("Depth", comboBox2.Items[0].ToString());
            items.Add("Support_Angles_Color", comboBox5.Items[0].ToString());

            if (items["Width"] != "32" || items["Width"] != "42" || items["Width"] != "52")
            {
                for (int i = 1; i <= number_of_lockers; i++)
                {
                    items.Add("Height_" + i, "32");
                    items.Add("Color_Cabinet_" + i, "White");
                    items.Add("ColorL_" + i, "White");
                    items.Add("ColorR_" + i, "White");
                }
            }
            else
            {
                for (int i = 1; i <= number_of_lockers; i++)
                {
                    items.Add("Height_" + i, "32");
                    items.Add("Color_Cabinet_" + i, "White");
                }
            }

            comboBox1.SelectedIndex = 3;
            comboBox2.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            if (this.manager == "Manager")
            {
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new UIManager());
            }
            else
            {
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new LaunchScreen());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Width";
            label2.Text = "Depth";

            comboBox3.Visible = false;
            comboBox4.Visible = false;
            button5.Visible = true;
            comboBox2.Visible = true;
            label3.Visible = false;
            button15.Visible = true;
            button4__Click = false;
            button5.Text = "+ Add Cabinet";

            label14.Visible = true;
            comboBox5.Visible = true;

            comboBox2.Items.Clear();
            dbm.select_depth();
            foreach (string s in dbm.list2)
            {
                this.comboBox2.Items.Add(s);
            }

            comboBox1.Items.Clear();
            dbm.select_width();
            foreach (string s in dbm.list2)
            {
                this.comboBox1.Items.Add(s);
            }

            if (items.ContainsKey("Width"))
            {
                comboBox1.Text = items["Width"];
            }
            else
            {
                comboBox1.Text = comboBox1.Items[3].ToString();
            }

            if (items.ContainsKey("Depth"))
            {
                comboBox2.Text = items["Depth"];
            }
            else
            {
                comboBox2.Text = comboBox2.Items[0].ToString();
            }
            update_cabinets();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4__Click = true;

            label1.Text = "Cabinet Height";
            label2.Text = "Cabinet Color";
            button5.Visible = false;
            button15.Visible = false;

            label14.Visible = false;
            comboBox5.Visible = false;

            if (items["Width"] == "32" || items["Width"] == "42" || items["Width"] == "52")
            {
                label3.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
            }
            else
            {
                label3.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
            }

            comboBox1.Items.Clear();
            dbm.select_heights();
            foreach (string s in dbm.list2)
            {
                this.comboBox1.Items.Add(s);
            }
   
            comboBox2.Items.Clear();
            comboBox2.Items.Add("White");
            comboBox2.Items.Add("Brown");


            if (items.ContainsKey("Color_Cabinet_" + num_Cabinet))
            {
                comboBox2.Text = items["Color_Cabinet_" + num_Cabinet];
            }
            else
            {
                comboBox2.Text = comboBox2.Items[0].ToString();
            }


            update_cabinets();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button4__Click == false)
            {
                label4.Text = "Width : " + comboBox1.Text;

                if (items.ContainsKey("Width") && label1.Text == "Width")
                {
                    items["Width"] = comboBox1.Text;
                }

                else if(label1.Text == "Width")
                {
                    items.Add("Width", comboBox1.Text);
                }

                if (comboBox1.Text == "32" || comboBox1.Text == "42" || comboBox1.Text == "52")
                {

                    if (items.ContainsKey("Width") && label1.Text == "Width")
                    {
                        items["Width"] = comboBox1.Text;
                    }

                    else if (label1.Text == "Width")
                    {
                        items.Add("Width", comboBox1.Text);
                    }

                    for(int i = 1; i <= number_of_lockers; i++)
                    {
                        items.Remove("ColorR_" + i);
                        items.Remove("ColorL_" + i);
                    }

                    label13.Text = "No doors for this width";
                    update_cabinets();
                }
                else
                {
                    for (int i = 1; i <= number_of_lockers; i++)
                    {
                        if (items.ContainsKey("ColorL_" + i) && label1.Text == "Width")
                        {
                        }

                        else if (label1.Text == "Width")
                        {
                            items.Add("ColorL_" + i, "White");
                            items.Add("ColorR_" + i, "White");
                        }
                    }

                    label13.Text = "";
                    update_cabinets();
                }
            }

            if(button4__Click == true)
            {
                if (items.ContainsKey("Height_" + num_Cabinet) && label1.Text == "Cabinet Height")
                {
                    items["Height_" + num_Cabinet] = comboBox1.Text;
                }

                else if (label1.Text == "Cabinet Height")
                {
                    items.Add("Height_" + num_Cabinet, comboBox1.Text);
                }

                if (num_Cabinet == 1)
                {
                    label6.Text = comboBox1.Text;
                }

                if (num_Cabinet == 2)
                {
                    label7.Text = comboBox1.Text;
                }
                if (num_Cabinet == 3)
                {
                    label8.Text = comboBox1.Text;
                }
                if (num_Cabinet == 4)
                {
                    label9.Visible = true;
                    label9.Text = comboBox1.Text;
                }
                if (num_Cabinet == 5)
                {
                    label10.Visible = true;
                    label10.Text = comboBox1.Text;
                }
                if (num_Cabinet == 6)
                {
                    label11.Visible = true;
                    label11.Text = comboBox1.Text;
                }
                if (num_Cabinet == 7)
                {
                    label12.Visible = true;
                    label12.Text = comboBox1.Text;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button4__Click == false)
            {
                label5.Text = "Depth : " + comboBox2.Text;

                if (items.ContainsKey("Depth"))
                {
                    items["Depth"] = comboBox2.Text;
                }

                else
                {
                    items.Add("Depth", comboBox2.Text);
                }
            }

            else if (button4__Click == true)
            {
                if (items.ContainsKey("Color_Cabinet_" + num_Cabinet))
                {
                    items["Color_Cabinet_" + num_Cabinet] = comboBox2.Text;
                }

                else
                {
                    items.Add("Color_Cabinet_" + num_Cabinet, comboBox2.Text);
                }

                update_cabinets();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "None")
            {
                items.Remove("ColorL_" + num_Cabinet);
            }
            else if (items.ContainsKey("ColorL_" + num_Cabinet))
            {
                items["ColorL_" + num_Cabinet] = comboBox3.Text;
            }

            else
            {
                items.Add("ColorL_" + num_Cabinet, comboBox3.Text);
            }

            update_cabinets();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "None")
            {
                items.Remove("ColorR_" + num_Cabinet);
            }

            else if (items.ContainsKey("ColorR_" + num_Cabinet))
            {
                items["ColorR_" + num_Cabinet] = comboBox4.Text;
            }

            else
            {
                items.Add("ColorR_" + num_Cabinet, comboBox4.Text);
            }

            update_cabinets();
        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            num_Cabinet = 1;
            update_cabinets();
        }

        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            num_Cabinet = 2;
            update_cabinets();
        }

        private void Panel3_MouseClick(object sender, MouseEventArgs e)
        {
            num_Cabinet = 3;
            update_cabinets();
        }

        private void Panel4_MouseClick(object sender, MouseEventArgs e)
        {
            num_Cabinet = 4;
            update_cabinets();
        }

        private void Panel5_MouseClick(object sender, MouseEventArgs e)
        {
            num_Cabinet = 5;
            update_cabinets();
        }

        private void Panel6_MouseClick(object sender, MouseEventArgs e)
        {
            num_Cabinet = 6;
            update_cabinets();
        }

        private void Panel7_MouseClick(object sender, MouseEventArgs e)
        {
            num_Cabinet = 7;
            update_cabinets();
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                Panel1.Cursor = Cursors.Hand;
            }
            else
            {
                Panel1.Cursor = Cursors.Default;
            }
        }

        private void Panel2_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                Panel2.Cursor = Cursors.Hand;
            }
            else
            {
                Panel2.Cursor = Cursors.Default;
            }

        }

        private void Panel3_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                Panel3.Cursor = Cursors.Hand;
            }
            else
            {
                Panel3.Cursor = Cursors.Default;
            }
        }

        private void Panel4_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                Panel4.Cursor = Cursors.Hand;
            }
            else
            {
                Panel4.Cursor = Cursors.Default;
            }
        }

        private void Panel5_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                Panel5.Cursor = Cursors.Hand;
            }
            else
            {
                Panel5.Cursor = Cursors.Default;
            }
        }

        private void Panel6_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                Panel6.Cursor = Cursors.Hand;
            }
            else
            {
                Panel6.Cursor = Cursors.Default;
            }
        }

        private void Panel7_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                Panel7.Cursor = Cursors.Hand;
            }
            else
            {
                Panel7.Cursor = Cursors.Default;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (number_of_lockers == 1)
            {
                Panel2.Visible = true;
                label7.Visible = true;
                number_of_lockers = 2;
            }

            else if (number_of_lockers == 2)
            {
                Panel3.Visible = true;
                label8.Visible = true;
                number_of_lockers = 3;
            }

            else if (number_of_lockers == 3)
            {
                Panel4.Visible = true;
                label9.Visible = true;
                number_of_lockers = 4;
            }

            else if (number_of_lockers == 4)
            {
                Panel5.Visible = true;
                label10.Visible = true;
                number_of_lockers = 5;
            }

            else if (number_of_lockers == 5)
            {
                Panel6.Visible = true;
                label11.Visible = true;
                number_of_lockers = 6;
            }

            else if (number_of_lockers == 6)
            {
                Panel7.Visible = true;
                label12.Visible = true;
                number_of_lockers = 7;
            }

            if (items["Width"] == "32" || items["Width"] == "42" || items["Width"] == "52")
            {
                if (items.ContainsKey("Height_" + number_of_lockers))
                {

                }

                else
                {
                    items.Add("Height_" + number_of_lockers, "32");
                    items.Add("Color_Cabinet_" + number_of_lockers, "White");
                }

            }
            else
            {
                if (items.ContainsKey("Height_" + number_of_lockers))
                {

                }

                else
                {
                    items.Add("Height_" + number_of_lockers, "32");
                    items.Add("Color_Cabinet_" + number_of_lockers, "White");
                    items.Add("ColorR_" + number_of_lockers, "White");
                    items.Add("ColorL_" + number_of_lockers, "White");
                }

            }
            update_cabinets();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (number_of_lockers == 7)
            {
                items.Remove("Height_" + number_of_lockers);
                items.Remove("Color_Cabinet_" + number_of_lockers);
                items.Remove("ColorR_" + number_of_lockers);
                items.Remove("ColorL_" + number_of_lockers);

                Panel7.Visible = false;
                label12.Visible = false;
                number_of_lockers = 6;
            }

            else if (number_of_lockers == 6)
            {
                items.Remove("Height_" + number_of_lockers);
                items.Remove("Color_Cabinet_" + number_of_lockers);
                items.Remove("ColorR_" + number_of_lockers);
                items.Remove("ColorL_" + number_of_lockers);

                Panel6.Visible = false;
                label11.Visible = false;
                number_of_lockers = 5;
            }

            else if (number_of_lockers == 5)
            {
                items.Remove("Height_" + number_of_lockers);
                items.Remove("Color_Cabinet_" + number_of_lockers);
                items.Remove("ColorR_" + number_of_lockers);
                items.Remove("ColorL_" + number_of_lockers);

                Panel5.Visible = false;
                label10.Visible = false;
                number_of_lockers = 4;
            }

            else if (number_of_lockers == 4)
            {
                items.Remove("Height_" + number_of_lockers);
                items.Remove("Color_Cabinet_" + number_of_lockers);
                items.Remove("ColorR_" + number_of_lockers);
                items.Remove("ColorL_" + number_of_lockers);

                Panel4.Visible = false;
                label9.Visible = false;
                number_of_lockers = 3;
            }

            else if (number_of_lockers == 3)
            {
                items.Remove("Height_" + number_of_lockers);
                items.Remove("Color_Cabinet_" + number_of_lockers);
                items.Remove("ColorR_" + number_of_lockers);
                items.Remove("ColorL_" + number_of_lockers);

                number_of_lockers = 2;
                Panel3.Visible = false;
                label8.Visible = false;
            }

            else if (number_of_lockers == 2)
            {
                items.Remove("Height_" + number_of_lockers);
                items.Remove("Color_Cabinet_" + number_of_lockers);
                items.Remove("ColorR_" + number_of_lockers);
                items.Remove("ColorL_" + number_of_lockers);

                Panel2.Visible = false;
                label7.Visible = false;
                number_of_lockers = 1;
            }
        }

        private void update_cabinets()
        {
            if (button4__Click == true)
            {
                for (int i = 1; i <= number_of_lockers; i++)
                {
                    if (items.ContainsKey("Color_Cabinet_" + i) && items.ContainsKey("ColorL_" + i) && items.ContainsKey("ColorR_" + i))
                    {
                        object O = Properties.Resources.ResourceManager.GetObject(items["Color_Cabinet_" + i] + "_" + items["ColorL_" + i] + "_"
                            + items["ColorR_" + i] + "_1");

                        this.Controls.Find("Panel" + i, true)[0].BackgroundImage = (Image)O;
                    }

                    else
                    {
                        if (items.ContainsKey("Color_Cabinet_" + i))
                        {
                            object O = Properties.Resources.ResourceManager.GetObject(items["Color_Cabinet_" + i] + "_1");

                            this.Controls.Find("Panel" + i, true)[0].BackgroundImage = (Image)O;
                        }
                    }
                }

                if (items.ContainsKey("Color_Cabinet_" + num_Cabinet) && items.ContainsKey("ColorL_" + num_Cabinet) && items.ContainsKey("ColorR_" + num_Cabinet))
                {
                    object O = Properties.Resources.ResourceManager.GetObject(items["Color_Cabinet_" + num_Cabinet] + "_" + items["ColorL_" + num_Cabinet] + "_"
                        + items["ColorR_" + num_Cabinet]);

                    this.Controls.Find("Panel" + num_Cabinet, true)[0].BackgroundImage = (Image)O;
                }

                else
                {
                    if (items.ContainsKey("Color_Cabinet_" + num_Cabinet) )
                    {
                        object O = Properties.Resources.ResourceManager.GetObject(items["Color_Cabinet_" + num_Cabinet]);

                        this.Controls.Find("Panel" + num_Cabinet, true)[0].BackgroundImage = (Image)O;
                    }
                }

                if (items.ContainsKey("Height_" + num_Cabinet))
                {
                    comboBox1.Text = items["Height_" + num_Cabinet];
                }
                else
                {
                    comboBox1.Text = "32";
                }
            }

            else
            {
                for (int i = 1; i <= number_of_lockers; i++)
                {
                    if (items.ContainsKey("Color_Cabinet_" + i) && items.ContainsKey("ColorL_" + i) && items.ContainsKey("ColorR_" + i))
                    {
                        object O = Properties.Resources.ResourceManager.GetObject(items["Color_Cabinet_" + i] + "_" + items["ColorL_" + i] + "_"
                            + items["ColorR_" + i]);

                        this.Controls.Find("Panel" + i, true)[0].BackgroundImage = (Image)O;  
                    }

                    else
                    {
                        object O = Properties.Resources.ResourceManager.GetObject(items["Color_Cabinet_" + i]);

                        this.Controls.Find("Panel" + i, true)[0].BackgroundImage = (Image)O;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Locker[] locker = new Locker[number_of_lockers];

            for (int x = 0; x < number_of_lockers; x++)
            {
                locker[x] = new Locker();
            }

            

            cabinet.Setinfo(Convert.ToInt32(items["Depth"]), Convert.ToInt32(items["Depth"]));
            cabinet.Getsupport().Setcolor(items["Support_Angles_Color"]);

            string pastcolor = "";
        
            foreach (KeyValuePair<string, string> pair in items)
            {
                string[] elem = pair.Key.Split('_');

                if (elem[0] == "ColorL" || elem[0] == "ColorR")
                {                   
                    if (pastcolor == "")
                    {
                        pastcolor = pair.Value;
                    }
                    else if (pastcolor == pair.Value)
                    {
                        Door door = new Door(pair.Value);
                        locker[Convert.ToInt32(elem[elem.Length - 1]) - 1].Addproduct(door, 2);
                        locker[Convert.ToInt32(elem[elem.Length - 1]) - 1].Adddoors(door);
                        locker[Convert.ToInt32(elem[elem.Length - 1]) - 1].Adddoors(door);
                        pastcolor = "";
                    }
                    else
                    {
                        Door pastdoor = new Door(pastcolor);
                        Door door = new Door(pair.Value);
                        locker[Convert.ToInt32(elem[elem.Length - 1]) - 1].Addproduct(pastdoor, 1);
                        locker[Convert.ToInt32(elem[elem.Length - 1]) - 1].Addproduct(door, 1);
                        locker[Convert.ToInt32(elem[elem.Length - 1]) - 1].Adddoors(pastdoor);
                        locker[Convert.ToInt32(elem[elem.Length - 1]) - 1].Adddoors(door);
                        pastcolor = "";
                    }
                }

                else if (elem[0] == "Height")
                {
                    totalheight += Convert.ToInt32(pair.Value);
                    locker[Convert.ToInt32(elem[elem.Length - 1]) - 1].Setheight(Convert.ToInt32(pair.Value));
                }

                else if (elem.Length >= 3 && elem[1] == "Cabinet")
                {
                    Panel panel = new Panel("HB", pair.Value);
                    locker[Convert.ToInt32(elem[2]) - 1].Addproduct(panel, 2);

                    panel = new Panel("GD", pair.Value);
                    locker[Convert.ToInt32(elem[2]) - 1].Addproduct(panel, 2);

                    panel = new Panel("AR", pair.Value);
                    locker[Convert.ToInt32(elem[2]) - 1].Addproduct(panel, 1);
                }
                
            }

            cabinet.Setheight(totalheight);

            foreach (Locker lockeur in locker)
            {
                Cleat cleat = new Cleat();
                cleat.Setheight(lockeur.Getheight() - 4);
                lockeur.Addproduct(cleat, 4);

                Rails railAV = new Rails();
                railAV.Setdepth(cabinet.Getwidth());
                railAV.Setinfo("Front", true);
                lockeur.Addproduct(railAV, 2);

                Rails railART = new Rails();
                railART.Setdepth(cabinet.Getwidth());
                railART.Setinfo("Back", true);
                lockeur.Addproduct(railART, 1);

                Rails railARF = new Rails();
                railARF.Setdepth(cabinet.Getwidth());
                railARF.Setinfo("Back", false);
                lockeur.Addproduct(railARF, 1);

                Rails railLATT = new Rails();
                railLATT.Setdepth(cabinet.Getwidth());
                railLATT.Setinfo("Lateral", true);
                lockeur.Addproduct(railLATT, 1);

                Rails railLATF = new Rails();
                railLATF.Setdepth(cabinet.Getwidth());
                railLATF.Setinfo("Lateral", false);
                lockeur.Addproduct(railLATF, 3);

                cabinet.AddLocker(lockeur);
            }

            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIValidate());
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (items.ContainsKey("Support_Angles_Color"))
            {
                items["Support_Angles_Color"] = comboBox5.Text;
            }

            else
            {
                items.Add("Support_Angles_Color", comboBox5.Text);
            }
        }

        private void back_button_MouseEnter(object sender, EventArgs e)
        {
            back_button.Cursor = Cursors.Hand;
        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
