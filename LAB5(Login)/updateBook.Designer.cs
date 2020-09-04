namespace LAB5_Login_
{
    partial class updateBook
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
            this.srchBox = new System.Windows.Forms.TextBox();
            this.srchBtn = new System.Windows.Forms.Button();
            this.bookTitle = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.bookSKU = new System.Windows.Forms.Label();
            this.skuBox = new System.Windows.Forms.TextBox();
            this.autherName = new System.Windows.Forms.Label();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.bookPrice = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.availability = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.desBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.catBox = new System.Windows.Forms.ComboBox();
            this.availBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // srchBox
            // 
            this.srchBox.ForeColor = System.Drawing.Color.Silver;
            this.srchBox.Location = new System.Drawing.Point(12, 12);
            this.srchBox.Name = "srchBox";
            this.srchBox.Size = new System.Drawing.Size(429, 20);
            this.srchBox.TabIndex = 0;
            this.srchBox.Text = "Search by Book ID";
            this.srchBox.Click += new System.EventHandler(this.srchBox_Click);
            this.srchBox.Enter += new System.EventHandler(this.srchBox_Enter);
            this.srchBox.Leave += new System.EventHandler(this.srchBox_Leave);
            // 
            // srchBtn
            // 
            this.srchBtn.Location = new System.Drawing.Point(447, 10);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(75, 23);
            this.srchBtn.TabIndex = 1;
            this.srchBtn.Text = "Search";
            this.srchBtn.UseVisualStyleBackColor = true;
            this.srchBtn.Click += new System.EventHandler(this.srchBtn_Click);
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Location = new System.Drawing.Point(26, 97);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(55, 13);
            this.bookTitle.TabIndex = 2;
            this.bookTitle.Text = "Book Title";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(112, 97);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(158, 20);
            this.titleBox.TabIndex = 3;
            // 
            // bookSKU
            // 
            this.bookSKU.AutoSize = true;
            this.bookSKU.Location = new System.Drawing.Point(298, 192);
            this.bookSKU.Name = "bookSKU";
            this.bookSKU.Size = new System.Drawing.Size(57, 13);
            this.bookSKU.TabIndex = 2;
            this.bookSKU.Text = "Book SKU";
            // 
            // skuBox
            // 
            this.skuBox.Location = new System.Drawing.Point(384, 192);
            this.skuBox.Name = "skuBox";
            this.skuBox.Size = new System.Drawing.Size(138, 20);
            this.skuBox.TabIndex = 3;
            // 
            // autherName
            // 
            this.autherName.AutoSize = true;
            this.autherName.Location = new System.Drawing.Point(26, 144);
            this.autherName.Name = "autherName";
            this.autherName.Size = new System.Drawing.Size(76, 13);
            this.autherName.TabIndex = 2;
            this.autherName.Text = "Author\'s Name";
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(112, 144);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(158, 20);
            this.authorBox.TabIndex = 3;
            // 
            // bookPrice
            // 
            this.bookPrice.AutoSize = true;
            this.bookPrice.Location = new System.Drawing.Point(26, 192);
            this.bookPrice.Name = "bookPrice";
            this.bookPrice.Size = new System.Drawing.Size(68, 13);
            this.bookPrice.TabIndex = 2;
            this.bookPrice.Text = "Book\'S Price";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(112, 192);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(158, 20);
            this.priceBox.TabIndex = 3;
            // 
            // availability
            // 
            this.availability.AutoSize = true;
            this.availability.Location = new System.Drawing.Point(304, 55);
            this.availability.Name = "availability";
            this.availability.Size = new System.Drawing.Size(56, 13);
            this.availability.TabIndex = 2;
            this.availability.Text = "Availability";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(304, 97);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(49, 13);
            this.category.TabIndex = 2;
            this.category.Text = "Category";
            // 
            // description
            // 
            this.description.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(304, 147);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(60, 13);
            this.description.TabIndex = 2;
            this.description.Text = "Description";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(32, 55);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(46, 13);
            this.id.TabIndex = 2;
            this.id.Text = "Book ID";
            // 
            // desBox
            // 
            this.desBox.Location = new System.Drawing.Point(384, 144);
            this.desBox.Name = "desBox";
            this.desBox.Size = new System.Drawing.Size(138, 20);
            this.desBox.TabIndex = 3;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(112, 52);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(158, 20);
            this.idBox.TabIndex = 3;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(447, 244);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // catBox
            // 
            this.catBox.FormattingEnabled = true;
            this.catBox.Items.AddRange(new object[] {
            "Classic",
            "Comic Book",
            "Crime and Detective",
            "Ethical and Culture",
            "Fairy Tale",
            "Fiction",
            "Humour",
            "Historical fiction",
            "Mystrey",
            "Novel",
            "Poetry",
            "Religious"});
            this.catBox.Location = new System.Drawing.Point(384, 88);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(138, 21);
            this.catBox.TabIndex = 4;
            // 
            // availBox
            // 
            this.availBox.FormattingEnabled = true;
            this.availBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.availBox.Location = new System.Drawing.Point(384, 46);
            this.availBox.Name = "availBox";
            this.availBox.Size = new System.Drawing.Size(138, 21);
            this.availBox.TabIndex = 5;
            // 
            // updateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 289);
            this.Controls.Add(this.availBox);
            this.Controls.Add(this.catBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.desBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.id);
            this.Controls.Add(this.skuBox);
            this.Controls.Add(this.description);
            this.Controls.Add(this.bookPrice);
            this.Controls.Add(this.category);
            this.Controls.Add(this.autherName);
            this.Controls.Add(this.bookSKU);
            this.Controls.Add(this.availability);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.srchBtn);
            this.Controls.Add(this.srchBox);
            this.Name = "updateBook";
            this.Text = "updateBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srchBox;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label bookSKU;
        private System.Windows.Forms.TextBox skuBox;
        private System.Windows.Forms.Label autherName;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.Label bookPrice;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label availability;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox desBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ComboBox catBox;
        private System.Windows.Forms.ComboBox availBox;
    }
}