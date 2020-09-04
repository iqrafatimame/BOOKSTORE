namespace LAB5_Login_
{
    partial class searchBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.religion = new System.Windows.Forms.Label();
            this.poetry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mystery = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homour = new System.Windows.Forms.Label();
            this.fictionLabel = new System.Windows.Forms.Label();
            this.fairyTale = new System.Windows.Forms.Label();
            this.ethical = new System.Windows.Forms.Label();
            this.crime = new System.Windows.Forms.Label();
            this.comicBook = new System.Windows.Forms.Label();
            this.classicLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.storeDBDataSet = new LAB5_Login_.storeDBDataSet();
            this.storeDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storeDBDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.searchGrid = new System.Windows.Forms.DataGridView();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new LAB5_Login_.storeDBDataSetTableAdapters.BOOKTableAdapter();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookSKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAvailabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDesciptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(676, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(92, 36);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            this.searchBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBtn_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.religion);
            this.panel1.Controls.Add(this.poetry);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mystery);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.homour);
            this.panel1.Controls.Add(this.fictionLabel);
            this.panel1.Controls.Add(this.fairyTale);
            this.panel1.Controls.Add(this.ethical);
            this.panel1.Controls.Add(this.crime);
            this.panel1.Controls.Add(this.comicBook);
            this.panel1.Controls.Add(this.classicLabel);
            this.panel1.Location = new System.Drawing.Point(1, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 705);
            this.panel1.TabIndex = 2;
            // 
            // religion
            // 
            this.religion.AccessibleName = "novel";
            this.religion.AutoSize = true;
            this.religion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.religion.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.religion.Location = new System.Drawing.Point(15, 630);
            this.religion.Name = "religion";
            this.religion.Size = new System.Drawing.Size(100, 29);
            this.religion.TabIndex = 0;
            this.religion.Text = "Religion";
            this.religion.Click += new System.EventHandler(this.religion_Click);
            // 
            // poetry
            // 
            this.poetry.AccessibleName = "novel";
            this.poetry.AutoSize = true;
            this.poetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poetry.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poetry.Location = new System.Drawing.Point(13, 577);
            this.poetry.Name = "poetry";
            this.poetry.Size = new System.Drawing.Size(80, 29);
            this.poetry.TabIndex = 0;
            this.poetry.Text = "Poetry";
            this.poetry.Click += new System.EventHandler(this.poetry_Click);
            // 
            // label3
            // 
            this.label3.AccessibleName = "novel";
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Novel";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mystery
            // 
            this.mystery.AutoSize = true;
            this.mystery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mystery.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mystery.Location = new System.Drawing.Point(13, 468);
            this.mystery.Name = "mystery";
            this.mystery.Size = new System.Drawing.Size(98, 29);
            this.mystery.TabIndex = 0;
            this.mystery.Text = "Mystrey";
            this.mystery.Click += new System.EventHandler(this.mystery_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "history";
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historical fiction";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // homour
            // 
            this.homour.AutoSize = true;
            this.homour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homour.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homour.Location = new System.Drawing.Point(13, 357);
            this.homour.Name = "homour";
            this.homour.Size = new System.Drawing.Size(102, 29);
            this.homour.TabIndex = 0;
            this.homour.Text = "Humour";
            this.homour.Click += new System.EventHandler(this.homour_Click);
            // 
            // fictionLabel
            // 
            this.fictionLabel.AutoSize = true;
            this.fictionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fictionLabel.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fictionLabel.Location = new System.Drawing.Point(13, 300);
            this.fictionLabel.Name = "fictionLabel";
            this.fictionLabel.Size = new System.Drawing.Size(86, 29);
            this.fictionLabel.TabIndex = 0;
            this.fictionLabel.Text = "Fiction";
            this.fictionLabel.Click += new System.EventHandler(this.fictionLabel_Click);
            // 
            // fairyTale
            // 
            this.fairyTale.AutoSize = true;
            this.fairyTale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fairyTale.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fairyTale.Location = new System.Drawing.Point(13, 237);
            this.fairyTale.Name = "fairyTale";
            this.fairyTale.Size = new System.Drawing.Size(114, 29);
            this.fairyTale.TabIndex = 0;
            this.fairyTale.Text = "Fairy Tale";
            this.fairyTale.Click += new System.EventHandler(this.fairyTale_Click);
            // 
            // ethical
            // 
            this.ethical.AutoSize = true;
            this.ethical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ethical.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ethical.Location = new System.Drawing.Point(13, 184);
            this.ethical.Name = "ethical";
            this.ethical.Size = new System.Drawing.Size(217, 29);
            this.ethical.TabIndex = 0;
            this.ethical.Text = "Ethical and Culture";
            this.ethical.Click += new System.EventHandler(this.ethical_Click);
            // 
            // crime
            // 
            this.crime.AutoSize = true;
            this.crime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crime.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crime.Location = new System.Drawing.Point(9, 128);
            this.crime.Name = "crime";
            this.crime.Size = new System.Drawing.Size(227, 29);
            this.crime.TabIndex = 0;
            this.crime.Text = "Crime and Detective";
            this.crime.Click += new System.EventHandler(this.crime_Click);
            // 
            // comicBook
            // 
            this.comicBook.AutoSize = true;
            this.comicBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comicBook.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comicBook.Location = new System.Drawing.Point(13, 74);
            this.comicBook.Name = "comicBook";
            this.comicBook.Size = new System.Drawing.Size(139, 29);
            this.comicBook.TabIndex = 0;
            this.comicBook.Text = "Comic Book";
            this.comicBook.Click += new System.EventHandler(this.comicBook_Click);
            // 
            // classicLabel
            // 
            this.classicLabel.AutoSize = true;
            this.classicLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classicLabel.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicLabel.Location = new System.Drawing.Point(15, 29);
            this.classicLabel.Name = "classicLabel";
            this.classicLabel.Size = new System.Drawing.Size(86, 29);
            this.classicLabel.TabIndex = 0;
            this.classicLabel.Text = "Classic";
            this.classicLabel.Click += new System.EventHandler(this.classicLabel_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.White;
            this.categoryLabel.Location = new System.Drawing.Point(35, 8);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(153, 25);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "CATEGORIES";
            // 
            // storeDBDataSet
            // 
            this.storeDBDataSet.DataSetName = "storeDBDataSet";
            this.storeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeDBDataSetBindingSource
            // 
            this.storeDBDataSetBindingSource.DataSource = this.storeDBDataSet;
            this.storeDBDataSetBindingSource.Position = 0;
            // 
            // storeDBDataSetBindingSource1
            // 
            this.storeDBDataSetBindingSource1.DataSource = this.storeDBDataSet;
            this.storeDBDataSetBindingSource1.Position = 0;
            // 
            // storeDBDataSetBindingSource2
            // 
            this.storeDBDataSetBindingSource2.DataSource = this.storeDBDataSet;
            this.storeDBDataSetBindingSource2.Position = 0;
            // 
            // searchGrid
            // 
            this.searchGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGrid.AutoGenerateColumns = false;
            this.searchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.searchGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.searchGrid.ColumnHeadersHeight = 60;
            this.searchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.bookIdDataGridViewTextBoxColumn,
            this.bookSKUDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn,
            this.bookAvailabilityDataGridViewTextBoxColumn,
            this.bookCategoryDataGridViewTextBoxColumn,
            this.bookDesciptionDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn});
            this.searchGrid.DataSource = this.bOOKBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.searchGrid.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.searchGrid.Location = new System.Drawing.Point(238, 44);
            this.searchGrid.Margin = new System.Windows.Forms.Padding(10);
            this.searchGrid.Name = "searchGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.searchGrid.RowHeadersWidth = 50;
            this.searchGrid.RowTemplate.Height = 90;
            this.searchGrid.Size = new System.Drawing.Size(731, 705);
            this.searchGrid.TabIndex = 4;
            this.searchGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchGrid_CellContentClick);
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.storeDBDataSet;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Silver;
            this.searchBox.Location = new System.Drawing.Point(238, 5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(432, 35);
            this.searchBox.TabIndex = 6;
            this.searchBox.Text = "Search name of the book";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // showBtn
            // 
            this.showBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showBtn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.Location = new System.Drawing.Point(774, 4);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(110, 36);
            this.showBtn.TabIndex = 7;
            this.showBtn.Text = "SHOW ALL";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // bookId
            // 
            this.bookId.DataPropertyName = "bookId";
            this.bookId.HeaderText = "ID";
            this.bookId.Name = "bookId";
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "bookId";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            // 
            // bookSKUDataGridViewTextBoxColumn
            // 
            this.bookSKUDataGridViewTextBoxColumn.DataPropertyName = "bookSKU";
            this.bookSKUDataGridViewTextBoxColumn.HeaderText = "bookSKU";
            this.bookSKUDataGridViewTextBoxColumn.Name = "bookSKUDataGridViewTextBoxColumn";
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "bookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "bookTitle";
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            // 
            // bookPriceDataGridViewTextBoxColumn
            // 
            this.bookPriceDataGridViewTextBoxColumn.DataPropertyName = "bookPrice";
            this.bookPriceDataGridViewTextBoxColumn.HeaderText = "bookPrice";
            this.bookPriceDataGridViewTextBoxColumn.Name = "bookPriceDataGridViewTextBoxColumn";
            // 
            // bookAvailabilityDataGridViewTextBoxColumn
            // 
            this.bookAvailabilityDataGridViewTextBoxColumn.DataPropertyName = "bookAvailability";
            this.bookAvailabilityDataGridViewTextBoxColumn.HeaderText = "bookAvailability";
            this.bookAvailabilityDataGridViewTextBoxColumn.Name = "bookAvailabilityDataGridViewTextBoxColumn";
            // 
            // bookCategoryDataGridViewTextBoxColumn
            // 
            this.bookCategoryDataGridViewTextBoxColumn.DataPropertyName = "bookCategory";
            this.bookCategoryDataGridViewTextBoxColumn.HeaderText = "bookCategory";
            this.bookCategoryDataGridViewTextBoxColumn.Name = "bookCategoryDataGridViewTextBoxColumn";
            // 
            // bookDesciptionDataGridViewTextBoxColumn
            // 
            this.bookDesciptionDataGridViewTextBoxColumn.DataPropertyName = "bookDesciption";
            this.bookDesciptionDataGridViewTextBoxColumn.HeaderText = "bookDesciption";
            this.bookDesciptionDataGridViewTextBoxColumn.Name = "bookDesciptionDataGridViewTextBoxColumn";
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "bookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "bookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(890, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(72, 36);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "CLOSE";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.searchBtn_Click);
            this.closeBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBtn_KeyPress);
            this.closeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseClick);
            // 
            // searchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(968, 749);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchGrid);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.searchBtn);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "searchBook";
            this.Text = "searchBook";
            this.Load += new System.EventHandler(this.searchBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label homour;
        private System.Windows.Forms.Label fictionLabel;
        private System.Windows.Forms.Label fairyTale;
        private System.Windows.Forms.Label ethical;
        private System.Windows.Forms.Label crime;
        private System.Windows.Forms.Label comicBook;
        private System.Windows.Forms.Label classicLabel;
        private System.Windows.Forms.Label categoryLabel;
        private storeDBDataSet storeDBDataSet;
        private System.Windows.Forms.BindingSource storeDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource storeDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource storeDBDataSetBindingSource2;
        private System.Windows.Forms.DataGridView searchGrid;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private storeDBDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label religion;
        private System.Windows.Forms.Label poetry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mystery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookSKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAvailabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDesciptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button closeBtn;
    }
}