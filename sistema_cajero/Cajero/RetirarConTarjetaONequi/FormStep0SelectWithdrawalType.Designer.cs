namespace GUI.Cajero.RetirarConTarjetaONequi
{
    partial class FormStep0SelectWithdrawalType
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
            radioBtnDebitCard = new RadioButton();
            radioBtnNequiAccount = new RadioButton();
            btnContinue = new Button();
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            InactivityTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // radioBtnDebitCard
            // 
            radioBtnDebitCard.AutoSize = true;
            radioBtnDebitCard.ForeColor = Color.Gainsboro;
            radioBtnDebitCard.Location = new Point(185, 203);
            radioBtnDebitCard.Name = "radioBtnDebitCard";
            radioBtnDebitCard.Size = new Size(97, 19);
            radioBtnDebitCard.TabIndex = 0;
            radioBtnDebitCard.TabStop = true;
            radioBtnDebitCard.Text = "Tarjeta Débito";
            radioBtnDebitCard.UseVisualStyleBackColor = true;
            // 
            // radioBtnNequiAccount
            // 
            radioBtnNequiAccount.AutoSize = true;
            radioBtnNequiAccount.ForeColor = Color.Gainsboro;
            radioBtnNequiAccount.Location = new Point(185, 240);
            radioBtnNequiAccount.Name = "radioBtnNequiAccount";
            radioBtnNequiAccount.Size = new Size(114, 19);
            radioBtnNequiAccount.TabIndex = 1;
            radioBtnNequiAccount.TabStop = true;
            radioBtnNequiAccount.Text = "Cuenta de Nequi";
            radioBtnNequiAccount.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(298, 294);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(75, 23);
            btnContinue.TabIndex = 2;
            btnContinue.Text = "Continuar";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(266, 70);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccione el tipo de retiro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(318, 103);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Paso 0";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(-1, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 41;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // InactivityTimer
            // 
            InactivityTimer.Interval = 30000;
            InactivityTimer.Tick += InactivityTimer_Tick_1;
            // 
            // FormStep0SelectWithdrawalType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 461);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnContinue);
            Controls.Add(radioBtnNequiAccount);
            Controls.Add(radioBtnDebitCard);
            Name = "FormStep0SelectWithdrawalType";
            Text = "FormStep0SelectWithdrawalType";
            FormClosing += FormStep0SelectWithdrawalType_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioBtnDebitCard;
        private RadioButton radioBtnNequiAccount;
        private Button btnContinue;
        private Label label1;
        private Label label2;
        private Button btnExit;
        private System.Windows.Forms.Timer InactivityTimer;
    }
}