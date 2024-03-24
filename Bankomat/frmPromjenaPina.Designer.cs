namespace Bankomat
{
    partial class frmPromjenaPina
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
            txtPotvrdaPina = new TextBox();
            label5 = new Label();
            lblStariPin = new Label();
            label4 = new Label();
            txtNoviPin = new TextBox();
            label3 = new Label();
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
            label1.Location = new Point(195, 9);
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
            lblIzlaz.Location = new Point(559, 9);
            lblIzlaz.Name = "lblIzlaz";
            lblIzlaz.Size = new Size(29, 33);
            lblIzlaz.TabIndex = 5;
            lblIzlaz.Text = "X";
            lblIzlaz.Click += lblIzlaz_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(txtPotvrdaPina);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblStariPin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNoviPin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 413);
            panel1.TabIndex = 6;
            // 
            // txtPotvrdaPina
            // 
            txtPotvrdaPina.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPotvrdaPina.Location = new Point(311, 214);
            txtPotvrdaPina.Multiline = true;
            txtPotvrdaPina.Name = "txtPotvrdaPina";
            txtPotvrdaPina.Size = new Size(213, 38);
            txtPotvrdaPina.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(71, 213);
            label5.Name = "label5";
            label5.Size = new Size(181, 39);
            label5.TabIndex = 17;
            label5.Text = "Potvrda pina";
            // 
            // lblStariPin
            // 
            lblStariPin.AutoSize = true;
            lblStariPin.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStariPin.ForeColor = Color.Teal;
            lblStariPin.Location = new Point(311, 77);
            lblStariPin.Name = "lblStariPin";
            lblStariPin.Size = new Size(0, 39);
            lblStariPin.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(71, 77);
            label4.Name = "label4";
            label4.Size = new Size(124, 39);
            label4.TabIndex = 15;
            label4.Text = "Stari pin";
            // 
            // txtNoviPin
            // 
            txtNoviPin.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoviPin.Location = new Point(311, 150);
            txtNoviPin.Multiline = true;
            txtNoviPin.Name = "txtNoviPin";
            txtNoviPin.Size = new Size(213, 38);
            txtNoviPin.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(71, 149);
            label3.Name = "label3";
            label3.Size = new Size(124, 39);
            label3.TabIndex = 13;
            label3.Text = "Novi pin";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 24F);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(163, 350);
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
            button1.Location = new Point(163, 294);
            button1.Name = "button1";
            button1.Size = new Size(262, 50);
            button1.TabIndex = 7;
            button1.Text = "Promijeni pin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(160, 1);
            label2.Name = "label2";
            label2.Size = new Size(272, 45);
            label2.TabIndex = 2;
            label2.Text = "PROMJENA PINA";
            // 
            // frmPromjenaPina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(600, 475);
            Controls.Add(panel1);
            Controls.Add(lblIzlaz);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPromjenaPina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPromjenaPina";
            Load += frmPromjenaPina_Load;
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
        private Button button1;
        private Label label2;
        private Label lblStariPin;
        private Label label4;
        private TextBox txtNoviPin;
        private Label label3;
        private TextBox txtPotvrdaPina;
        private Label label5;
    }
}