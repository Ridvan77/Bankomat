namespace Bankomat
{
    partial class frmBankomat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pBPocetna = new ProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            lblProgressBar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(257, 22);
            label1.Name = "label1";
            label1.Size = new Size(195, 45);
            label1.TabIndex = 0;
            label1.Text = "BANKOMAT";
            // 
            // pBPocetna
            // 
            pBPocetna.BackColor = SystemColors.Control;
            pBPocetna.ForeColor = Color.Teal;
            pBPocetna.Location = new Point(12, 172);
            pBPocetna.Name = "pBPocetna";
            pBPocetna.Size = new Size(676, 23);
            pBPocetna.TabIndex = 1;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 25;
            timer.Tick += timer_Tick;
            // 
            // lblProgressBar
            // 
            lblProgressBar.AutoSize = true;
            lblProgressBar.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgressBar.ForeColor = SystemColors.Control;
            lblProgressBar.Location = new Point(318, 135);
            lblProgressBar.Name = "lblProgressBar";
            lblProgressBar.Size = new Size(0, 26);
            lblProgressBar.TabIndex = 2;
            // 
            // frmBankomat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(700, 207);
            ControlBox = false;
            Controls.Add(lblProgressBar);
            Controls.Add(pBPocetna);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBankomat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmBankomat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar pBPocetna;
        private System.Windows.Forms.Timer timer;
        private Label lblProgressBar;
    }
}
