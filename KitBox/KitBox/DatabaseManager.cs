using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KitBox
{
    class DatabaseManager
    {
        MySqlConnection catalogue_connection = new MySqlConnection("server = localhost; uid = root; database = catalogue;");
        List<string> list = new List<string>();

        public List<string> list2 = new List<string>();


        public void select_width()
        {
            catalogue_connection.Open();
            MySqlCommand sqlCmd1 = new MySqlCommand("SELECT largeur FROM panneau_ar", catalogue_connection);
            MySqlDataReader myReader1 = sqlCmd1.ExecuteReader();

            while (myReader1.Read())
            {
                if (!list.Contains(myReader1.GetString(0)))
                {
                    list2.Add(myReader1.GetString(0));
                }

                list.Add(myReader1.GetString(0));
            }
            catalogue_connection.Close();
        }

        public void select_depth()
        {
            list.Clear();
            list2.Clear();

            catalogue_connection.Open();
            MySqlCommand sqlCmd2 = new MySqlCommand("SELECT profondeur FROM panneau_gd", catalogue_connection);
            MySqlDataReader myReader2 = sqlCmd2.ExecuteReader();

            while (myReader2.Read())
            {
                if (!list.Contains(myReader2.GetString(0)))
                {
                    list2.Add(myReader2.GetString(0));
                }

                list.Add(myReader2.GetString(0));
            }
            catalogue_connection.Close();
        }

        public void select_suport_angles_color()
        {
            list.Clear();
            list2.Clear();

            catalogue_connection.Open();
            MySqlCommand sqlCmd2 = new MySqlCommand("SELECT couleur FROM cornières", catalogue_connection);
            MySqlDataReader myReader2 = sqlCmd2.ExecuteReader();

            while (myReader2.Read())
            {
                if (!list.Contains(myReader2.GetString(0)))
                {
                    list2.Add(myReader2.GetString(0));
                }

                list.Add(myReader2.GetString(0));
            }
            catalogue_connection.Close();
        }

        public void select_heights()
        {
            list.Clear();
            list2.Clear();

            catalogue_connection.Open();
            MySqlCommand sqlCmd2 = new MySqlCommand("SELECT hauteur FROM tasseau", catalogue_connection);
            MySqlDataReader myReader2 = sqlCmd2.ExecuteReader();

            while (myReader2.Read())
            {
                if (!list.Contains(myReader2.GetString(0)))
                {
                    list2.Add(myReader2.GetString(0));
                }

                list.Add(myReader2.GetString(0));
            }
            catalogue_connection.Close();
        }

    }
}
