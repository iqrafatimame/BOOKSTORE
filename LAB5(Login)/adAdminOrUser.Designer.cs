namespace LAB5_Login_
{
    partial class adAdminOrUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userBtn = new System.Windows.Forms.Button();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.loginAs = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.userBtn);
            this.panel1.Controls.Add(this.AdminBtn);
            this.panel1.Controls.Add(this.loginAs);
            this.panel1.Location = new System.Drawing.Point(388, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 366);
            this.panel1.TabIndex = 0;
            // 
            // userBtn
            // 
            this.userBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userBtn.BackColor = System.Drawing.Color.Peru;
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.userBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userBtn.Font = new System.Drawing.Font("Constantia", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Location = new System.Drawing.Point(103, 191);
            this.userBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(365, 99);
            this.userBtn.TabIndex = 1;
            this.userBtn.Text = "user";
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            this.userBtn.MouseHover += new System.EventHandler(this.userBtn_MouseHover);
            // 
            // AdminBtn
            // 
            this.AdminBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminBtn.BackColor = System.Drawing.Color.Peru;
            this.AdminBtn.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.AdminBtn.FlatAppearance.BorderSize = 2;
            this.AdminBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.AdminBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.AdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminBtn.Font = new System.Drawing.Font("Constantia", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBtn.ForeColor = System.Drawing.Color.White;
            this.AdminBtn.Location = new System.Drawing.Point(103, 57);
            this.AdminBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(365, 104);
            this.AdminBtn.TabIndex = 1;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = false;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            this.AdminBtn.MouseHover += new System.EventHandler(this.userBtn_MouseHover);
            // 
            // loginAs
            // 
            this.loginAs.AutoSize = true;
            this.loginAs.Location = new System.Drawing.Point(162, -41);
            this.loginAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginAs.Name = "loginAs";
            this.loginAs.Size = new System.Drawing.Size(68, 13);
            this.loginAs.TabIndex = 0;
            this.loginAs.Text = "LOGIN AS";
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(1162, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 36);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Logout";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // adAdminOrUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB5_Login_.Properties.Resources.kenny_luo_lepXD1_21XM_unsplash__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 649);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "adAdminOrUser";
            this.Text = "adAdminOrUser";
            this.Load += new System.EventHandler(this.adAdminOrUser_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.Label loginAs;
        private System.Windows.Forms.Button closeBtn;
    }
}