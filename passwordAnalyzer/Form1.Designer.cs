namespace passwordAnalyzer
{
    partial class Fmr_app
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
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_level = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_password.Location = new System.Drawing.Point(12, 28);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(254, 25);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Your password security level:";
            this.lbl_password.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_password.Location = new System.Drawing.Point(12, 75);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(475, 33);
            this.txt_password.TabIndex = 1;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_level.ForeColor = System.Drawing.Color.Red;
            this.lbl_level.Location = new System.Drawing.Point(272, 28);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(58, 25);
            this.lbl_level.TabIndex = 2;
            this.lbl_level.Text = "Weak";
            // 
            // Fmr_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 120);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Name = "Fmr_app";
            this.Text = "Password Strength Evaluation ";
            this.Load += new System.EventHandler(this.fmr_app_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_password;
        private TextBox txt_password;
        private Label lbl_level;
    }
}