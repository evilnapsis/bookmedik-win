using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace bookmedik_win
{
    class MedicObj
    {
        public int id;
        public String name;
        public String lastname;
        public String address;
        public String phone;
        public String email;


        public static MedicObj getById(int product_id)
        {
            Connection c = new Connection();
            MySqlCommand cmd = c.con.CreateCommand();
            cmd.CommandText = "select * from medic where id=" + product_id;
            c.con.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            MedicObj product = new MedicObj();
            while (r.Read())
            {

                product.id = r.GetInt32("id");
                product.name = r.GetString("name");
                product.lastname = r.GetString("lastname");
                product.address = r.GetString("address");
                product.phone = r.GetString("phone");

                product.email = r.GetString("email");
                break;
            }
            return product;
        }


        public static List<MedicObj> getAll()
        {
            List<MedicObj> list = new List<MedicObj>();
            Connection c = new Connection();
            MySqlCommand cmd = c.con.CreateCommand();
            cmd.CommandText = "select * from medic";
            c.con.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                MedicObj product = new MedicObj();
                product.id = r.GetInt32("id");
                product.name = r.GetString("name");
                product.lastname = r.GetString("lastname");
                product.address = r.GetString("address");
                product.phone = r.GetString("phone");

                product.email = r.GetString("email");
                list.Add(product);
            }
            return list;
        }


    }
}
