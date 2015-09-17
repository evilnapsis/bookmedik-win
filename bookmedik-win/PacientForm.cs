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
    public partial class PacientForm : Form
    {
        public static int action;// 1.- nuevo, 2.- editar
        public static int id;
        public PacientForm()
        {
            InitializeComponent();
            if (action == 1)
            {
                btn_del.Enabled = false;
            }
            else if (action == 2)
            {
                btn_del.Enabled = true;
                PacientObj p = PacientObj.getById(id);
                if (p.id > 0)
                {
                    name.Text = p.name;
                    lastname.Text = p.lastname;
                    address.Text = p.address;
                    email.Text = p.email;
                    phone.Text = p.phone;
                }
                else
                {
                    MessageBox.Show("No se encontro el paciente.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && lastname.Text != "")
            {
                Connection c = new Connection();
                if (action == 1)
                {
                    c.execute("insert into pacient (name,lastname,address,email,phone) value (\"" + name.Text + "\",\"" + lastname.Text + "\",\"" + address.Text + "\",\"" + email.Text + "\",\"" + phone.Text + "\")");
                    name.Text = lastname.Text = address.Text = email.Text = phone.Text = "";
                    MessageBox.Show("Agregado exitosamente!");
                }
                else if (action == 2 && id>0) {
                    c.execute("update pacient set name=\"" + name.Text + "\",lastname=\"" + lastname.Text + "\",address=\"" + address.Text + "\",email=\"" + email.Text + "\",phone=\"" + phone.Text + "\" where id=" + id);
                    MessageBox.Show("Actualizado exitosamente!");                
                }
            }
            else
            {
                MessageBox.Show("Campos Obligatorios: Nombre, Apellidos");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (action == 2 && id>0)
            {
                DialogResult r = MessageBox.Show("Al eliminar un paciente se elimina tambien su historial de citas.", "Estas seguro?", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    Connection c = new Connection();
                    c.execute("delete from reservation where pacient_id=" + id);
                    c.execute("delete from pacient where id=" + id);
                    MessageBox.Show("Eliminado exitosamente!");
                    Dispose();
                }
            }
        }
    }
}
