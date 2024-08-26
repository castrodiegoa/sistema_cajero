namespace sistema_cajero
{
    partial class Form5
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
            btnOtro = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
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
            label2.Click += label2_Click;
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
            btn50_000.Location = new Point(99, 111);
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
            btn100_000.Location = new Point(99, 180);
            btn100_000.Name = "btn100_000";
            btn100_000.Size = new Size(200, 50);
            btn100_000.TabIndex = 25;
            btn100_000.Text = "$100,000";
            btn100_000.UseVisualStyleBackColor = true;
            // 
            // btn200_000
            // 
            btn200_000.Anchor = AnchorStyles.None;
            btn200_000.Location = new Point(99, 245);
            btn200_000.Name = "btn200_000";
            btn200_000.Size = new Size(200, 50);
            btn200_000.TabIndex = 26;
            btn200_000.Text = "$200,000";
            btn200_000.UseVisualStyleBackColor = true;
            // 
            // btn300_000
            // 
            btn300_000.Anchor = AnchorStyles.None;
            btn300_000.Location = new Point(99, 314);
            btn300_000.Name = "btn300_000";
            btn300_000.Size = new Size(200, 50);
            btn300_000.TabIndex = 27;
            btn300_000.Text = "$300,000";
            btn300_000.UseVisualStyleBackColor = true;
            // 
            // btn400_000
            // 
            btn400_000.Anchor = AnchorStyles.None;
            btn400_000.Location = new Point(350, 111);
            btn400_000.Name = "btn400_000";
            btn400_000.Size = new Size(200, 50);
            btn400_000.TabIndex = 28;
            btn400_000.Text = "$400,000";
            btn400_000.UseVisualStyleBackColor = true;
            // 
            // btn500_000
            // 
            btn500_000.Anchor = AnchorStyles.None;
            btn500_000.Location = new Point(350, 180);
            btn500_000.Name = "btn500_000";
            btn500_000.Size = new Size(200, 50);
            btn500_000.TabIndex = 29;
            btn500_000.Text = "$500,000";
            btn500_000.UseVisualStyleBackColor = true;
            // 
            // btn600_000
            // 
            btn600_000.Anchor = AnchorStyles.None;
            btn600_000.Location = new Point(350, 245);
            btn600_000.Name = "btn600_000";
            btn600_000.Size = new Size(200, 50);
            btn600_000.TabIndex = 30;
            btn600_000.Text = "$600,000";
            btn600_000.UseVisualStyleBackColor = true;
            // 
            // btnOtro
            // 
            btnOtro.Anchor = AnchorStyles.None;
            btnOtro.Location = new Point(496, 328);
            btnOtro.Name = "btnOtro";
            btnOtro.Size = new Size(54, 24);
            btnOtro.TabIndex = 31;
            btnOtro.Text = "OK";
            btnOtro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(350, 332);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 32;
            label4.Text = "Otro:";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(390, 329);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 33;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(90, 77);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 34;
            label5.Text = "Cantidad actual:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 461);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(btnOtro);
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
            Name = "Form5";
            Text = "Form5";
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
        private Button btnOtro;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
    }
}