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
    public partial class UINewOrder : UserControl
    {
        Dictionary<string, string> items = new Dictionary<string, string>();
        DatabaseManager dbm = new DatabaseManager();
        Cabinet cabinet = UI.Cabinet();
        int totalheight = 0;
        bool button4__Click = false;
        int num_casier = 1;
        int nombre_casiers = 3;

        public UINewOrder()
        {
            InitializeComponent();
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

            items.Add("Largeur", comboBox1.Items[3].ToString());
            items.Add("Profondeur", comboBox2.Items[0].ToString());
            items.Add("Couleur_Cornières", comboBox5.Items[0].ToString());

            if (items["Largeur"] != "32" || items["Largeur"] != "42" || items["Largeur"] != "52")
            {
                for (int i = 1; i <= nombre_casiers; i++)
                {
                    items.Add("Hauteur_" + i, "32");
                    items.Add("Couleur_casier_" + i, "White");
                    items.Add("CouleurG_" + i, "White");
                    items.Add("CouleurD_" + i, "White");
                }
            }
            else
            {
                for (int i = 1; i <= nombre_casiers; i++)
                {
                    items.Add("Hauteur_" + i, "32");
                    items.Add("Couleur_casier_" + i, "White");
                }
            }

            comboBox1.SelectedIndex = 3;
            comboBox2.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new LaunchScreen());
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

            if (items.ContainsKey("Largeur"))
            {
                comboBox1.Text = items["Largeur"];
            }
            else
            {
                comboBox1.Text = comboBox1.Items[3].ToString();
            }

            if (items.ContainsKey("Profondeur"))
            {
                comboBox2.Text = items["Profondeur"];
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

            if (items["Largeur"] == "32" || items["Largeur"] == "42" || items["Largeur"] == "52")
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


            if (items.ContainsKey("Couleur_casier_" + num_casier))
            {
                comboBox2.Text = items["Couleur_casier_" + num_casier];
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

                if (items.ContainsKey("Largeur") && label1.Text == "Width")
                {
                    items["Largeur"] = comboBox1.Text;
                }

                else if(label1.Text == "Width")
                {
                    items.Add("Largeur", comboBox1.Text);
                }

                if (comboBox1.Text == "32" || comboBox1.Text == "42" || comboBox1.Text == "52")
                {

                    if (items.ContainsKey("Largeur") && label1.Text == "Width")
                    {
                        items["Largeur"] = comboBox1.Text;
                    }

                    else if (label1.Text == "Width")
                    {
                        items.Add("Largeur", comboBox1.Text);
                    }

                    for(int i = 1; i <= nombre_casiers; i++)
                    {
                        items.Remove("CouleurD_" + i);
                        items.Remove("CouleurG_" + i);
                    }

                    label13.Text = "No doors for this width";
                    update_cabinets();
                }
                else
                {
                    for (int i = 1; i <= nombre_casiers; i++)
                    {
                        if (items.ContainsKey("CouleurG_" + i) && label1.Text == "Width")
                        {
                        }

                        else if (label1.Text == "Width")
                        {
                            items.Add("CouleurG_" + i, "White");
                            items.Add("CouleurD_" + i, "White");
                        }
                    }

                    label13.Text = "";
                    update_cabinets();
                }
            }

            if(button4__Click == true)
            {
                if (items.ContainsKey("Hauteur_" + num_casier) && label1.Text == "Cabinet Height")
                {
                    items["Hauteur_" + num_casier] = comboBox1.Text;
                }

                else if (label1.Text == "Cabinet Height")
                {
                    items.Add("Hauteur_" + num_casier, comboBox1.Text);
                }

                if (num_casier == 1)
                {
                    label6.Text = comboBox1.Text;
                }

                if (num_casier == 2)
                {
                    label7.Text = comboBox1.Text;
                }
                if (num_casier == 3)
                {
                    label8.Text = comboBox1.Text;
                }
                if (num_casier == 4)
                {
                    label9.Visible = true;
                    label9.Text = comboBox1.Text;
                }
                if (num_casier == 5)
                {
                    label10.Visible = true;
                    label10.Text = comboBox1.Text;
                }
                if (num_casier == 6)
                {
                    label11.Visible = true;
                    label11.Text = comboBox1.Text;
                }
                if (num_casier == 7)
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

                if (items.ContainsKey("Profondeur"))
                {
                    items["Profondeur"] = comboBox2.Text;
                }

                else
                {
                    items.Add("Profondeur", comboBox2.Text);
                }
            }

            else if (button4__Click == true)
            {
                if (items.ContainsKey("Couleur_casier_" + num_casier))
                {
                    items["Couleur_casier_" + num_casier] = comboBox2.Text;
                }

                else
                {
                    items.Add("Couleur_casier_" + num_casier, comboBox2.Text);
                }

                update_cabinets();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "None")
            {
                items.Remove("CouleurG_" + num_casier);
            }
            else if (items.ContainsKey("CouleurG_" + num_casier))
            {
                items["CouleurG_" + num_casier] = comboBox3.Text;
            }

            else
            {
                items.Add("CouleurG_" + num_casier, comboBox3.Text);
            }

            update_cabinets();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "None")
            {
                items.Remove("CouleurD_" + num_casier);
            }

            else if (items.ContainsKey("CouleurD_" + num_casier))
            {
                items["CouleurD_" + num_casier] = comboBox4.Text;
            }

            else
            {
                items.Add("CouleurD_" + num_casier, comboBox4.Text);
            }

            update_cabinets();
        }

        private void panelShelf1_MouseClick(object sender, MouseEventArgs e)
        {
            num_casier = 1;
            update_cabinets();
        }

        private void panelShelf2_MouseClick(object sender, MouseEventArgs e)
        {
            num_casier = 2;
            update_cabinets();
        }

        private void panelShelf3_MouseClick(object sender, MouseEventArgs e)
        {
            num_casier = 3;
            update_cabinets();
        }

        private void panelShelf4_MouseClick(object sender, MouseEventArgs e)
        {
            num_casier = 4;
            update_cabinets();
        }

        private void panelShelf5_MouseClick(object sender, MouseEventArgs e)
        {
            num_casier = 5;
            update_cabinets();
        }

        private void panelShelf6_MouseClick(object sender, MouseEventArgs e)
        {
            num_casier = 6;
            update_cabinets();
        }

        private void panelShelf7_MouseClick(object sender, MouseEventArgs e)
        {
            num_casier = 7;
            update_cabinets();
        }

        private void panelShelf1_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                panelShelf1.Cursor = Cursors.Hand;
            }
            else
            {
                panelShelf1.Cursor = Cursors.Default;
            }
        }

        private void panelShelf2_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                panelShelf2.Cursor = Cursors.Hand;
            }
            else
            {
                panelShelf2.Cursor = Cursors.Default;
            }

        }

        private void panelShelf3_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                panelShelf3.Cursor = Cursors.Hand;
            }
            else
            {
                panelShelf3.Cursor = Cursors.Default;
            }
        }

        private void panelShelf4_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                panelShelf4.Cursor = Cursors.Hand;
            }
            else
            {
                panelShelf4.Cursor = Cursors.Default;
            }
        }

        private void panelShelf5_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                panelShelf5.Cursor = Cursors.Hand;
            }
            else
            {
                panelShelf5.Cursor = Cursors.Default;
            }
        }

        private void panelShelf6_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                panelShelf6.Cursor = Cursors.Hand;
            }
            else
            {
                panelShelf6.Cursor = Cursors.Default;
            }
        }

        private void panelShelf7_MouseEnter(object sender, EventArgs e)
        {
            if (button4__Click == true)
            {
                panelShelf7.Cursor = Cursors.Hand;
            }
            else
            {
                panelShelf7.Cursor = Cursors.Default;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nombre_casiers == 1)
            {
                panelShelf2.Visible = true;
                label7.Visible = true;
                nombre_casiers = 2;
            }

            else if (nombre_casiers == 2)
            {
                panelShelf3.Visible = true;
                label8.Visible = true;
                nombre_casiers = 3;
            }

            else if (nombre_casiers == 3)
            {
                panelShelf4.Visible = true;
                label9.Visible = true;
                nombre_casiers = 4;
            }

            else if (nombre_casiers == 4)
            {
                panelShelf5.Visible = true;
                label10.Visible = true;
                nombre_casiers = 5;
            }

            else if (nombre_casiers == 5)
            {
                panelShelf6.Visible = true;
                label11.Visible = true;
                nombre_casiers = 6;
            }

            else if (nombre_casiers == 6)
            {
                panelShelf7.Visible = true;
                label12.Visible = true;
                nombre_casiers = 7;
            }

            if (items["Largeur"] == "32" || items["Largeur"] == "42" || items["Largeur"] == "52")
            {
                if (items.ContainsKey("Hauteur_" + nombre_casiers))
                {

                }

                else
                {
                    items.Add("Hauteur_" + nombre_casiers, "32");
                    items.Add("Couleur_casier_" + nombre_casiers, "White");
                }

            }
            else
            {
                if (items.ContainsKey("Hauteur_" + nombre_casiers))
                {

                }

                else
                {
                    items.Add("Hauteur_" + nombre_casiers, "32");
                    items.Add("Couleur_casier_" + nombre_casiers, "White");
                    items.Add("CouleurD_" + nombre_casiers, "White");
                    items.Add("CouleurG_" + nombre_casiers, "White");
                }

            }
            update_cabinets();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (nombre_casiers == 7)
            {
                items.Remove("Hauteur_" + nombre_casiers);
                items.Remove("Couleur_casier_" + nombre_casiers);
                items.Remove("CouleurD_" + nombre_casiers);
                items.Remove("CouleurG_" + nombre_casiers);

                panelShelf7.Visible = false;
                label12.Visible = false;
                nombre_casiers = 6;
            }

            else if (nombre_casiers == 6)
            {
                items.Remove("Hauteur_" + nombre_casiers);
                items.Remove("Couleur_casier_" + nombre_casiers);
                items.Remove("CouleurD_" + nombre_casiers);
                items.Remove("CouleurG_" + nombre_casiers);

                panelShelf6.Visible = false;
                label11.Visible = false;
                nombre_casiers = 5;
            }

            else if (nombre_casiers == 5)
            {
                items.Remove("Hauteur_" + nombre_casiers);
                items.Remove("Couleur_casier_" + nombre_casiers);
                items.Remove("CouleurD_" + nombre_casiers);
                items.Remove("CouleurG_" + nombre_casiers);

                panelShelf5.Visible = false;
                label10.Visible = false;
                nombre_casiers = 4;
            }

            else if (nombre_casiers == 4)
            {
                items.Remove("Hauteur_" + nombre_casiers);
                items.Remove("Couleur_casier_" + nombre_casiers);
                items.Remove("CouleurD_" + nombre_casiers);
                items.Remove("CouleurG_" + nombre_casiers);

                panelShelf4.Visible = false;
                label9.Visible = false;
                nombre_casiers = 3;
            }

            else if (nombre_casiers == 3)
            {
                items.Remove("Hauteur_" + nombre_casiers);
                items.Remove("Couleur_casier_" + nombre_casiers);
                items.Remove("CouleurD_" + nombre_casiers);
                items.Remove("CouleurG_" + nombre_casiers);

                nombre_casiers = 2;
                panelShelf3.Visible = false;
                label8.Visible = false;
            }

            else if (nombre_casiers == 2)
            {
                items.Remove("Hauteur_" + nombre_casiers);
                items.Remove("Couleur_casier_" + nombre_casiers);
                items.Remove("CouleurD_" + nombre_casiers);
                items.Remove("CouleurG_" + nombre_casiers);

                panelShelf2.Visible = false;
                label7.Visible = false;
                nombre_casiers = 1;
            }
        }

        private void update_cabinets()
        {
            if (button4__Click == true)
            {
                for (int i = 1; i <= nombre_casiers; i++)
                {
                    if (items.ContainsKey("Couleur_casier_" + i) && items.ContainsKey("CouleurG_" + i) && items.ContainsKey("CouleurD_" + i))
                    {
                        object O = Properties.Resources.ResourceManager.GetObject(items["Couleur_casier_" + i] + "_" + items["CouleurG_" + i] + "_"
                            + items["CouleurD_" + i] + "_1");

                        this.Controls.Find("panelShelf" + i, true)[0].BackgroundImage = (Image)O;
                    }

                    else
                    {
                        if (items.ContainsKey("Couleur_casier_" + i))
                        {
                            object O = Properties.Resources.ResourceManager.GetObject(items["Couleur_casier_" + i] + "_1");

                            this.Controls.Find("panelShelf" + i, true)[0].BackgroundImage = (Image)O;
                        }
                    }
                }

                if (items.ContainsKey("Couleur_casier_" + num_casier) && items.ContainsKey("CouleurG_" + num_casier) && items.ContainsKey("CouleurD_" + num_casier))
                {
                    object O = Properties.Resources.ResourceManager.GetObject(items["Couleur_casier_" + num_casier] + "_" + items["CouleurG_" + num_casier] + "_"
                        + items["CouleurD_" + num_casier]);

                    this.Controls.Find("panelShelf" + num_casier, true)[0].BackgroundImage = (Image)O;
                }

                else
                {
                    if (items.ContainsKey("Couleur_casier_" + num_casier) )
                    {
                        object O = Properties.Resources.ResourceManager.GetObject(items["Couleur_casier_" + num_casier]);

                        this.Controls.Find("panelShelf" + num_casier, true)[0].BackgroundImage = (Image)O;
                    }
                }

                if (items.ContainsKey("Hauteur_" + num_casier))
                {
                    comboBox1.Text = items["Hauteur_" + num_casier];
                }
                else
                {
                    comboBox1.Text = "32";
                }
            }

            else
            {
                for (int i = 1; i <= nombre_casiers; i++)
                {
                    if (items.ContainsKey("Couleur_casier_" + i) && items.ContainsKey("CouleurG_" + i) && items.ContainsKey("CouleurD_" + i))
                    {
                        object O = Properties.Resources.ResourceManager.GetObject(items["Couleur_casier_" + i] + "_" + items["CouleurG_" + i] + "_"
                            + items["CouleurD_" + i]);

                        this.Controls.Find("panelShelf" + i, true)[0].BackgroundImage = (Image)O;  
                    }

                    else
                    {
                        object O = Properties.Resources.ResourceManager.GetObject(items["Couleur_casier_" + i]);

                        this.Controls.Find("panelShelf" + i, true)[0].BackgroundImage = (Image)O;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Locker[] locker = new Locker[nombre_casiers];

            for (int x = 0; x < nombre_casiers; x++)
            {
                locker[x] = new Locker();
            }

            foreach (KeyValuePair<string, string> pair in items)
            {
                Console.WriteLine(pair.Key + "--------" + pair.Value);
            }
            foreach (string elem in items.Keys)
            {
                Console.WriteLine(elem);
            }
            

            cabinet.Setinfo(Convert.ToInt32(items["Profondeur"]), Convert.ToInt32(items["Profondeur"]));
            cabinet.Getsupport().Setcolor(items["Couleur_Cornières"]);

            string pastcolor = "";
        
            foreach (KeyValuePair<string, string> pair in items)
            {
                string[] elem = pair.Key.Split('_');

                if (elem[0] == "CouleurG" || elem[0] == "CouleurD")
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

                else if (elem[0] == "Hauteur")
                {
                    totalheight += Convert.ToInt32(pair.Value);
                    locker[Convert.ToInt32(elem[elem.Length - 1]) - 1].Setheight(Convert.ToInt32(pair.Value));
                }

                else if (elem.Length >= 3 && elem[1] == "casier")
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
                railAV.Setinfo("Avant", true);
                lockeur.Addproduct(railAV, 2);

                Rails railART = new Rails();
                railART.Setdepth(cabinet.Getwidth());
                railART.Setinfo("Arrière", true);
                lockeur.Addproduct(railART, 1);

                Rails railARF = new Rails();
                railARF.Setdepth(cabinet.Getwidth());
                railARF.Setinfo("Arrière", false);
                lockeur.Addproduct(railARF, 1);

                Rails railLATT = new Rails();
                railLATT.Setdepth(cabinet.Getwidth());
                railLATT.Setinfo("Latérale", true);
                lockeur.Addproduct(railLATT, 1);

                Rails railLATF = new Rails();
                railLATF.Setdepth(cabinet.Getwidth());
                railLATF.Setinfo("Latérale", false);
                lockeur.Addproduct(railLATF, 3);

                cabinet.AddLocker(lockeur);
            }

            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UIValidate());
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (items.ContainsKey("Couleur_Cornières"))
            {
                items["Couleur_Cornières"] = comboBox5.Text;
            }

            else
            {
                items.Add("Couleur_Cornières", comboBox5.Text);
            }
        }

        private void back_button_MouseEnter(object sender, EventArgs e)
        {
            back_button.Cursor = Cursors.Hand;
        }

        private void panelShelf6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
