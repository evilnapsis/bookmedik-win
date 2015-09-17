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
    public partial class PacientWindow : Form
    {
        public static DataGridView data;
        public PacientWindow()
        {
            InitializeComponent();
            data = dataGridView1;
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns.Add("Direccion", "Direccion");
            dataGridView1.Columns.Add("Telefono", "Telefono");
            dataGridView1.Columns[0].Width = 50;
            load();
        }

        public static void load()
        {
            data.Rows.Clear();
            foreach (PacientObj p in PacientObj.getAll())
            {
                data.Rows.Add(p.id, p.name, p.lastname, p.address, p.phone);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() != "") {
                PacientForm.action = 2;
                PacientForm.id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                PacientForm p = new PacientForm();
                p.ShowDialog();
                load();
            }
        }
    }
}
