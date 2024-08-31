namespace GUI.GestionarNequi
{
    partial class FormStep2DashboardNequi
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
            label4 = new Label();
            btnAction = new Button();
            panelActionsNequiSubmenu = new Panel();
            btnRecharge = new Button();
            btnWithdraw = new Button();
            btnLogOut = new Button();
            panelActionsNequiSubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(189, 48);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Hola,";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(189, 75);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(251, 109);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 2;
            label3.Text = "Depósito Bajo Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(294, 134);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // btnAction
            // 
            btnAction.Location = new Point(383, 355);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(44, 39);
            btnAction.TabIndex = 4;
            btnAction.Text = "$";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // panelActionsNequiSubmenu
            // 
            panelActionsNequiSubmenu.Controls.Add(btnRecharge);
            panelActionsNequiSubmenu.Controls.Add(btnWithdraw);
            panelActionsNequiSubmenu.Location = new Point(294, 240);
            panelActionsNequiSubmenu.Name = "panelActionsNequiSubmenu";
            panelActionsNequiSubmenu.Size = new Size(133, 109);
            panelActionsNequiSubmenu.TabIndex = 5;
            // 
            // btnRecharge
            // 
            btnRecharge.Location = new Point(14, 57);
            btnRecharge.Name = "btnRecharge";
            btnRecharge.Size = new Size(106, 34);
            btnRecharge.TabIndex = 7;
            btnRecharge.Text = "Recarga Nequi";
            btnRecharge.UseVisualStyleBackColor = true;
            btnRecharge.Click += btnRecharge_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(14, 18);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(106, 33);
            btnWithdraw.TabIndex = 6;
            btnWithdraw.Text = "Saca";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(189, 355);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(44, 39);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Salir";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // FormStep2DashboardNequi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 461);
            Controls.Add(btnLogOut);
            Controls.Add(panelActionsNequiSubmenu);
            Controls.Add(btnAction);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormStep2DashboardNequi";
            Text = "FormLoginNequi";
            panelActionsNequiSubmenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAction;
        private Panel panelActionsNequiSubmenu;
        private Button btnRecharge;
        private Button btnWithdraw;
        private Button btnLogOut;
    }
}