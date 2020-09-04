namespace LAB5_Login_
{
    partial class signup
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.erroEmail = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.cnPassBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.signIn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 445);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.erroEmail);
            this.panel2.Controls.Add(this.signUpButton);
            this.panel2.Controls.Add(this.mailBox);
            this.panel2.Controls.Add(this.cnPassBox);
            this.panel2.Controls.Add(this.passBox);
            this.panel2.Controls.Add(this.userBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Password);
            this.panel2.Controls.Add(this.user);
            this.panel2.Controls.Add(this.signIn);
            this.panel2.Location = new System.Drawing.Point(200, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 263);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // erroEmail
            // 
            this.erroEmail.AutoSize = true;
            this.erroEmail.Location = new System.Drawing.Point(176, 221);
            this.erroEmail.Name = "erroEmail";
            this.erroEmail.Size = new System.Drawing.Size(0, 13);
            this.erroEmail.TabIndex = 9;
            // 
            // signUpButton
            // 
            this.signUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signUpButton.Location = new System.Drawing.Point(317, 221);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 8;
            this.signUpButton.Text = "SignUp";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mailBox
            // 
            this.mailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailBox.ForeColor = System.Drawing.Color.Silver;
            this.mailBox.Location = new System.Drawing.Point(159, 180);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(233, 20);
            this.mailBox.TabIndex = 7;
            this.mailBox.Text = "somebody@gmail.com";
            this.mailBox.Enter += new System.EventHandler(this.mailBox_Enter);
            this.mailBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mailBox_KeyDown);
            this.mailBox.Leave += new System.EventHandler(this.mailBox_Leave);
            // 
            // cnPassBox
            // 
            this.cnPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cnPassBox.ForeColor = System.Drawing.Color.Silver;
            this.cnPassBox.Location = new System.Drawing.Point(159, 148);
            this.cnPassBox.Name = "cnPassBox";
            this.cnPassBox.PasswordChar = '*';
            this.cnPassBox.Size = new System.Drawing.Size(233, 20);
            this.cnPassBox.TabIndex = 7;
            this.cnPassBox.Text = "enter a password";
            this.cnPassBox.Enter += new System.EventHandler(this.cnPassBox_Enter);
            this.cnPassBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cnPassBox_KeyDown);
            this.cnPassBox.Leave += new System.EventHandler(this.cnPassBox_Leave);
            // 
            // passBox
            // 
            this.passBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passBox.ForeColor = System.Drawing.Color.Silver;
            this.passBox.Location = new System.Drawing.Point(159, 117);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(233, 20);
            this.passBox.TabIndex = 7;
            this.passBox.Text = "choose a password";
            this.passBox.Enter += new System.EventHandler(this.passBox_Enter);
            this.passBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passBox_KeyDown);
            this.passBox.Leave += new System.EventHandler(this.passBox_Leave);
            // 
            // userBox
            // 
            this.userBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userBox.ForeColor = System.Drawing.Color.Silver;
            this.userBox.Location = new System.Drawing.Point(159, 87);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(233, 20);
            this.userBox.TabIndex = 7;
            this.userBox.Text = "Enter a user name";
            this.userBox.Enter += new System.EventHandler(this.userBox_Enter);
            this.userBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userBox_KeyDown);
            this.userBox.Leave += new System.EventHandler(this.userBox_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email_Address";
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(30, 116);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(61, 15);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(30, 87);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(65, 15);
            this.user.TabIndex = 3;
            this.user.Text = "Username";
            // 
            // signIn
            // 
            this.signIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signIn.AutoSize = true;
            this.signIn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signIn.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.Location = new System.Drawing.Point(136, 29);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(173, 36);
            this.signIn.TabIndex = 0;
            this.signIn.Text = "SignUp Form";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.panel1);
            this.Name = "signup";
            this.Text = "signup";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label signIn;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.TextBox cnPassBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label erroEmail;
    }
}