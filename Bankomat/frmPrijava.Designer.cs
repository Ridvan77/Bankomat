namespace Bankomat
{
    partial class frmPrijava
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            txtSifra = new TextBox();
            txtBrojRacuna = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblIzlaz = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(218, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 45);
            label1.TabIndex = 1;
            label1.Text = "BANKOMAT";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtSifra);
            panel1.Controls.Add(txtBrojRacuna);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 393);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 24F);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(340, 294);
            button2.Name = "button2";
            button2.Size = new Size(262, 50);
            button2.TabIndex = 8;
            button2.Text = "Napravi račun";
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
            button1.Location = new Point(340, 220);
            button1.Name = "button1";
            button1.Size = new Size(262, 50);
            button1.TabIndex = 7;
            button1.Text = "Prijava";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtSifra
            // 
            txtSifra.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSifra.Location = new Point(340, 156);
            txtSifra.Multiline = true;
            txtSifra.Name = "txtSifra";
            txtSifra.PasswordChar = '*';
            txtSifra.Size = new Size(262, 38);
            txtSifra.TabIndex = 6;
            // 
            // txtBrojRacuna
            // 
            txtBrojRacuna.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrojRacuna.Location = new Point(340, 90);
            txtBrojRacuna.Multiline = true;
            txtBrojRacuna.Name = "txtBrojRacuna";
            txtBrojRacuna.Size = new Size(262, 38);
            txtBrojRacuna.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(41, 155);
            label4.Name = "label4";
            label4.Size = new Size(74, 39);
            label4.TabIndex = 4;
            label4.Text = "Šifra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(41, 89);
            label3.Name = "label3";
            label3.Size = new Size(164, 39);
            label3.TabIndex = 3;
            label3.Text = "Broj računa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(241, 1);
            label2.Name = "label2";
            label2.Size = new Size(138, 45);
            label2.TabIndex = 2;
            label2.Text = "PRIJAVA";
            // 
            // lblIzlaz
            // 
            lblIzlaz.AutoSize = true;
            lblIzlaz.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIzlaz.ForeColor = SystemColors.Control;
            lblIzlaz.Location = new Point(604, 9);
            lblIzlaz.Name = "lblIzlaz";
            lblIzlaz.Size = new Size(29, 33);
            lblIzlaz.TabIndex = 3;
            lblIzlaz.Text = "X";
            lblIzlaz.Click += lblIzlaz_Click;
            // 
            // frmPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(645, 450);
            Controls.Add(lblIzlaz);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrijava";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrijava";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private TextBox txtSifra;
        private TextBox txtBrojRacuna;
        private Label label4;
        private Label label3;
        private Button button2;
        private Label lblIzlaz;
    }
}