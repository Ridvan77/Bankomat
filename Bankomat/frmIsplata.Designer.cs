namespace Bankomat
{
    partial class frmIsplata
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
            panel1 = new Panel();
            lblStanjeRacuna = new Label();
            label4 = new Label();
            txtIsplata = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            lblIzlaz = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(lblStanjeRacuna);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtIsplata);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 373);
            panel1.TabIndex = 9;
            // 
            // lblStanjeRacuna
            // 
            lblStanjeRacuna.AutoSize = true;
            lblStanjeRacuna.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStanjeRacuna.ForeColor = Color.Teal;
            lblStanjeRacuna.Location = new Point(288, 82);
            lblStanjeRacuna.Name = "lblStanjeRacuna";
            lblStanjeRacuna.Size = new Size(194, 39);
            lblStanjeRacuna.TabIndex = 12;
            lblStanjeRacuna.Text = "Stanje računa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(48, 82);
            label4.Name = "label4";
            label4.Size = new Size(194, 39);
            label4.TabIndex = 11;
            label4.Text = "Stanje računa";
            // 
            // txtIsplata
            // 
            txtIsplata.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIsplata.Location = new Point(288, 155);
            txtIsplata.Multiline = true;
            txtIsplata.Name = "txtIsplata";
            txtIsplata.Size = new Size(213, 38);
            txtIsplata.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(48, 154);
            label3.Name = "label3";
            label3.Size = new Size(85, 39);
            label3.TabIndex = 9;
            label3.Text = "Iznos";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 24F);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(143, 309);
            button2.Name = "button2";
            button2.Size = new Size(262, 50);
            button2.TabIndex = 8;
            button2.Text = "Nazad";
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
            button1.Location = new Point(143, 239);
            button1.Name = "button1";
            button1.Size = new Size(262, 50);
            button1.TabIndex = 7;
            button1.Text = "Isplati";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(200, 2);
            label2.Name = "label2";
            label2.Size = new Size(135, 45);
            label2.TabIndex = 2;
            label2.Text = "ISPLATA";
            // 
            // lblIzlaz
            // 
            lblIzlaz.AutoSize = true;
            lblIzlaz.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIzlaz.ForeColor = SystemColors.Control;
            lblIzlaz.Location = new Point(502, 9);
            lblIzlaz.Name = "lblIzlaz";
            lblIzlaz.Size = new Size(29, 33);
            lblIzlaz.TabIndex = 8;
            lblIzlaz.Text = "X";
            lblIzlaz.Click += lblIzlaz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(178, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 45);
            label1.TabIndex = 7;
            label1.Text = "BANKOMAT";
            // 
            // frmIsplata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(543, 428);
            Controls.Add(panel1);
            Controls.Add(lblIzlaz);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIsplata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmIsplata";
            Load += frmIsplata_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtIsplata;
        private Label label3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label lblIzlaz;
        private Label label1;
        private Label lblStanjeRacuna;
        private Label label4;
    }
}