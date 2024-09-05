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
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 234, 239);
            label1.Location = new Point(189, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 22);
            label1.TabIndex = 0;
            label1.Text = "Hola,";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(231, 234, 239);
            label2.Location = new Point(189, 57);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(231, 234, 239);
            label3.Location = new Point(280, 122);
            label3.Name = "label3";
            label3.Size = new Size(132, 22);
            label3.TabIndex = 2;
            label3.Text = "Depósito Bajo Monto";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(231, 234, 239);
            label4.Location = new Point(279, 149);
            label4.Name = "label4";
            label4.Size = new Size(72, 33);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // btnAction
            // 
            btnAction.Anchor = AnchorStyles.None;
            btnAction.BackColor = Color.FromArgb(219, 0, 130);
            btnAction.FlatStyle = FlatStyle.Popup;
            btnAction.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAction.ForeColor = Color.FromArgb(231, 234, 239);
            btnAction.Location = new Point(449, 355);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(44, 39);
            btnAction.TabIndex = 4;
            btnAction.Text = "$";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            // 
            // panelActionsNequiSubmenu
            // 
            panelActionsNequiSubmenu.Anchor = AnchorStyles.None;
            panelActionsNequiSubmenu.Controls.Add(btnRecharge);
            panelActionsNequiSubmenu.Controls.Add(btnWithdraw);
            panelActionsNequiSubmenu.Location = new Point(360, 240);
            panelActionsNequiSubmenu.Name = "panelActionsNequiSubmenu";
            panelActionsNequiSubmenu.Size = new Size(133, 109);
            panelActionsNequiSubmenu.TabIndex = 5;
            // 
            // btnRecharge
            // 
            btnRecharge.Anchor = AnchorStyles.Bottom;
            btnRecharge.BackColor = Color.FromArgb(219, 0, 130);
            btnRecharge.FlatStyle = FlatStyle.Popup;
            btnRecharge.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecharge.ForeColor = Color.FromArgb(231, 234, 239);
            btnRecharge.Location = new Point(14, 57);
            btnRecharge.Name = "btnRecharge";
            btnRecharge.Size = new Size(106, 34);
            btnRecharge.TabIndex = 7;
            btnRecharge.Text = "Recarga Nequi";
            btnRecharge.UseVisualStyleBackColor = false;
            btnRecharge.Click += btnRecharge_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Anchor = AnchorStyles.Bottom;
            btnWithdraw.BackColor = Color.FromArgb(219, 0, 130);
            btnWithdraw.FlatStyle = FlatStyle.Popup;
            btnWithdraw.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnWithdraw.ForeColor = Color.FromArgb(231, 234, 239);
            btnWithdraw.Location = new Point(14, 18);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(106, 33);
            btnWithdraw.TabIndex = 6;
            btnWithdraw.Text = "Saca";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.None;
            btnLogOut.BackColor = Color.FromArgb(219, 0, 130);
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.FromArgb(231, 234, 239);
            btnLogOut.Location = new Point(189, 355);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(44, 39);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Salir";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // FormStep2DashboardNequi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 0, 26);
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