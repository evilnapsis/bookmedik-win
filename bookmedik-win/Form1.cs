using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bookmedik_win
{
    public partial class Form1 : Form
    {
        List<PacientObj> pas;
        List<MedicObj> mes;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Id","Id");
            dataGridView1.Columns.Add("Asunto", "Asunto");
            dataGridView1.Columns.Add("Paciente", "Paciente");
            dataGridView1.Columns.Add("Medico", "Medico");
            dataGridView1.Columns.Add("Fecha", "Fecha");
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;

            pas = PacientObj.getAll();
            mes = MedicObj.getAll();
            foreach (MedicObj m in mes)
            {
                medic.Items.Add(m.name + " " + m.lastname);
            }
            foreach (PacientObj p in pas)
            {
                pacient.Items.Add(p.name + " " + p.lastname);
            }

        }

        void fill(List<ReservationObj> res)
        {
            dataGridView1.Rows.Clear();
            foreach (ReservationObj r in res)
            {
                MedicObj m = MedicObj.getById(r.medic_id);
                PacientObj p = PacientObj.getById(r.pacient_id);
                dataGridView1.Rows.Add(r.id, r.title, p.name + " " + p.lastname, m.name + " " + m.name, r.date_at + "/" + r.time_at);
            }

        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientForm.action = 1;
            PacientForm pf = new PacientForm();
            pf.ShowDialog();
        }

        private void nuevoMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicForm.action = 1;
            MedicForm mf = new MedicForm();
            mf.ShowDialog();
        }

        private void nuevaCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationForm.action = 1;
            ReservationForm rf = new ReservationForm();
            rf.ShowDialog();
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PacientWindow pw = new PacientWindow();
            pw.ShowDialog();
        }

        private void verToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MedicWindow mw = new MedicWindow();
            mw.ShowDialog();
        }

        private void acercaDeBookMedikWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = " select * from reservation ";
            if (q.Text != "")
            {
                sql += "where title like '%" + q.Text + "%' ";
            }
            if (pacient.SelectedIndex != -1)
            {
                if (q.Text == "") { sql += " where "; } else { sql += " and "; }
                sql += " pacient_id = " + pas[pacient.SelectedIndex].id;
            }
            if (medic.SelectedIndex != -1)
            {
                if (q.Text == "" && pacient.SelectedIndex==-1) { sql += " where "; } else { sql += " and "; }
                sql += " medic_id = " + mes[medic.SelectedIndex].id;
            }
            if (q.Text == "" && pacient.SelectedIndex == -1 && medic.SelectedIndex == -1) { sql += " where "; } else { sql += " and "; }
            sql += " date_at=\"" + date_at.Value.ToString("yyyy-MM-dd") + "\"";

            fill(ReservationObj.getBySQL(sql));
        
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
            {
                ReservationForm.action = 2;
                ReservationForm.id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                ReservationForm p = new ReservationForm();
                p.ShowDialog();
            }
        }
    }
}
