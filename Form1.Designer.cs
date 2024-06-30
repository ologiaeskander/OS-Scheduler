namespace Project
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
            this.ATm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ATsd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTm = new System.Windows.Forms.TextBox();
            this.BTsd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FCFS = new System.Windows.Forms.RadioButton();
            this.npHPF = new System.Windows.Forms.RadioButton();
            this.SRJF = new System.Windows.Forms.RadioButton();
            this.RR = new System.Windows.Forms.RadioButton();
            this.pHPF = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ATAT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AWT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ATm
            // 
            this.ATm.Location = new System.Drawing.Point(33, 44);
            this.ATm.Name = "ATm";
            this.ATm.Size = new System.Drawing.Size(161, 23);
            this.ATm.TabIndex = 1;
            this.ATm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mean :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Standard deviation :";
            // 
            // ATsd
            // 
            this.ATsd.Location = new System.Drawing.Point(33, 93);
            this.ATsd.Name = "ATsd";
            this.ATsd.Size = new System.Drawing.Size(161, 23);
            this.ATsd.TabIndex = 12;
            this.ATsd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ATm);
            this.groupBox1.Controls.Add(this.ATsd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 133);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arrival Time :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTm);
            this.groupBox2.Controls.Add(this.BTsd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(247, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 133);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Burst Time :";
            // 
            // BTm
            // 
            this.BTm.Location = new System.Drawing.Point(33, 43);
            this.BTm.Name = "BTm";
            this.BTm.Size = new System.Drawing.Size(161, 23);
            this.BTm.TabIndex = 1;
            // 
            // BTsd
            // 
            this.BTsd.Location = new System.Drawing.Point(33, 92);
            this.BTsd.Name = "BTsd";
            this.BTsd.Size = new System.Drawing.Size(161, 23);
            this.BTsd.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mean :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Standard deviation :";
            // 
            // LoP
            // 
            this.LoP.Location = new System.Drawing.Point(491, 104);
            this.LoP.Name = "LoP";
            this.LoP.Size = new System.Drawing.Size(161, 23);
            this.LoP.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lambda of Priority :";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(491, 54);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(161, 23);
            this.num.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Number of Processes :";
            // 
            // FCFS
            // 
            this.FCFS.Appearance = System.Windows.Forms.Appearance.Button;
            this.FCFS.Location = new System.Drawing.Point(43, 33);
            this.FCFS.Name = "FCFS";
            this.FCFS.Size = new System.Drawing.Size(143, 24);
            this.FCFS.TabIndex = 17;
            this.FCFS.TabStop = true;
            this.FCFS.Text = "FCFS";
            this.FCFS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FCFS.UseVisualStyleBackColor = true;
            // 
            // npHPF
            // 
            this.npHPF.Appearance = System.Windows.Forms.Appearance.Button;
            this.npHPF.Location = new System.Drawing.Point(490, 33);
            this.npHPF.Name = "npHPF";
            this.npHPF.Size = new System.Drawing.Size(143, 24);
            this.npHPF.TabIndex = 18;
            this.npHPF.TabStop = true;
            this.npHPF.Text = "npHPF";
            this.npHPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.npHPF.UseVisualStyleBackColor = true;
            // 
            // SRJF
            // 
            this.SRJF.Appearance = System.Windows.Forms.Appearance.Button;
            this.SRJF.Location = new System.Drawing.Point(192, 33);
            this.SRJF.Name = "SRJF";
            this.SRJF.Size = new System.Drawing.Size(143, 24);
            this.SRJF.TabIndex = 19;
            this.SRJF.TabStop = true;
            this.SRJF.Text = "SRJF";
            this.SRJF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SRJF.UseVisualStyleBackColor = true;
            // 
            // RR
            // 
            this.RR.Appearance = System.Windows.Forms.Appearance.Button;
            this.RR.Location = new System.Drawing.Point(341, 33);
            this.RR.Name = "RR";
            this.RR.Size = new System.Drawing.Size(143, 24);
            this.RR.TabIndex = 20;
            this.RR.TabStop = true;
            this.RR.Text = "RR";
            this.RR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RR.UseVisualStyleBackColor = true;
            // 
            // pHPF
            // 
            this.pHPF.Appearance = System.Windows.Forms.Appearance.Button;
            this.pHPF.Location = new System.Drawing.Point(639, 33);
            this.pHPF.Name = "pHPF";
            this.pHPF.Size = new System.Drawing.Size(143, 24);
            this.pHPF.TabIndex = 21;
            this.pHPF.TabStop = true;
            this.pHPF.Text = "pHPF";
            this.pHPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pHPF.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pHPF);
            this.groupBox3.Controls.Add(this.FCFS);
            this.groupBox3.Controls.Add(this.RR);
            this.groupBox3.Controls.Add(this.npHPF);
            this.groupBox3.Controls.Add(this.SRJF);
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(854, 84);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Algorithm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 240);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 303);
            this.textBox1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(752, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ATAT
            // 
            this.ATAT.Location = new System.Drawing.Point(486, 262);
            this.ATAT.Name = "ATAT";
            this.ATAT.Size = new System.Drawing.Size(161, 23);
            this.ATAT.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "ATAT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "AWT";
            // 
            // AWT
            // 
            this.AWT.Location = new System.Drawing.Point(486, 337);
            this.AWT.Name = "AWT";
            this.AWT.Size = new System.Drawing.Size(161, 23);
            this.AWT.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 555);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AWT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ATAT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ATm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ATsd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox BTm;
        private System.Windows.Forms.TextBox BTsd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton FCFS;
        private System.Windows.Forms.RadioButton npHPF;
        private System.Windows.Forms.RadioButton SRJF;
        private System.Windows.Forms.RadioButton RR;
        private System.Windows.Forms.RadioButton pHPF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ATAT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AWT;
    }
}

