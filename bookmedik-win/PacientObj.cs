using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace bookmedik_win
{
    class PacientObj
    {
        public int id = 0;
        public String name;
        public String lastname;
        public String address;
        public String phone;
        public String email;


        public static PacientObj getById(int product_id)
        {
            Connection c = new Connection();
            MySqlCommand cmd = c.con.CreateCommand();
            cmd.CommandText = "select * from pacient where id=" + product_id;
            c.con.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            PacientObj product = new PacientObj();
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


        public static List<PacientObj> getAll()
        {
            List<PacientObj> list = new List<PacientObj>();
                Connection c = new Connection();
                MySqlCommand cmd = c.con.CreateCommand();
                cmd.CommandText = "select * from pacient";
                c.con.Open();
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    PacientObj product = new PacientObj();
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
