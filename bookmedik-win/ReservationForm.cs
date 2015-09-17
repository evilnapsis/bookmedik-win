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
    public partial class ReservationForm : Form
    {
        public static int action;
        public static int id = 0;
        List<PacientObj> pas;
        List<MedicObj> mes;
        public ReservationForm()
        {
            InitializeComponent();
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

            if (action == 1)
            {
                btn_del.Enabled = false;
            }
            else if (action == 2)
            {
                label_title.Text = "Editar Cita";
                Text = "Editar Cita";
                btn_del.Enabled = true;
                ReservationObj p = ReservationObj.getById(id);
                if (p.id > 0)
                {
                    title.Text = p.title;
                    note.Text = p.note;
                    date_at.Text = p.date_at;
                    time_at.Text = p.time_at;
                    int n = 0;
                    foreach (MedicObj m in mes) { if (m.id == p.medic_id) { medic.SelectedIndex = n; break; } n++; }
                    n = 0;
                    foreach (PacientObj m in pas) { if (m.id == p.pacient_id) { pacient.SelectedIndex = n; break; } n++; }
                }
                else
                {
                    MessageBox.Show("No se encontro el paciente.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (title.Text != "" && pacient.SelectedIndex != -1 && medic.SelectedIndex != -1 && date_at.Text != "" && time_at.Text != "")
            {
                Connection c = new Connection();
                if (action == 1)
                {
                    c.execute("insert into reservation (title,pacient_id,medic_id,date_at,time_at,note,created_at) value (\"" + title.Text + "\",\"" + pas[pacient.SelectedIndex].id + "\",\"" + mes[medic.SelectedIndex].id + "\",\"" + date_at.Text + "\",\"" + time_at.Text + "\",\"" + note.Text + "\",NOW())");
                    title.Text = note.Text = date_at.Text = time_at.Text = "";
                    pacient.SelectedIndex = medic.SelectedIndex = -1;
                    MessageBox.Show("Cita Agregada Exitosamente!");
                }
                else if (action == 2 && id > 0) {
                    c.execute("update reservation set title=\"" + title.Text + "\",pacient_id=\"" + pas[pacient.SelectedIndex].id + "\",medic_id=\"" + mes[medic.SelectedIndex].id + "\",date_at=\"" + date_at.Text + "\",time_at=\"" + time_at.Text + "\",note=\"" + note.Text + "\" where id=" + id);
                    MessageBox.Show("Cita Actualizaa Exitosamente!");                
                }
            }
            else { MessageBox.Show("Campos Obligatorios: Asunto, Paciente, Medico, Fecha y Hora"); }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (action == 2 && id > 0)
            {
                DialogResult r = MessageBox.Show("Deseas Eliminar?.", "Estas seguro?", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    Connection c = new Connection();
                    c.execute("delete from reservation where id=" + id);
                    MessageBox.Show("Eliminado exitosamente!");
                    Dispose();
                }
            }
        }
    }
}
