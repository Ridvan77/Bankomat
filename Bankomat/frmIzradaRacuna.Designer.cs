namespace Bankomat
{
    partial class frmIzradaRacuna
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
            lblIzlaz = new Label();
            panel1 = new Panel();
            dtpDob = new DateTimePicker();
            cbPosao = new ComboBox();
            cbSpol = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtTelefon = new TextBox();
            label7 = new Label();
            txtAdresa = new TextBox();
            label6 = new Label();
            txtPrezime = new TextBox();
            label5 = new Label();
            txtIme = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtSifra = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblIzlaz
            // 
            lblIzlaz.AutoSize = true;
            lblIzlaz.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIzlaz.ForeColor = SystemColors.Control;
            lblIzlaz.Location = new Point(996, 5);
            lblIzlaz.Name = "lblIzlaz";
            lblIzlaz.Size = new Size(29, 33);
            lblIzlaz.TabIndex = 6;
            lblIzlaz.Text = "X";
            lblIzlaz.Click += lblIzlaz_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(dtpDob);
            panel1.Controls.Add(cbPosao);
            panel1.Controls.Add(cbSpol);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtTelefon);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtAdresa);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPrezime);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtIme);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtSifra);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 598);
            panel1.TabIndex = 5;
            // 
            // dtpDob
            // 
            dtpDob.CalendarFont = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDob.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(764, 277);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(224, 40);
            dtpDob.TabIndex = 24;
            // 
            // cbPosao
            // 
            cbPosao.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPosao.FormattingEnabled = true;
            cbPosao.Items.AddRange(new object[] { "Softverski inžinjer", "Arhitekta", "Bankar", "Turistički vodič", "Doktor", "Advokat" });
            cbPosao.Location = new Point(764, 203);
            cbPosao.Name = "cbPosao";
            cbPosao.Size = new Size(224, 41);
            cbPosao.TabIndex = 23;
            // 
            // cbSpol
            // 
            cbSpol.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSpol.FormattingEnabled = true;
            cbSpol.Items.AddRange(new object[] { "Muški", "Ženski" });
            cbSpol.Location = new Point(764, 127);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(224, 41);
            cbSpol.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(572, 277);
            label11.Name = "label11";
            label11.Size = new Size(71, 39);
            label11.TabIndex = 21;
            label11.Text = "Dob";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(572, 202);
            label10.Name = "label10";
            label10.Size = new Size(95, 39);
            label10.TabIndex = 20;
            label10.Text = "Posao";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(572, 126);
            label9.Name = "label9";
            label9.Size = new Size(73, 39);
            label9.TabIndex = 19;
            label9.Text = "Spol";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(764, 51);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 38);
            txtEmail.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(572, 50);
            label8.Name = "label8";
            label8.Size = new Size(98, 39);
            label8.TabIndex = 17;
            label8.Text = "E-mail";
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefon.Location = new Point(227, 277);
            txtTelefon.Multiline = true;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(224, 38);
            txtTelefon.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(34, 276);
            label7.Name = "label7";
            label7.Size = new Size(112, 39);
            label7.TabIndex = 15;
            label7.Text = "Telefon";
            // 
            // txtAdresa
            // 
            txtAdresa.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdresa.Location = new Point(227, 202);
            txtAdresa.Multiline = true;
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(224, 38);
            txtAdresa.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(34, 201);
            label6.Name = "label6";
            label6.Size = new Size(108, 39);
            label6.TabIndex = 13;
            label6.Text = "Adresa";
            // 
            // txtPrezime
            // 
            txtPrezime.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrezime.Location = new Point(227, 126);
            txtPrezime.Multiline = true;
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(224, 38);
            txtPrezime.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(34, 125);
            label5.Name = "label5";
            label5.Size = new Size(123, 39);
            label5.TabIndex = 11;
            label5.Text = "Prezime";
            // 
            // txtIme
            // 
            txtIme.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIme.Location = new Point(227, 50);
            txtIme.Multiline = true;
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(224, 38);
            txtIme.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(34, 49);
            label2.Name = "label2";
            label2.Size = new Size(67, 39);
            label2.TabIndex = 9;
            label2.Text = "Ime";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 24F);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(428, 533);
            button2.Name = "button2";
            button2.Size = new Size(262, 50);
            button2.TabIndex = 8;
            button2.Text = "Odustani";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 24F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(428, 459);
            button1.Name = "button1";
            button1.Size = new Size(262, 50);
            button1.TabIndex = 7;
            button1.Text = "Napravi račun";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtSifra
            // 
            txtSifra.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSifra.Location = new Point(227, 354);
            txtSifra.Multiline = true;
            txtSifra.Name = "txtSifra";
            txtSifra.PasswordChar = '*';
            txtSifra.Size = new Size(224, 38);
            txtSifra.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(34, 353);
            label4.Name = "label4";
            label4.Size = new Size(74, 39);
            label4.TabIndex = 4;
            label4.Text = "Šifra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(445, 5);
            label1.Name = "label1";
            label1.Size = new Size(195, 45);
            label1.TabIndex = 4;
            label1.Text = "BANKOMAT";
            // 
            // frmIzradaRacuna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1037, 663);
            Controls.Add(lblIzlaz);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIzradaRacuna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmIzradaRacuna";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIzlaz;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox txtSifra;
        private Label label4;
        private Label label1;
        private ComboBox cbSpol;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtTelefon;
        private Label label7;
        private TextBox txtAdresa;
        private Label label6;
        private TextBox txtPrezime;
        private Label label5;
        private TextBox txtIme;
        private Label label2;
        private DateTimePicker dtpDob;
        private ComboBox cbPosao;
    }
}