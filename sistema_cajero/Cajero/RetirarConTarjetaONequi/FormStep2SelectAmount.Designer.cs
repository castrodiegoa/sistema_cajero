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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStep2SelectAmount));
            label2 = new Label();
            label3 = new Label();
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(219, 74);
            label2.Name = "label2";
            label2.Size = new Size(342, 33);
            label2.TabIndex = 1;
            label2.Text = "Selecciona el monto a tu transacción";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(369, 108);
            label3.Name = "label3";
            label3.Size = new Size(54, 24);
            label3.TabIndex = 2;
            label3.Text = "Paso 2";
            // 
            // btn50_000
            // 
            btn50_000.Anchor = AnchorStyles.None;
            btn50_000.Cursor = Cursors.Hand;
            btn50_000.FlatStyle = FlatStyle.Popup;
            btn50_000.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn50_000.ForeColor = Color.Black;
            btn50_000.Location = new Point(137, 168);
            btn50_000.Name = "btn50_000";
            btn50_000.Size = new Size(200, 50);
            btn50_000.TabIndex = 24;
            btn50_000.Text = "< $20.000";
            btn50_000.UseVisualStyleBackColor = true;
            btn50_000.Click += btn50000_Click;
            // 
            // btn100_000
            // 
            btn100_000.Anchor = AnchorStyles.None;
            btn100_000.Cursor = Cursors.Hand;
            btn100_000.FlatStyle = FlatStyle.Popup;
            btn100_000.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn100_000.ForeColor = Color.Black;
            btn100_000.Location = new Point(137, 237);
            btn100_000.Name = "btn100_000";
            btn100_000.Size = new Size(200, 50);
            btn100_000.TabIndex = 25;
            btn100_000.Text = "< $100.000";
            btn100_000.UseVisualStyleBackColor = true;
            btn100_000.Click += btn100_000_Click;
            // 
            // btn200_000
            // 
            btn200_000.Anchor = AnchorStyles.None;
            btn200_000.Cursor = Cursors.Hand;
            btn200_000.FlatStyle = FlatStyle.Popup;
            btn200_000.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn200_000.ForeColor = Color.Black;
            btn200_000.Location = new Point(137, 302);
            btn200_000.Name = "btn200_000";
            btn200_000.Size = new Size(200, 50);
            btn200_000.TabIndex = 26;
            btn200_000.Text = "< $300.000";
            btn200_000.UseVisualStyleBackColor = true;
            btn200_000.Click += btn200_000_Click;
            // 
            // btn300_000
            // 
            btn300_000.Anchor = AnchorStyles.None;
            btn300_000.Cursor = Cursors.Hand;
            btn300_000.FlatStyle = FlatStyle.Popup;
            btn300_000.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn300_000.ForeColor = Color.Black;
            btn300_000.Location = new Point(137, 371);
            btn300_000.Name = "btn300_000";
            btn300_000.Size = new Size(200, 50);
            btn300_000.TabIndex = 27;
            btn300_000.Text = "< $1.000.000";
            btn300_000.UseVisualStyleBackColor = true;
            btn300_000.Click += btn300_000_Click;
            // 
            // btn400_000
            // 
            btn400_000.Anchor = AnchorStyles.None;
            btn400_000.Cursor = Cursors.Hand;
            btn400_000.FlatStyle = FlatStyle.Popup;
            btn400_000.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn400_000.ForeColor = Color.Black;
            btn400_000.Location = new Point(388, 168);
            btn400_000.Name = "btn400_000";
            btn400_000.Size = new Size(200, 50);
            btn400_000.TabIndex = 28;
            btn400_000.Text = "$50.000 >";
            btn400_000.UseVisualStyleBackColor = true;
            btn400_000.Click += btn400_000_Click;
            // 
            // btn500_000
            // 
            btn500_000.Anchor = AnchorStyles.None;
            btn500_000.Cursor = Cursors.Hand;
            btn500_000.FlatStyle = FlatStyle.Popup;
            btn500_000.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn500_000.ForeColor = Color.Black;
            btn500_000.Location = new Point(388, 237);
            btn500_000.Name = "btn500_000";
            btn500_000.Size = new Size(200, 50);
            btn500_000.TabIndex = 29;
            btn500_000.Text = "$200.000 >";
            btn500_000.UseVisualStyleBackColor = true;
            btn500_000.Click += btn500_000_Click;
            // 
            // btn600_000
            // 
            btn600_000.Anchor = AnchorStyles.None;
            btn600_000.Cursor = Cursors.Hand;
            btn600_000.FlatStyle = FlatStyle.Popup;
            btn600_000.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn600_000.ForeColor = Color.Black;
            btn600_000.Location = new Point(388, 302);
            btn600_000.Name = "btn600_000";
            btn600_000.Size = new Size(200, 50);
            btn600_000.TabIndex = 30;
            btn600_000.Text = "$500.000 >";
            btn600_000.UseVisualStyleBackColor = true;
            btn600_000.Click += btn600_000_Click;
            // 
            // btnOther
            // 
            btnOther.Anchor = AnchorStyles.None;
            btnOther.FlatStyle = FlatStyle.Popup;
            btnOther.Font = new Font("Bahnschrift Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnOther.Location = new Point(534, 396);
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
            label4.Font = new Font("Bahnschrift Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(414, 371);
            label4.Name = "label4";
            label4.Size = new Size(147, 17);
            label4.TabIndex = 32;
            label4.Text = "Seleccionar un valor diferente";
            // 
            // txtOther
            // 
            txtOther.Anchor = AnchorStyles.None;
            txtOther.Location = new Point(388, 398);
            txtOther.Name = "txtOther";
            txtOther.Size = new Size(130, 23);
            txtOther.TabIndex = 33;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 121);
            label5.Name = "label5";
            label5.Size = new Size(93, 16);
            label5.TabIndex = 34;
            label5.Text = "Nombre del usuario:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(17, 168);
            label7.Name = "label7";
            label7.Size = new Size(92, 16);
            label7.TabIndex = 36;
            label7.Text = "Cantidad disponible:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(17, 137);
            label6.Name = "label6";
            label6.Size = new Size(42, 19);
            label6.TabIndex = 37;
            label6.Text = "label6";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(17, 184);
            label8.Name = "label8";
            label8.Size = new Size(43, 19);
            label8.TabIndex = 38;
            label8.Text = "label8";
            // 
            // InactivityTimer
            // 
            InactivityTimer.Interval = 30000;
            InactivityTimer.Tick += InactivityTimer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // FormStep2SelectAmount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 234, 239);
            ClientSize = new Size(684, 461);
            Controls.Add(pictureBox1);
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
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormStep2SelectAmount";
            Text = "Form5";
            FormClosing += FormStep2SelectAmount_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
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
        private PictureBox pictureBox1;
    }
}