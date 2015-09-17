using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace bookmedik_win
{
    class ReservationObj
    {
        public int id;
        public String title;
        public int pacient_id;
        public int medic_id;
        public String time_at;
        public String date_at;
        public String note;



        public static ReservationObj getById(int product_id)
        {
            Connection c = new Connection();
            MySqlCommand cmd = c.con.CreateCommand();
            cmd.CommandText = "select * from reservation where id=" + product_id;
            c.con.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            ReservationObj product = new ReservationObj();
            while (r.Read())
            {

                product.id = r.GetInt32("id");
                product.date_at = r.GetString("date_at");
                product.time_at = r.GetString("time_at");
                product.note = r.GetString("note");
                product.title = r.GetString("title");
                product.pacient_id = r.GetInt32("pacient_id");
                product.medic_id = r.GetInt32("medic_id");
                break;
            }
            return product;
        }


        public static List<ReservationObj> getAll()
        {
            List<ReservationObj> list = new List<ReservationObj>();
            Connection c = new Connection();
            MySqlCommand cmd = c.con.CreateCommand();
            cmd.CommandText = "select * from reservation";
            c.con.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                ReservationObj product = new ReservationObj();
                product.id = r.GetInt32("id");
                product.date_at = r.GetString("date_at");
                product.time_at = r.GetString("time_at");
                product.note = r.GetString("note");
                product.title = r.GetString("title");
                product.pacient_id = r.GetInt32("pacient_id");
                product.medic_id = r.GetInt32("medic_id");

                list.Add(product);
            }
            return list;
        }
        public static List<ReservationObj> getBySQL(String sql)
        {
            List<ReservationObj> list = new List<ReservationObj>();
            Connection c = new Connection();
            MySqlCommand cmd = c.con.CreateCommand();
            cmd.CommandText = sql;
            c.con.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                ReservationObj product = new ReservationObj();
                product.id = r.GetInt32("id");
                product.date_at = r.GetString("date_at");
                product.time_at = r.GetString("time_at");
                product.note = r.GetString("note");
                product.title = r.GetString("title");
                product.pacient_id = r.GetInt32("pacient_id");
                product.medic_id = r.GetInt32("medic_id");

                list.Add(product);
            }
            return list;
        }
    }
}
