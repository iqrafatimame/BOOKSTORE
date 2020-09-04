namespace LAB5_Login_
{
    partial class viewBooks
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
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKDataSet1 = new LAB5_Login_.BOOKDataSet1();
            this.bOOKTableAdapter = new LAB5_Login_.BOOKDataSet1TableAdapters.BOOKTableAdapter();
            this.storeDBDataSet = new LAB5_Login_.storeDBDataSet();
            this.storeDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDetailGrid = new System.Windows.Forms.DataGridView();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookSKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAvailabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDesciptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewDetailBtn = new System.Windows.Forms.Button();
            this.srchBox = new System.Windows.Forms.TextBox();
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter1 = new LAB5_Login_.storeDBDataSetTableAdapters.BOOKTableAdapter();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.srchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.bOOKDataSet1;
            // 
            // bOOKDataSet1
            // 
            this.bOOKDataSet1.DataSetName = "BOOKDataSet1";
            this.bOOKDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
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
            // bookDetailGrid
            // 
            this.bookDetailGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookDetailGrid.AutoGenerateColumns = false;
            this.bookDetailGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDetailGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bookDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDetailGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookId,
            this.bookSKUDataGridViewTextBoxColumn,
            this.bookTitleDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn,
            this.bookAvailabilityDataGridViewTextBoxColumn,
            this.bookCategoryDataGridViewTextBoxColumn,
            this.bookDesciptionDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn});
            this.bookDetailGrid.DataSource = this.bOOKBindingSource;
            this.bookDetailGrid.Location = new System.Drawing.Point(12, 53);
            this.bookDetailGrid.Name = "bookDetailGrid";
            this.bookDetailGrid.Size = new System.Drawing.Size(841, 325);
            this.bookDetailGrid.TabIndex = 0;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "bookId";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            // 
            // bookId
            // 
            this.bookId.DataPropertyName = "bookId";
            this.bookId.HeaderText = "bookId";
            this.bookId.Name = "bookId";
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
            // viewDetailBtn
            // 
            this.viewDetailBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDetailBtn.BackColor = System.Drawing.Color.Maroon;
            this.viewDetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDetailBtn.ForeColor = System.Drawing.Color.White;
            this.viewDetailBtn.Location = new System.Drawing.Point(587, 11);
            this.viewDetailBtn.Name = "viewDetailBtn";
            this.viewDetailBtn.Size = new System.Drawing.Size(125, 31);
            this.viewDetailBtn.TabIndex = 1;
            this.viewDetailBtn.Text = "View All Books";
            this.viewDetailBtn.UseVisualStyleBackColor = false;
            this.viewDetailBtn.Click += new System.EventHandler(this.viewDetailBtn_Click);
            // 
            // srchBox
            // 
            this.srchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.srchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.srchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchBox.ForeColor = System.Drawing.Color.Silver;
            this.srchBox.Location = new System.Drawing.Point(86, 14);
            this.srchBox.Name = "srchBox";
            this.srchBox.Size = new System.Drawing.Size(431, 26);
            this.srchBox.TabIndex = 2;
            this.srchBox.Text = "Search Book Name";
            this.srchBox.TextChanged += new System.EventHandler(this.viewBox_TextChanged);
            this.srchBox.Enter += new System.EventHandler(this.srchBox_Enter);
            this.srchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewBox_KeyDown);
            this.srchBox.Leave += new System.EventHandler(this.srchBox_Leave);
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            this.bOOKBindingSource1.DataSource = this.storeDBDataSetBindingSource;
            // 
            // bOOKTableAdapter1
            // 
            this.bOOKTableAdapter1.ClearBeforeFill = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.Maroon;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(718, 12);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(110, 31);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Maroon;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(68, 29);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // srchBtn
            // 
            this.srchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.srchBtn.BackColor = System.Drawing.Color.Maroon;
            this.srchBtn.ForeColor = System.Drawing.Color.White;
            this.srchBtn.Location = new System.Drawing.Point(523, 11);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(58, 29);
            this.srchBtn.TabIndex = 8;
            this.srchBtn.Text = "Search";
            this.srchBtn.UseVisualStyleBackColor = false;
            this.srchBtn.Click += new System.EventHandler(this.srchBtn_Click);
            // 
            // viewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 561);
            this.Controls.Add(this.srchBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.srchBox);
            this.Controls.Add(this.viewDetailBtn);
            this.Controls.Add(this.bookDetailGrid);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "viewBooks";
            this.Text = "viewBooks";
            this.Load += new System.EventHandler(this.viewBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BOOKDataSet1 bOOKDataSet1;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private BOOKDataSet1TableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.BindingSource storeDBDataSetBindingSource;
        private storeDBDataSet storeDBDataSet;
        private System.Windows.Forms.DataGridView bookDetailGrid;
        private System.Windows.Forms.Button viewDetailBtn;
        private System.Windows.Forms.TextBox srchBox;
        private System.Windows.Forms.BindingSource bOOKBindingSource1;
        private storeDBDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookSKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAvailabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDesciptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
    }
}