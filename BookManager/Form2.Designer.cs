namespace BookManager
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_page = new System.Windows.Forms.TextBox();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.textBox_BookName = new System.Windows.Forms.TextBox();
            this.textBox_Isbn = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.Button_Modify = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Book = new System.Windows.Forms.DataGridView();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBorrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_page);
            this.groupBox1.Controls.Add(this.textBox_publisher);
            this.groupBox1.Controls.Add(this.textBox_BookName);
            this.groupBox1.Controls.Add(this.textBox_Isbn);
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.Button_Modify);
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서 추가/수정/삭제";
            // 
            // textBox_page
            // 
            this.textBox_page.Location = new System.Drawing.Point(81, 108);
            this.textBox_page.Name = "textBox_page";
            this.textBox_page.Size = new System.Drawing.Size(689, 25);
            this.textBox_page.TabIndex = 10;
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Location = new System.Drawing.Point(81, 81);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(689, 25);
            this.textBox_publisher.TabIndex = 9;
            // 
            // textBox_BookName
            // 
            this.textBox_BookName.Location = new System.Drawing.Point(81, 53);
            this.textBox_BookName.Name = "textBox_BookName";
            this.textBox_BookName.Size = new System.Drawing.Size(689, 25);
            this.textBox_BookName.TabIndex = 8;
            // 
            // textBox_Isbn
            // 
            this.textBox_Isbn.Location = new System.Drawing.Point(81, 25);
            this.textBox_Isbn.Name = "textBox_Isbn";
            this.textBox_Isbn.Size = new System.Drawing.Size(689, 25);
            this.textBox_Isbn.TabIndex = 7;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(219, 139);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "삭제";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Button_Modify
            // 
            this.Button_Modify.Location = new System.Drawing.Point(109, 139);
            this.Button_Modify.Name = "Button_Modify";
            this.Button_Modify.Size = new System.Drawing.Size(75, 23);
            this.Button_Modify.TabIndex = 5;
            this.Button_Modify.Text = "수정";
            this.Button_Modify.UseVisualStyleBackColor = true;
            this.Button_Modify.Click += new System.EventHandler(this.Button_Modify_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(6, 139);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "추가";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "페이지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "출판사";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "도서이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isbn";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1092, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "도서현황";
            // 
            // dataGridView_Book
            // 
            this.dataGridView_Book.AutoGenerateColumns = false;
            this.dataGridView_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.isBorrowedDataGridViewTextBoxColumn});
            this.dataGridView_Book.DataSource = this.bookBindingSource;
            this.dataGridView_Book.Location = new System.Drawing.Point(22, 234);
            this.dataGridView_Book.Name = "dataGridView_Book";
            this.dataGridView_Book.RowHeadersWidth = 51;
            this.dataGridView_Book.RowTemplate.Height = 27;
            this.dataGridView_Book.Size = new System.Drawing.Size(1062, 198);
            this.dataGridView_Book.TabIndex = 0;
            this.dataGridView_Book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Book_CellClick);
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pageDataGridViewTextBoxColumn
            // 
            this.pageDataGridViewTextBoxColumn.DataPropertyName = "Page";
            this.pageDataGridViewTextBoxColumn.HeaderText = "Page";
            this.pageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pageDataGridViewTextBoxColumn.Name = "pageDataGridViewTextBoxColumn";
            this.pageDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // isBorrowedDataGridViewTextBoxColumn
            // 
            this.isBorrowedDataGridViewTextBoxColumn.DataPropertyName = "isBorrowed";
            this.isBorrowedDataGridViewTextBoxColumn.HeaderText = "isBorrowed";
            this.isBorrowedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isBorrowedDataGridViewTextBoxColumn.Name = "isBorrowedDataGridViewTextBoxColumn";
            this.isBorrowedDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(BookManager.Book);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 450);
            this.Controls.Add(this.dataGridView_Book);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_page;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.TextBox textBox_BookName;
        private System.Windows.Forms.TextBox textBox_Isbn;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button Button_Modify;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isBorrowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
    }
}