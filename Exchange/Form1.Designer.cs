namespace Exchange
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            SPLN = new RadioButton();
            STHB = new RadioButton();
            SRUB = new RadioButton();
            SEUR = new RadioButton();
            SUSD = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            amountNumeric = new NumericUpDown();
            groupBox2 = new GroupBox();
            TPLN = new RadioButton();
            TTHB = new RadioButton();
            TEUR = new RadioButton();
            TRUB = new RadioButton();
            TUSD = new RadioButton();
            groupBox3 = new GroupBox();
            ResultLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountNumeric).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SPLN);
            groupBox1.Controls.Add(STHB);
            groupBox1.Controls.Add(SRUB);
            groupBox1.Controls.Add(SEUR);
            groupBox1.Controls.Add(SUSD);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(120, 156);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Waluta:";
            // 
            // SPLN
            // 
            SPLN.AutoSize = true;
            SPLN.Checked = true;
            SPLN.Location = new Point(6, 22);
            SPLN.Name = "SPLN";
            SPLN.Size = new Size(47, 19);
            SPLN.TabIndex = 4;
            SPLN.TabStop = true;
            SPLN.Text = "PLN";
            SPLN.UseVisualStyleBackColor = true;
            // 
            // STHB
            // 
            STHB.AutoSize = true;
            STHB.Location = new Point(6, 122);
            STHB.Name = "STHB";
            STHB.Size = new Size(95, 19);
            STHB.TabIndex = 3;
            STHB.Text = "bat tajlandzki";
            STHB.UseVisualStyleBackColor = true;
            // 
            // SRUB
            // 
            SRUB.AutoSize = true;
            SRUB.Location = new Point(6, 97);
            SRUB.Name = "SRUB";
            SRUB.Size = new Size(47, 19);
            SRUB.TabIndex = 2;
            SRUB.Text = "RUB";
            SRUB.UseVisualStyleBackColor = true;
            // 
            // SEUR
            // 
            SEUR.AutoSize = true;
            SEUR.Location = new Point(6, 72);
            SEUR.Name = "SEUR";
            SEUR.Size = new Size(46, 19);
            SEUR.TabIndex = 1;
            SEUR.Text = "EUR";
            SEUR.UseVisualStyleBackColor = true;
            // 
            // SUSD
            // 
            SUSD.AutoSize = true;
            SUSD.Location = new Point(6, 47);
            SUSD.Name = "SUSD";
            SUSD.Size = new Size(47, 19);
            SUSD.TabIndex = 0;
            SUSD.Text = "USD";
            SUSD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Kwota";
            // 
            // button1
            // 
            button1.Location = new Point(268, 9);
            button1.Name = "button1";
            button1.Size = new Size(322, 203);
            button1.TabIndex = 5;
            button1.Text = "Przelicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Calculate;
            // 
            // amountNumeric
            // 
            amountNumeric.Location = new Point(12, 27);
            amountNumeric.Name = "amountNumeric";
            amountNumeric.Size = new Size(250, 23);
            amountNumeric.TabIndex = 6;
            amountNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TPLN);
            groupBox2.Controls.Add(TTHB);
            groupBox2.Controls.Add(TEUR);
            groupBox2.Controls.Add(TRUB);
            groupBox2.Controls.Add(TUSD);
            groupBox2.Location = new Point(138, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(124, 156);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Waluta docelowa:";
            // 
            // TPLN
            // 
            TPLN.AutoSize = true;
            TPLN.Checked = true;
            TPLN.Location = new Point(6, 22);
            TPLN.Name = "TPLN";
            TPLN.Size = new Size(47, 19);
            TPLN.TabIndex = 5;
            TPLN.TabStop = true;
            TPLN.Text = "PLN";
            TPLN.UseVisualStyleBackColor = true;
            // 
            // TTHB
            // 
            TTHB.AutoSize = true;
            TTHB.Location = new Point(6, 122);
            TTHB.Name = "TTHB";
            TTHB.Size = new Size(95, 19);
            TTHB.TabIndex = 7;
            TTHB.Text = "bat tajlandzki";
            TTHB.UseVisualStyleBackColor = true;
            // 
            // TEUR
            // 
            TEUR.AutoSize = true;
            TEUR.Location = new Point(6, 72);
            TEUR.Name = "TEUR";
            TEUR.Size = new Size(46, 19);
            TEUR.TabIndex = 5;
            TEUR.Text = "EUR";
            TEUR.UseVisualStyleBackColor = true;
            // 
            // TRUB
            // 
            TRUB.AutoSize = true;
            TRUB.Location = new Point(6, 97);
            TRUB.Name = "TRUB";
            TRUB.Size = new Size(47, 19);
            TRUB.TabIndex = 6;
            TRUB.Text = "RUB";
            TRUB.UseVisualStyleBackColor = true;
            // 
            // TUSD
            // 
            TUSD.AutoSize = true;
            TUSD.Location = new Point(6, 47);
            TUSD.Name = "TUSD";
            TUSD.Size = new Size(47, 19);
            TUSD.TabIndex = 4;
            TUSD.Text = "USD";
            TUSD.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ResultLabel);
            groupBox3.Location = new Point(596, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(230, 200);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Wynik";
            // 
            // ResultLabel
            // 
            ResultLabel.Dock = DockStyle.Fill;
            ResultLabel.Location = new Point(3, 19);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(224, 178);
            ResultLabel.TabIndex = 0;
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 220);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(amountNumeric);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountNumeric).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton STHB;
        private RadioButton SRUB;
        private RadioButton SEUR;
        private RadioButton SUSD;
        private Label label1;
        private Button button1;
        private NumericUpDown amountNumeric;
        private GroupBox groupBox2;
        private RadioButton TTHB;
        private RadioButton TEUR;
        private RadioButton TRUB;
        private RadioButton TUSD;
        private RadioButton SPLN;
        private RadioButton TPLN;
        private GroupBox groupBox3;
        private Label ResultLabel;
    }
}
