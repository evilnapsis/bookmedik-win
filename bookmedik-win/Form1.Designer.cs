namespace bookmedik_win
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utileriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areasMedicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeBookMedikWinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pacient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.medic = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_at = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.verToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(816, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.medicosToolStripMenuItem,
            this.utileriasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCitaToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // nuevaCitaToolStripMenuItem
            // 
            this.nuevaCitaToolStripMenuItem.Name = "nuevaCitaToolStripMenuItem";
            this.nuevaCitaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaCitaToolStripMenuItem.Text = "Nueva cita ...";
            this.nuevaCitaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCitaToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPacienteToolStripMenuItem,
            this.verToolStripMenuItem1});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // nuevoPacienteToolStripMenuItem
            // 
            this.nuevoPacienteToolStripMenuItem.Name = "nuevoPacienteToolStripMenuItem";
            this.nuevoPacienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoPacienteToolStripMenuItem.Text = "Nuevo ...";
            this.nuevoPacienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoPacienteToolStripMenuItem_Click);
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoMedicoToolStripMenuItem,
            this.verToolStripMenuItem2});
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.medicosToolStripMenuItem.Text = "Medicos";
            // 
            // nuevoMedicoToolStripMenuItem
            // 
            this.nuevoMedicoToolStripMenuItem.Name = "nuevoMedicoToolStripMenuItem";
            this.nuevoMedicoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoMedicoToolStripMenuItem.Text = "Nuevo ...";
            this.nuevoMedicoToolStripMenuItem.Click += new System.EventHandler(this.nuevoMedicoToolStripMenuItem_Click);
            // 
            // utileriasToolStripMenuItem
            // 
            this.utileriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areasMedicasToolStripMenuItem});
            this.utileriasToolStripMenuItem.Name = "utileriasToolStripMenuItem";
            this.utileriasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.utileriasToolStripMenuItem.Text = "Utilerias";
            // 
            // areasMedicasToolStripMenuItem
            // 
            this.areasMedicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.areasMedicasToolStripMenuItem.Name = "areasMedicasToolStripMenuItem";
            this.areasMedicasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.areasMedicasToolStripMenuItem.Text = "Areas medicas ";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verToolStripMenuItem.Text = "Ver ...";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarToolStripMenuItem.Text = "Agregar ...";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeBookMedikWinToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeBookMedikWinToolStripMenuItem
            // 
            this.acercaDeBookMedikWinToolStripMenuItem.Name = "acercaDeBookMedikWinToolStripMenuItem";
            this.acercaDeBookMedikWinToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.acercaDeBookMedikWinToolStripMenuItem.Text = "Acerca de BookMedik Win ...";
            this.acercaDeBookMedikWinToolStripMenuItem.Click += new System.EventHandler(this.acercaDeBookMedikWinToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(210, 17);
            this.toolStripStatusLabel1.Text = "BookMedik Win Powered By Evilnapsis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Palabra";
            // 
            // q
            // 
            this.q.Location = new System.Drawing.Point(58, 27);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(100, 20);
            this.q.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Paciente";
            // 
            // pacient
            // 
            this.pacient.FormattingEnabled = true;
            this.pacient.Location = new System.Drawing.Point(219, 27);
            this.pacient.Name = "pacient";
            this.pacient.Size = new System.Drawing.Size(104, 21);
            this.pacient.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Medico";
            // 
            // medic
            // 
            this.medic.FormattingEnabled = true;
            this.medic.Location = new System.Drawing.Point(377, 27);
            this.medic.Name = "medic";
            this.medic.Size = new System.Drawing.Size(106, 21);
            this.medic.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha";
            // 
            // date_at
            // 
            this.date_at.Location = new System.Drawing.Point(532, 24);
            this.date_at.Name = "date_at";
            this.date_at.Size = new System.Drawing.Size(200, 20);
            this.date_at.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 372);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // verToolStripMenuItem1
            // 
            this.verToolStripMenuItem1.Name = "verToolStripMenuItem1";
            this.verToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.verToolStripMenuItem1.Text = "Ver ...";
            this.verToolStripMenuItem1.Click += new System.EventHandler(this.verToolStripMenuItem1_Click);
            // 
            // verToolStripMenuItem2
            // 
            this.verToolStripMenuItem2.Name = "verToolStripMenuItem2";
            this.verToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.verToolStripMenuItem2.Text = "Ver ...";
            this.verToolStripMenuItem2.Click += new System.EventHandler(this.verToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_at);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.medic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pacient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.q);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Citas Medicas - BookMedik Win";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utileriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areasMedicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeBookMedikWinToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox q;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pacient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox medic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_at;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem2;
    }
}

