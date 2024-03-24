namespace Bankomat
{
    partial class frmStanjeRacuna
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
            label5 = new Label();
            lblBrojRacuna = new Label();
            label4 = new Label();
            button2 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 45);
            label1.TabIndex = 8;
            label1.Text = "BANKOMAT";
            // 
            // lblIzlaz
            // 
            lblIzlaz.AutoSize = true;
            lblIzlaz.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIzlaz.ForeColor = SystemColors.Control;
            lblIzlaz.Location = new Point(489, 9);
            lblIzlaz.Name = "lblIzlaz";
            lblIzlaz.Size = new Size(29, 33);
            lblIzlaz.TabIndex = 9;
            lblIzlaz.Text = "X";
            lblIzlaz.Click += lblIzlaz_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(lblStanjeRacuna);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblBrojRacuna);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 301);
            panel1.TabIndex = 10;
            // 
            // lblStanjeRacuna
            // 
            lblStanjeRacuna.AutoSize = true;
            lblStanjeRacuna.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStanjeRacuna.ForeColor = Color.Teal;
            lblStanjeRacuna.Location = new Point(290, 160);
            lblStanjeRacuna.Name = "lblStanjeRacuna";
            lblStanjeRacuna.Size = new Size(0, 39);
            lblStanjeRacuna.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(50, 160);
            label5.Name = "label5";
            label5.Size = new Size(194, 39);
            label5.TabIndex = 15;
            label5.Text = "Stanje računa";
            // 
            // lblBrojRacuna
            // 
            lblBrojRacuna.AutoSize = true;
            lblBrojRacuna.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrojRacuna.ForeColor = Color.Teal;
            lblBrojRacuna.Location = new Point(290, 86);
            lblBrojRacuna.Name = "lblBrojRacuna";
            lblBrojRacuna.Size = new Size(0, 39);
            lblBrojRacuna.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(50, 86);
            label4.Name = "label4";
            label4.Size = new Size(164, 39);
            label4.TabIndex = 13;
            label4.Text = "Broj računa";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 24F);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(135, 238);
            button2.Name = "button2";
            button2.Size = new Size(262, 50);
            button2.TabIndex = 8;
            button2.Text = "Nazad";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(135, 1);
            label2.Name = "label2";
            label2.Size = new Size(265, 45);
            label2.TabIndex = 2;
            label2.Text = "STANJE RAČUNA";
            // 
            // frmStanjeRacuna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(530, 357);
            Controls.Add(panel1);
            Controls.Add(lblIzlaz);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStanjeRacuna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStanjeRacuna";
            Load += frmStanjeRacuna_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblIzlaz;
        private Panel panel1;
        private Button button2;
        private Label label2;
        private Label lblBrojRacuna;
        private Label label4;
        private Label lblStanjeRacuna;
        private Label label5;
    }
}