﻿namespace GUI.GestionarNequi.IniciarSesion
{
    partial class FormStep3RechargeNequiAccount
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(249, 86);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 50;
            label1.Text = "Recharge Nequi Form";
            // 
            // FormStep3RechargeNequiAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 461);
            Controls.Add(label1);
            Name = "FormStep3RechargeNequiAccount";
            Text = "FormStep3RechargeNequiAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}