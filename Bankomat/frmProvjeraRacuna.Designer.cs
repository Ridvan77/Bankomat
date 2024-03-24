namespace Bankomat
{
    partial class frmProvjeraRacuna
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
            label1 = new Label();
            lblIzlaz = new Label();
            button2 = new Button();
            dgvTransakcije = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            BrojRacuna = new DataGridViewTextBoxColumn();
            Tip = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTransakcije).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 45);
            label1.TabIndex = 3;
            label1.Text = "BANKOMAT";
            // 
            // lblIzlaz
            // 
            lblIzlaz.AutoSize = true;
            lblIzlaz.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIzlaz.ForeColor = SystemColors.Control;
            lblIzlaz.Location = new Point(759, 9);
            lblIzlaz.Name = "lblIzlaz";
            lblIzlaz.Size = new Size(29, 33);
            lblIzlaz.TabIndex = 5;
            lblIzlaz.Text = "X";
            lblIzlaz.Click += lblIzlaz_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 24F);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(269, 438);
            button2.Name = "button2";
            button2.Size = new Size(262, 50);
            button2.TabIndex = 9;
            button2.Text = "Nazad";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dgvTransakcije
            // 
            dgvTransakcije.AllowUserToAddRows = false;
            dgvTransakcije.AllowUserToDeleteRows = false;
            dgvTransakcije.BackgroundColor = SystemColors.Control;
            dgvTransakcije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransakcije.Columns.AddRange(new DataGridViewColumn[] { Id, BrojRacuna, Tip, Iznos, Datum });
            dgvTransakcije.Location = new Point(0, 68);
            dgvTransakcije.Name = "dgvTransakcije";
            dgvTransakcije.ReadOnly = true;
            dgvTransakcije.Size = new Size(800, 350);
            dgvTransakcije.TabIndex = 10;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // BrojRacuna
            // 
            BrojRacuna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojRacuna.DataPropertyName = "BrojRacuna";
            BrojRacuna.HeaderText = "Broj racuna";
            BrojRacuna.Name = "BrojRacuna";
            BrojRacuna.ReadOnly = true;
            // 
            // Tip
            // 
            Tip.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tip.DataPropertyName = "Tip";
            Tip.HeaderText = "Tip";
            Tip.Name = "Tip";
            Tip.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Iznos";
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // frmProvjeraRacuna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 500);
            Controls.Add(dgvTransakcije);
            Controls.Add(button2);
            Controls.Add(lblIzlaz);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProvjeraRacuna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProvjeraRacuna";
            Load += frmProvjeraRacuna_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransakcije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblIzlaz;
        private Button button2;
        private DataGridView dgvTransakcije;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BrojRacuna;
        private DataGridViewTextBoxColumn Tip;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Datum;
    }
}