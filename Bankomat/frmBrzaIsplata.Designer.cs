namespace Bankomat
{
    partial class frmBrzaIsplata
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
            panel1 = new Panel();
            lblStanjeRacuna = new Label();
            label3 = new Label();
            button6 = new Button();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(lblStanjeRacuna);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 510);
            panel1.TabIndex = 6;
            // 
            // lblStanjeRacuna
            // 
            lblStanjeRacuna.AutoSize = true;
            lblStanjeRacuna.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStanjeRacuna.ForeColor = Color.Teal;
            lblStanjeRacuna.Location = new Point(514, 80);
            lblStanjeRacuna.Name = "lblStanjeRacuna";
            lblStanjeRacuna.Size = new Size(0, 45);
            lblStanjeRacuna.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(228, 80);
            label3.Name = "label3";
            label3.Size = new Size(223, 45);
            label3.TabIndex = 13;
            label3.Text = "Stanje računa";
            // 
            // button6
            // 
            button6.BackColor = Color.Teal;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Calibri", 24F);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(511, 315);
            button6.Name = "button6";
            button6.Size = new Size(262, 50);
            button6.TabIndex = 12;
            button6.Text = "200 KM";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Calibri", 24F);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(511, 212);
            button7.Name = "button7";
            button7.Size = new Size(262, 50);
            button7.TabIndex = 11;
            button7.Text = "100 KM";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 24F);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(27, 364);
            button4.Name = "button4";
            button4.Size = new Size(262, 50);
            button4.TabIndex = 10;
            button4.Text = "50 KM";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 24F);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(27, 263);
            button3.Name = "button3";
            button3.Size = new Size(262, 50);
            button3.TabIndex = 9;
            button3.Text = "20 KM";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 24F);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(271, 431);
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
            button1.Location = new Point(27, 160);
            button1.Name = "button1";
            button1.Size = new Size(262, 50);
            button1.TabIndex = 7;
            button1.Text = "10 KM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(290, 2);
            label2.Name = "label2";
            label2.Size = new Size(221, 45);
            label2.TabIndex = 2;
            label2.Text = "BRZA ISPLATA";
            // 
            // frmBrzaIsplata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 565);
            Controls.Add(panel1);
            Controls.Add(lblIzlaz);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBrzaIsplata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBrzaIsplata";
            Load += frmBrzaIsplata_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblIzlaz;
        private Panel panel1;
        private Button button6;
        private Button button7;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label lblStanjeRacuna;
        private Label label3;
    }
}