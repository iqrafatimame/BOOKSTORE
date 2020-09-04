namespace LAB5_Login_
{
    partial class AddPicture
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
            this.addBtn = new System.Windows.Forms.Button();
            this.bookImgBox = new System.Windows.Forms.PictureBox();
            this.addPic = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.bookImgBox);
            this.panel1.Controls.Add(this.addPic);
            this.panel1.Location = new System.Drawing.Point(195, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 350);
            this.panel1.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(47, 289);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(289, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add Details";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // bookImgBox
            // 
            this.bookImgBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bookImgBox.Location = new System.Drawing.Point(190, 72);
            this.bookImgBox.Name = "bookImgBox";
            this.bookImgBox.Size = new System.Drawing.Size(146, 172);
            this.bookImgBox.TabIndex = 1;
            this.bookImgBox.TabStop = false;
            this.bookImgBox.Click += new System.EventHandler(this.pictureBox1_Click);
            this.bookImgBox.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // addPic
            // 
            this.addPic.AutoSize = true;
            this.addPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPic.Location = new System.Drawing.Point(44, 142);
            this.addPic.Name = "addPic";
            this.addPic.Size = new System.Drawing.Size(105, 13);
            this.addPic.TabIndex = 0;
            this.addPic.Text = "Choose A Picture";
            this.addPic.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddPicture";
            this.Text = "AddPicture";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.PictureBox bookImgBox;
        private System.Windows.Forms.Label addPic;
    }
}