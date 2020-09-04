namespace LAB5_Login_
{
    partial class sigupOrLogin
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
            this.choiceLabel = new System.Windows.Forms.Label();
            this.signUpChoice = new System.Windows.Forms.Button();
            this.loginChoice = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.loginChoice);
            this.panel1.Controls.Add(this.signUpChoice);
            this.panel1.Controls.Add(this.choiceLabel);
            this.panel1.Location = new System.Drawing.Point(164, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 145);
            this.panel1.TabIndex = 0;
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceLabel.Location = new System.Drawing.Point(71, 24);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(108, 20);
            this.choiceLabel.TabIndex = 0;
            this.choiceLabel.Text = "Choose One";
            // 
            // signUpChoice
            // 
            this.signUpChoice.Location = new System.Drawing.Point(84, 66);
            this.signUpChoice.Name = "signUpChoice";
            this.signUpChoice.Size = new System.Drawing.Size(75, 23);
            this.signUpChoice.TabIndex = 1;
            this.signUpChoice.Text = "SIGNUP";
            this.signUpChoice.UseVisualStyleBackColor = true;
            this.signUpChoice.Click += new System.EventHandler(this.signUpChoice_Click);
            // 
            // loginChoice
            // 
            this.loginChoice.Location = new System.Drawing.Point(84, 95);
            this.loginChoice.Name = "loginChoice";
            this.loginChoice.Size = new System.Drawing.Size(75, 23);
            this.loginChoice.TabIndex = 1;
            this.loginChoice.Text = "LOGIN";
            this.loginChoice.UseVisualStyleBackColor = true;
            this.loginChoice.Click += new System.EventHandler(this.loginChoice_Click);
            // 
            // sigupOrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 336);
            this.Controls.Add(this.panel1);
            this.Name = "sigupOrLogin";
            this.Text = "sigupOrLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.Button loginChoice;
        private System.Windows.Forms.Button signUpChoice;
    }
}