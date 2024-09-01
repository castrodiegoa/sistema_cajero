namespace sistema_cajero
{
    partial class FormStep2SelectAmount
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnExit = new Button();
            btn50_000 = new Button();
            btn100_000 = new Button();
            btn200_000 = new Button();
            btn300_000 = new Button();
            btn400_000 = new Button();
            btn500_000 = new Button();
            btn600_000 = new Button();
            btnOther = new Button();
            label4 = new Label();
            txtOther = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            InactivityTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(254, 26);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 1;
            label2.Text = "¿Cuánto dinero desea retirar?";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(325, 49);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Paso 2";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(-1, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 23;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btn50_000
            // 
            btn50_000.Anchor = AnchorStyles.None;
            btn50_000.Location = new Point(100, 166);
            btn50_000.Name = "btn50_000";
            btn50_000.Size = new Size(200, 50);
            btn50_000.TabIndex = 24;
            btn50_000.Text = "$50,000";
            btn50_000.UseVisualStyleBackColor = true;
            btn50_000.Click += btn50000_Click;
            // 
            // btn100_000
            // 
            btn100_000.Anchor = AnchorStyles.None;
            btn100_000.Location = new Point(100, 235);
            btn100_000.Name = "btn100_000";
            btn100_000.Size = new Size(200, 50);
            btn100_000.TabIndex = 25;
            btn100_000.Text = "$100,000";
            btn100_000.UseVisualStyleBackColor = true;
            btn100_000.Click += btn100_000_Click;
            // 
            // btn200_000
            // 
            btn200_000.Anchor = AnchorStyles.None;
            btn200_000.Location = new Point(100, 300);
            btn200_000.Name = "btn200_000";
            btn200_000.Size = new Size(200, 50);
            btn200_000.TabIndex = 26;
            btn200_000.Text = "$200,000";
            btn200_000.UseVisualStyleBackColor = true;
            btn200_000.Click += btn200_000_Click;
            // 
            // btn300_000
            // 
            btn300_000.Anchor = AnchorStyles.None;
            btn300_000.Location = new Point(100, 369);
            btn300_000.Name = "btn300_000";
            btn300_000.Size = new Size(200, 50);
            btn300_000.TabIndex = 27;
            btn300_000.Text = "$300,000";
            btn300_000.UseVisualStyleBackColor = true;
            btn300_000.Click += btn300_000_Click;
            // 
            // btn400_000
            // 
            btn400_000.Anchor = AnchorStyles.None;
            btn400_000.Location = new Point(351, 166);
            btn400_000.Name = "btn400_000";
            btn400_000.Size = new Size(200, 50);
            btn400_000.TabIndex = 28;
            btn400_000.Text = "$400,000";
            btn400_000.UseVisualStyleBackColor = true;
            btn400_000.Click += btn400_000_Click;
            // 
            // btn500_000
            // 
            btn500_000.Anchor = AnchorStyles.None;
            btn500_000.Location = new Point(351, 235);
            btn500_000.Name = "btn500_000";
            btn500_000.Size = new Size(200, 50);
            btn500_000.TabIndex = 29;
            btn500_000.Text = "$500,000";
            btn500_000.UseVisualStyleBackColor = true;
            btn500_000.Click += btn500_000_Click;
            // 
            // btn600_000
            // 
            btn600_000.Anchor = AnchorStyles.None;
            btn600_000.Location = new Point(351, 300);
            btn600_000.Name = "btn600_000";
            btn600_000.Size = new Size(200, 50);
            btn600_000.TabIndex = 30;
            btn600_000.Text = "$600,000";
            btn600_000.UseVisualStyleBackColor = true;
            btn600_000.Click += btn600_000_Click;
            // 
            // btnOther
            // 
            btnOther.Anchor = AnchorStyles.None;
            btnOther.Location = new Point(497, 383);
            btnOther.Name = "btnOther";
            btnOther.Size = new Size(54, 24);
            btnOther.TabIndex = 31;
            btnOther.Text = "OK";
            btnOther.UseVisualStyleBackColor = true;
            btnOther.Click += btnOther_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(351, 387);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 32;
            label4.Text = "Otro:";
            // 
            // txtOther
            // 
            txtOther.Anchor = AnchorStyles.None;
            txtOther.Location = new Point(391, 384);
            txtOther.Name = "txtOther";
            txtOther.Size = new Size(100, 23);
            txtOther.TabIndex = 33;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(104, 76);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 34;
            label5.Text = "Nombre del usuario:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(104, 105);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 36;
            label7.Text = "Cantidad disponible:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(240, 76);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 37;
            label6.Text = "label6";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(240, 105);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 38;
            label8.Text = "label8";
            // 
            // InactivityTimer
            // 
            InactivityTimer.Interval = 30000;
            InactivityTimer.Tick += InactivityTimer_Tick;
            // 
            // FormStep2SelectAmount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 461);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtOther);
            Controls.Add(label4);
            Controls.Add(btnOther);
            Controls.Add(btn600_000);
            Controls.Add(btn500_000);
            Controls.Add(btn400_000);
            Controls.Add(btn300_000);
            Controls.Add(btn200_000);
            Controls.Add(btn100_000);
            Controls.Add(btn50_000);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormStep2SelectAmount";
            Text = "Form5";
            FormClosing += FormStep2SelectAmount_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnExit;
        private Button btn50_000;
        private Button btn100_000;
        private Button btn200_000;
        private Button btn300_000;
        private Button btn400_000;
        private Button btn500_000;
        private Button btn600_000;
        private Button btnOther;
        private Label label4;
        private TextBox txtOther;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private System.Windows.Forms.Timer InactivityTimer;
    }
}