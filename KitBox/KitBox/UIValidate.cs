using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using MySql.Data.MySqlClient;

namespace KitBox
{
    public partial class UIValidate : UserControl
    {
        #region Functions

        DatabaseManager dbm = new DatabaseManager();

        string solutionpath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));
        Cabinet cabinet = UI.Cabinet();
        Client client = UI.Client();

        Dictionary<string, int> component = new Dictionary<string, int>();
        int i = 1;

        public UIValidate()
        {
            InitializeComponent();
        }

        private void UIValidate_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += string.Format("{0}" + "\n", "Customer Summary:");
            label1.Text += string.Format("{0}, {1}" + "\n", "Support Angle", cabinet.Getsupport().Getcolor());
            label1.Text += string.Format("{0}, {1}" + "\n", "Height", cabinet.Getheight());
            label1.Text += string.Format("{0}, {1}" + "\n", "Width", cabinet.Getwidth());
            label1.Text += string.Format("{0}, {1}" + "\n", "Length", cabinet.Getdepth());

            foreach (Locker lockeur in cabinet.Getlocker())
            {
                label1.Text += string.Format("{0}, {1}" + "\n", "Cabinet", i);
                label1.Text += string.Format("{0}, {1}" + "\n", "Color", lockeur.Getcolor());

                foreach (KeyValuePair<Product, int> elem in lockeur.Getinfo())
                {
                    if (component.ContainsKey((elem.Key + " " + elem.Key.Getorientation()).ToString()))
                    {
                        component[(elem.Key + " " + elem.Key.Getorientation()).ToString()] += elem.Value;
                    }    
                    else
                    {
                        component.Add((elem.Key + " " + elem.Key.Getorientation()).ToString(), elem.Value);
                    }
                }

                if (lockeur.Getdoors().Count == 0)
                {
                    label1.Text += string.Format("{0}, {1}" + "\n", "Pas de Porte", "");
                }
                else
                {
                    label1.Text += string.Format("{0}, {1}" + "\n", "Left Door Color", lockeur.Getdoors()[0].Gettype());
                    label1.Text += string.Format("{0}, {1}" + "\n", "Right Door Color", lockeur.Getdoors()[1].Gettype());
                }

                i += 1;
            }

            label3.Text = "";

            label3.Text += string.Format("{0}, {1}" + "\n", "List of Components :", "");
            label3.Text += string.Format("{0}" + "\n", "4x Support Angle");

            foreach (Locker lockeur in cabinet.Getlocker())
            {
                if (lockeur.Getdoors().Count != 0)
                {
                    if (component.ContainsKey(lockeur.Getdoors()[0].Gettype() + " Doors"))
                    {
                        component[lockeur.Getdoors()[0].Gettype() + " Doors"] += 1;
                    }
                    else
                    {
                        component.Add(lockeur.Getdoors()[0].Gettype() + " Doors", 1);
                    }

                    if (component.ContainsKey(lockeur.Getdoors()[1].Gettype() + " Doors"))
                    {
                        component[lockeur.Getdoors()[1].Gettype() + " Doors"] += 1;
                    }
                    else
                    {
                        component.Add(lockeur.Getdoors()[1].Gettype() + " Doors", 1);
                    }
                }              
            }

            foreach (KeyValuePair<string, int> elem in component)
            {
                string[] name = elem.Key.Split('.');
                if (name.Length < 2)
                {
                    label3.Text += string.Format("{0} {1}" + "\n", elem.Value + "x", name[0]);
                }
                else
                {
                    label3.Text += string.Format("{0} {1}" + "\n", elem.Value + "x", name[1]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");

            Console.WriteLine("test" + client.Getname());

            try
            {
                string insertQuery = "INSERT INTO client(name, email, phonenum) VALUES('" + client.Getname() + "','" + client.Getemail() + "','" + client.Getphonenumber() + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {

                }
                else
                {
                    MessageBox.Show("Data Not Inserted.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch
            {
                MessageBox.Show("Please don't forget to import the database to PHPMYADMIN!.\n\nData Not Inserted.", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                int i = 1;
                DataTable dtbl = MakeDataTable("Order Sheet");
                string test = solutionpath + "\\KitBox\\bin\\Debug\\Bills\\bill_" + i + ".pdf";
                i += 1;

                ExportDataTableToPdf(dtbl, @test, "Order Sheet");
                if (checkBox1.Checked)
                {
                    System.Diagnostics.Process.Start(@test);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        string color_code_G = null;
        string color_code_D = null;
        string price = "";
        double total_price = 0;

        string code_Color_Cabinet = null;

        DataTable MakeDataTable(string type)
        {
            //Create bill table object
            DataTable bill = new DataTable();

            //Define columns
            bill.Columns.Add("Cabinet No");
            bill.Columns.Add("Product Id");
            bill.Columns.Add("Product");

            if (type != "Order Sheet")
            {
                bill.Columns.Add("Price (€)");
            }
            
            bill.Columns.Add("Quantity");

            if (type != "Order Sheet")
            {
                bill.Columns.Add("Total");
            }

            foreach (Locker lockeur in cabinet.Getlocker())
            {

                if (lockeur.Getdoors()[0].Gettype() == "White")
                    color_code_G = "BL";
                if (lockeur.Getdoors()[0].Gettype() == "Brown")
                    color_code_G = "BR";
                if (lockeur.Getdoors()[0].Gettype() == "Glass")
                    color_code_G = "VE";

                if (lockeur.Getdoors()[1].Gettype() == "White")
                    color_code_D = "BL";
                if (lockeur.Getdoors()[1].Gettype() == "Brown")
                    color_code_D = "BR";
                if (lockeur.Getdoors()[1].Gettype() == "Glass")
                    color_code_D = "VE";


                string code_Width_porte = null;

                if (cabinet.Getwidth() == 62)
                {
                    code_Width_porte = "32";
                }
                else
                {
                    code_Width_porte = (cabinet.Getwidth() / 2 + 2).ToString();
                }

                if (lockeur.Getcolor() == "White")
                    code_Color_Cabinet = "BL";
                else if (lockeur.Getcolor() == "Brown")
                    code_Color_Cabinet = "BR";

                //Add Left Door
                if (cabinet.Getwidth() != 32 && cabinet.Getwidth() != 42 && cabinet.Getwidth() != 52)
                {
                    MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = catalogue;");
                    connection.Open();
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT Prix_Client FROM porte WHERE Code=" + "'POR" + lockeur.Getheight() + code_Width_porte + color_code_G + "'", connection);
                    MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        price = myReader1.GetString(0);
                        price = Math.Round(Convert.ToDouble(price), 2).ToString("0.00").ToString();

                        total_price += Convert.ToDouble(price);
                        total_price = Convert.ToDouble(Math.Round(total_price, 2).ToString("0.00"));
                    }
                    connection.Close();

                    if (type != "Order Sheet")
                    {
                        bill.Rows.Add(i, "POR" + lockeur.Getheight() + code_Width_porte + color_code_G, "Porte Gauche", price, 1, price);
                    }
                    else
                    {
                        bill.Rows.Add(i, "POR" + lockeur.Getheight() + code_Width_porte + color_code_G, "Porte Gauche", 1);
                    }
                }

                //Add Right Door
                if (cabinet.Getwidth() != 32 && cabinet.Getwidth() != 42 && cabinet.Getwidth() != 52)
                {
                    MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = catalogue;");
                    connection.Open();
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT Prix_Client FROM porte WHERE Code=" + "'POR" + lockeur.Getheight() + code_Width_porte + color_code_D + "'", connection);
                    MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        price = myReader1.GetString(0);
                        price = Math.Round(Convert.ToDouble(price), 2).ToString("0.00").ToString();

                        total_price += Convert.ToDouble(price);
                        total_price = Convert.ToDouble(Math.Round(total_price, 2).ToString("0.00"));
                    }
                    connection.Close();
                    if (type != "Order Sheet")
                    {
                        bill.Rows.Add(i, "POR" + lockeur.Getheight() + code_Width_porte + color_code_D, "Porte Droite", price, 1, price);
                    }
                    else
                    {
                        bill.Rows.Add(i, "POR" + lockeur.Getheight() + code_Width_porte + color_code_D, "Porte Droite", 1);
                    }
                }

                //Add COUPEL
                if (color_code_G != "VE" && color_code_D != "VE")
                {
                    if (type != "Order Sheet")
                    {
                        bill.Rows.Add(i, "COUPEL", "Coupelles", "0,01", 2, 0.02 * 2);
                    }
                    else
                    {
                        bill.Rows.Add(i, "COUPEL", "Coupelles", 2);
                    }
                }

                else if (color_code_G != "VE" && color_code_D == "VE" || color_code_D != "VE" && color_code_G == "VE")
                {
                    if (type != "Order Sheet")
                    {
                        bill.Rows.Add(i, "COUPEL", "Coupelles", "0,01", 1, 0.01 * 1);
                    }
                    else
                    {
                        bill.Rows.Add(i, "COUPEL", "Coupelles", 1);
                    }
                }

                //Add Panneau AR

                if (true)
                {
                    MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = catalogue;");
                    connection.Open();
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT Prix_Client FROM panneau_ar WHERE Code=" + "'PAR" + lockeur.Getheight() + cabinet.Getwidth() + code_Color_Cabinet + "'", connection);
                    MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        price = myReader1.GetString(0);
                        price = Math.Round(Convert.ToDouble(price), 2).ToString("0.00").ToString();

                        total_price += Convert.ToDouble(price);
                        total_price = Convert.ToDouble(Math.Round(total_price, 2).ToString("0.00"));
                    }
                    connection.Close();

                    if (type != "Order Sheet")
                    {
                        bill.Rows.Add(i, "PAR" + lockeur.Getheight() + cabinet.Getwidth() + code_Color_Cabinet, "Panneau Ar", price, 1, price);
                    }
                    else
                    {
                        bill.Rows.Add(i, "PAR" + lockeur.Getheight() + cabinet.Getwidth() + code_Color_Cabinet, "Panneau Ar", 1);
                    }
                }

                //Add Panneau GD PAG
                if (true)
                {
                    MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = catalogue;");
                    connection.Open();
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT Prix_Client FROM panneau_gd WHERE Code=" + "'PAG" + lockeur.Getheight() + cabinet.Getwidth() + code_Color_Cabinet + "'", connection);
                    MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        price = myReader1.GetString(0);
                        price = Math.Round(Convert.ToDouble(price), 2).ToString("0.00").ToString();

                        total_price += Convert.ToDouble(price);
                        total_price = Convert.ToDouble(Math.Round(total_price, 2).ToString("0.00"));
                    }
                    connection.Close();

                    if (type != "Order Sheet")
                    {
                        bill.Rows.Add(i, "PAG" + lockeur.Getheight() + cabinet.Getwidth() + code_Color_Cabinet, "Panneau GD", price, 2, 2 * Convert.ToDouble(price));
                    }
                    else
                    {
                        bill.Rows.Add(i, "PAG" + lockeur.Getheight() + cabinet.Getwidth() + code_Color_Cabinet, "Panneau GD", 2);
                    }
                }
                
                

                //Add Panneau HB PAH
                if (true)
                {
                    MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = catalogue;");
                    connection.Open();
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT Prix_Client FROM panneau_hb WHERE Code=" + "'PAH" + lockeur.Getheight() + cabinet.Getwidth() + code_Color_Cabinet + "'", connection);
                    MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        price = myReader1.GetString(0);
                        price = Math.Round(Convert.ToDouble(price), 2).ToString("0.00").ToString();

                        total_price += Convert.ToDouble(price);
                        total_price = Convert.ToDouble(Math.Round(total_price, 2).ToString("0.00"));
                    }
                    connection.Close();

                    if (type != "Order Sheet")
                    {
                        bill.Rows.Add(i, "PAH" + lockeur.Getheight() + cabinet.Getwidth() + code_Color_Cabinet, "Panneau HB", price, 2, 2 * Convert.ToDouble(price));
                    }
                    else
                    {
                        bill.Rows.Add(i, "PAH" + lockeur.Getheight() + cabinet.Getwidth() + code_Color_Cabinet, "Panneau HB", 2);
                    }
                }

                //Add Tasseau TAS
                if (true)
                {
                    MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = catalogue;");
                    connection.Open();
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT Prix_Client FROM tasseau WHERE Code=" + "'TAS" + (lockeur.Getheight() - 5).ToString() + "'", connection);
                    MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        price = myReader1.GetString(0);
                        price = Math.Round(Convert.ToDouble(price), 2).ToString("0.00").ToString();

                        total_price += Convert.ToDouble(price);
                        total_price = Convert.ToDouble(Math.Round(total_price, 2).ToString("0.00"));
                    }
                    connection.Close();

                    if (type != "Order Sheet")
                    {
                        bill.Rows.Add(i, "TAS" + (lockeur.Getheight() - 5).ToString(), "Tasseau", price, 4, 4 * Convert.ToDouble(price));
                    }
                    else
                    {
                        bill.Rows.Add(i, "TAS" + (lockeur.Getheight() - 5).ToString(), "Tasseau", 4);
                    }
                }

                //Add Traverse GD TRG
                if (true)
                {
                    MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = catalogue;");
                    connection.Open();
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT Prix_Client FROM traverse_gd WHERE Code=" + "'TRG" + cabinet.Getdepth() + "'", connection);
                    MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        price = myReader1.GetString(0);
                        price = Math.Round(Convert.ToDouble(price), 2).ToString("0.00").ToString();

                        total_price += Convert.ToDouble(price);
                        total_price = Convert.ToDouble(Math.Round(total_price, 2).ToString("0.00"));
                    }
                    connection.Close();

                    if (type != "Order Sheet")
                    {
                        bill.Rows.Add(i, "TRG" + cabinet.Getdepth(), "Traverse GD", price, 4, 4 * Convert.ToDouble(price));
                    }
                    else
                    {
                        bill.Rows.Add(i, "TRG" + cabinet.Getdepth(), "Traverse GD", 4);
                    }
                }

                //Add Traverse AR TRR
                if (true)
                {
                    MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = catalogue;");
                    connection.Open();
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT Prix_Client FROM traverse_ar WHERE Code=" + "'TRR" + cabinet.Getwidth() + "'", connection);
                    MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        price = myReader1.GetString(0);
                        price = Math.Round(Convert.ToDouble(price), 2).ToString("0.00").ToString();

                        total_price += Convert.ToDouble(price);
                        total_price = Convert.ToDouble(Math.Round(total_price, 2).ToString("0.00"));
                    }
                    connection.Close();

                    if (type != "Order Sheet")
                    {
                        bill.Rows.Add(i, "TRR" + cabinet.Getwidth(), "Traverse AR", price, 2, 2 * Convert.ToDouble(price));
                    }
                    else
                    {
                        bill.Rows.Add(i, "TRR" + cabinet.Getwidth(), "Traverse AR", 2);
                    }
                }

                //Add Traverse AV TRF
                if (true)
                {
                    MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = catalogue;");
                    connection.Open();
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT Prix_Client FROM traverse_av WHERE Code=" + "'TRF" + cabinet.Getwidth() + "'", connection);
                    MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

                    while (myReader1.Read())
                    {
                        price = myReader1.GetString(0);
                        price = Math.Round(Convert.ToDouble(price), 2).ToString("0.00").ToString();

                        total_price += Convert.ToDouble(price);
                        total_price = Convert.ToDouble(Math.Round(total_price, 2).ToString("0.00"));
                    }
                    connection.Close();

                    if (type != "Order Sheet")
                    {
                        bill.Rows.Add(i, "TRF" + cabinet.Getwidth(), "Traverse AV", price, 2, 2 * Convert.ToDouble(price));
                    }
                    else
                    {
                        bill.Rows.Add(i, "TRF" + cabinet.Getwidth(), "Traverse AV", 2);
                    }


                        //MySqlConnection connection2 = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
                        //string insertQuery = "INSERT INTO orders(order_id, order_code, quantity) VALUES(NULL,'" + "TRF" + items["Width"] +"',"+ "'2'"+")";
                        //connection2.Open();
                        //MySqlCommand command = new MySqlCommand(insertQuery, connection2);

                        //if (command.ExecuteNonQuery() == 1)
                        //{

                        //}
                        //else
                        //{
                        //    MessageBox.Show("Data Not Inserted.", "Error",
                        //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                        //connection2.Close();
                }



                ////Add Cornières COR
                //if (items.ContainsKey("Height_" + i) && items.ContainsKey("Width") && items.ContainsKey("Color_Cabinet_" + i))
                //{
                //    MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = catalogue;");
                //    connection.Open();
                //    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT Prix_Client FROM cornières WHERE Code=" + "'COR" + items["Height_" + i] + items["Width"] + code_Color_Cabinet + "'", connection);
                //    MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

                //    while (myReader1.Read())
                //    {
                //        price = myReader1.GetString(0);
                //        total = Convert.ToDouble(namebre_Cabinets) * Convert.ToDouble(price);
                //        total_price += total;
                //    }
                //    connection.Close();

                //    bill.Rows.Add("COR" + items["Height_" + i] + items["Width"] + code_Color_Cabinet, "Panneau Ar", price, namebre_Cabinets, total);
                //}

                //break;
            }

            if (type != "Order Sheet")
            {
                bill.Rows.Add("", "", "", "Total:", total_price + " €");
            }

            return bill;
        }
        #endregion

        #region Events
        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, Color.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Time and Date
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Time: " + DateTime.Now.ToShortTimeString(), fntAuthor));
            prgAuthor.Add(new Chunk("\nDate: " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            Paragraph prgAuthor2 = new Paragraph();
            BaseFont btnAuthor2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor2 = new Font(btnAuthor, 8, 2, Color.GRAY);
            prgAuthor2.Alignment = Element.ALIGN_LEFT;
            prgAuthor2.Add(new Chunk("Order No: 1", fntAuthor2));
            prgAuthor2.Add(new Chunk("\nCompany Name: KitBox", fntAuthor2));
            document.Add(prgAuthor2);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = Color.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));

                if (strHeader != "Order Sheet")
                {
                    float[] widths = new float[] { 1.2f, 1.5f, 1.5f, 1f, 1f, 1f };
                    table.SetWidths(widths);
                }
                else
                {
                    float[] widths = new float[] { 1.2f, 1.5f, 1.5f, 1f};
                    table.SetWidths(widths);
                }

                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbxOpen_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cabinet.Empty();
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UINewOrder());
        }

        private void back_button_MouseEnter(object sender, EventArgs e)
        {
            back_button.Cursor = Cursors.Hand;
        }
    }
}