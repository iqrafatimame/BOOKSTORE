namespace LAB5_Login_
{
    partial class AddBookDetails
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
            this.availBox = new System.Windows.Forms.ComboBox();
            this.catBox = new System.Windows.Forms.ComboBox();
            this.nxtBtn = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.descBox = new System.Windows.Forms.TextBox();
            this.bookId = new System.Windows.Forms.Label();
            this.bookDesc = new System.Windows.Forms.Label();
            this.bookCat = new System.Windows.Forms.Label();
            this.bookAvail = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.skuBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.bookPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bookAuthor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bookSKU = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BookTitle = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.availBox);
            this.panel1.Controls.Add(this.catBox);
            this.panel1.Controls.Add(this.nxtBtn);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.descBox);
            this.panel1.Controls.Add(this.bookId);
            this.panel1.Controls.Add(this.bookDesc);
            this.panel1.Controls.Add(this.bookCat);
            this.panel1.Controls.Add(this.bookAvail);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.authorBox);
            this.panel1.Controls.Add(this.skuBox);
            this.panel1.Controls.Add(this.titleBox);
            this.panel1.Controls.Add(this.bookPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bookAuthor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bookSKU);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BookTitle);
            this.panel1.Controls.Add(this.detailLabel);
            this.panel1.Location = new System.Drawing.Point(137, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 319);
            this.panel1.TabIndex = 0;
            // 
            // availBox
            // 
            this.availBox.FormattingEnabled = true;
            this.availBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.availBox.Location = new System.Drawing.Point(377, 66);
            this.availBox.Name = "availBox";
            this.availBox.Size = new System.Drawing.Size(148, 21);
            this.availBox.TabIndex = 12;
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
            this.catBox.Location = new System.Drawing.Point(377, 115);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(148, 21);
            this.catBox.TabIndex = 11;
            // 
            // nxtBtn
            // 
            this.nxtBtn.Location = new System.Drawing.Point(391, 267);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(134, 23);
            this.nxtBtn.TabIndex = 10;
            this.nxtBtn.Text = "ADD DETAILS";
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(377, 209);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(148, 20);
            this.idBox.TabIndex = 7;
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(377, 162);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(148, 20);
            this.descBox.TabIndex = 7;
            this.descBox.TextChanged += new System.EventHandler(this.descBox_TextChanged);
            // 
            // bookId
            // 
            this.bookId.AutoSize = true;
            this.bookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookId.Location = new System.Drawing.Point(303, 213);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(53, 13);
            this.bookId.TabIndex = 3;
            this.bookId.Text = "Book ID";
            this.bookId.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookDesc
            // 
            this.bookDesc.AutoSize = true;
            this.bookDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDesc.Location = new System.Drawing.Point(299, 166);
            this.bookDesc.Name = "bookDesc";
            this.bookDesc.Size = new System.Drawing.Size(71, 13);
            this.bookDesc.TabIndex = 3;
            this.bookDesc.Text = "Description";
            // 
            // bookCat
            // 
            this.bookCat.AutoSize = true;
            this.bookCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCat.Location = new System.Drawing.Point(299, 117);
            this.bookCat.Name = "bookCat";
            this.bookCat.Size = new System.Drawing.Size(57, 13);
            this.bookCat.TabIndex = 4;
            this.bookCat.Text = "Category";
            // 
            // bookAvail
            // 
            this.bookAvail.AutoSize = true;
            this.bookAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAvail.Location = new System.Drawing.Point(299, 66);
            this.bookAvail.Name = "bookAvail";
            this.bookAvail.Size = new System.Drawing.Size(68, 13);
            this.bookAvail.TabIndex = 5;
            this.bookAvail.Text = "Availability";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(135, 213);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(148, 20);
            this.priceBox.TabIndex = 1;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(135, 162);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(148, 20);
            this.authorBox.TabIndex = 1;
            // 
            // skuBox
            // 
            this.skuBox.Location = new System.Drawing.Point(135, 114);
            this.skuBox.Name = "skuBox";
            this.skuBox.Size = new System.Drawing.Size(148, 20);
            this.skuBox.TabIndex = 1;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(135, 64);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(148, 20);
            this.titleBox.TabIndex = 1;
            // 
            // bookPrice
            // 
            this.bookPrice.AutoSize = true;
            this.bookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPrice.Location = new System.Drawing.Point(40, 218);
            this.bookPrice.Name = "bookPrice";
            this.bookPrice.Size = new System.Drawing.Size(78, 13);
            this.bookPrice.TabIndex = 0;
            this.bookPrice.Text = "Book\'s Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "label1";
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSize = true;
            this.bookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthor.Location = new System.Drawing.Point(38, 167);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(89, 13);
            this.bookAuthor.TabIndex = 0;
            this.bookAuthor.Text = "Author\'s Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label1";
            // 
            // bookSKU
            // 
            this.bookSKU.AutoSize = true;
            this.bookSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSKU.Location = new System.Drawing.Point(35, 118);
            this.bookSKU.Name = "bookSKU";
            this.bookSKU.Size = new System.Drawing.Size(65, 13);
            this.bookSKU.TabIndex = 0;
            this.bookSKU.Text = "Book SKU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "label1";
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSize = true;
            this.BookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitle.Location = new System.Drawing.Point(35, 66);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(65, 13);
            this.BookTitle.TabIndex = 0;
            this.BookTitle.Text = "Book Title";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel.Location = new System.Drawing.Point(196, 16);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(148, 20);
            this.detailLabel.TabIndex = 0;
            this.detailLabel.Text = "Add Book Details";
            // 
            // AddBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddBookDetails";
            this.Text = "AddBookDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nxtBtn;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Label bookDesc;
        private System.Windows.Forms.Label bookCat;
        private System.Windows.Forms.Label bookAvail;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox skuBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label bookPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label bookAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bookSKU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BookTitle;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label bookId;
        private System.Windows.Forms.ComboBox catBox;
        private System.Windows.Forms.ComboBox availBox;
    }
}