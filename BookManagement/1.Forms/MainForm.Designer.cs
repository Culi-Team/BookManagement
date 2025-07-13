namespace BookManagement._1.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            BorrowManagePage = new TabPage();
            listBorrow = new DataGridView();
            groupBox4 = new GroupBox();
            datePckrReturnDate = new DateTimePicker();
            datePckrBorrowDate = new DateTimePicker();
            btnReturn = new Button();
            btnBookSelect = new Button();
            btnBorrow = new Button();
            label12 = new Label();
            txtBorrowBook = new TextBox();
            txtReader = new TextBox();
            label13 = new Label();
            label11 = new Label();
            label8 = new Label();
            BookManagePage = new TabPage();
            groupBox1 = new GroupBox();
            txtBookQuantity = new NumericUpDown();
            RemoveBook = new Button();
            Update = new Button();
            AddBook = new Button();
            txtPublishYear = new TextBox();
            txtAuthor = new TextBox();
            label4 = new Label();
            txtPublisher = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtBookName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            button4 = new Button();
            textBox4 = new TextBox();
            label14 = new Label();
            listBook = new DataGridView();
            ReaderManagePage = new TabPage();
            listReader = new DataGridView();
            groupBox2 = new GroupBox();
            btnUpdateReader = new Button();
            btnRemoveReader = new Button();
            btnAddReader = new Button();
            txtReaderPhone = new TextBox();
            txtReaderEmail = new TextBox();
            label6 = new Label();
            txtReaderName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            btnSearch = new Button();
            textBox2 = new TextBox();
            label7 = new Label();
            bindingSource1 = new BindingSource(components);
            tabControl1.SuspendLayout();
            BorrowManagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listBorrow).BeginInit();
            groupBox4.SuspendLayout();
            BookManagePage.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBookQuantity).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listBook).BeginInit();
            ReaderManagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listReader).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(BorrowManagePage);
            tabControl1.Controls.Add(BookManagePage);
            tabControl1.Controls.Add(ReaderManagePage);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(883, 538);
            tabControl1.TabIndex = 0;
            // 
            // BorrowManagePage
            // 
            BorrowManagePage.Controls.Add(listBorrow);
            BorrowManagePage.Controls.Add(groupBox4);
            BorrowManagePage.Location = new Point(4, 24);
            BorrowManagePage.Name = "BorrowManagePage";
            BorrowManagePage.Padding = new Padding(3);
            BorrowManagePage.Size = new Size(875, 510);
            BorrowManagePage.TabIndex = 2;
            BorrowManagePage.Text = "Quản lí mượn/trả sách";
            BorrowManagePage.UseVisualStyleBackColor = true;
            // 
            // listBorrow
            // 
            listBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBorrow.Location = new Point(9, 175);
            listBorrow.Name = "listBorrow";
            listBorrow.Size = new Size(858, 326);
            listBorrow.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(datePckrReturnDate);
            groupBox4.Controls.Add(datePckrBorrowDate);
            groupBox4.Controls.Add(btnReturn);
            groupBox4.Controls.Add(btnBookSelect);
            groupBox4.Controls.Add(btnBorrow);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txtBorrowBook);
            groupBox4.Controls.Add(txtReader);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(9, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(858, 157);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Quản lí mượn sách";
            // 
            // datePckrReturnDate
            // 
            datePckrReturnDate.Location = new Point(604, 52);
            datePckrReturnDate.Name = "datePckrReturnDate";
            datePckrReturnDate.Size = new Size(200, 23);
            datePckrReturnDate.TabIndex = 10;
            // 
            // datePckrBorrowDate
            // 
            datePckrBorrowDate.Location = new Point(604, 23);
            datePckrBorrowDate.Name = "datePckrBorrowDate";
            datePckrBorrowDate.Size = new Size(200, 23);
            datePckrBorrowDate.TabIndex = 10;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(433, 101);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(133, 43);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "Trả sách";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnBookSelect
            // 
            btnBookSelect.Location = new Point(209, 37);
            btnBookSelect.Name = "btnBookSelect";
            btnBookSelect.Size = new Size(77, 25);
            btnBookSelect.TabIndex = 9;
            btnBookSelect.Text = "Chọn sách";
            btnBookSelect.UseVisualStyleBackColor = true;
            btnBookSelect.Click += btnBookSelect_Click;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(265, 101);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(133, 43);
            btnBorrow.TabIndex = 9;
            btnBorrow.Text = "Mượn sách";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(538, 55);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 5;
            label12.Text = "Ngày trả:";
            // 
            // txtBorrowBook
            // 
            txtBorrowBook.Location = new Point(98, 37);
            txtBorrowBook.Name = "txtBorrowBook";
            txtBorrowBook.Size = new Size(105, 23);
            txtBorrowBook.TabIndex = 8;
            // 
            // txtReader
            // 
            txtReader.Location = new Point(367, 37);
            txtReader.Name = "txtReader";
            txtReader.Size = new Size(105, 23);
            txtReader.TabIndex = 8;
            txtReader.MouseDoubleClick += txtReader_MouseDoubleClick;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 40);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 5;
            label13.Text = "Sách mượn:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(520, 26);
            label11.Name = "label11";
            label11.Size = new Size(73, 15);
            label11.TabIndex = 5;
            label11.Text = "Ngày mượn:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(315, 40);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 5;
            label8.Text = "Độc giả:";
            // 
            // BookManagePage
            // 
            BookManagePage.Controls.Add(groupBox1);
            BookManagePage.Controls.Add(groupBox5);
            BookManagePage.Location = new Point(4, 24);
            BookManagePage.Name = "BookManagePage";
            BookManagePage.Padding = new Padding(3);
            BookManagePage.Size = new Size(875, 510);
            BookManagePage.TabIndex = 0;
            BookManagePage.Text = "Quản lí sách";
            BookManagePage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBookQuantity);
            groupBox1.Controls.Add(RemoveBook);
            groupBox1.Controls.Add(Update);
            groupBox1.Controls.Add(AddBook);
            groupBox1.Controls.Add(txtPublishYear);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPublisher);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBookName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(844, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // txtBookQuantity
            // 
            txtBookQuantity.Location = new Point(476, 49);
            txtBookQuantity.Name = "txtBookQuantity";
            txtBookQuantity.Size = new Size(65, 23);
            txtBookQuantity.TabIndex = 3;
            // 
            // RemoveBook
            // 
            RemoveBook.Location = new Point(750, 37);
            RemoveBook.Name = "RemoveBook";
            RemoveBook.Size = new Size(88, 43);
            RemoveBook.TabIndex = 2;
            RemoveBook.Text = "Xoá";
            RemoveBook.UseVisualStyleBackColor = true;
            RemoveBook.Click += RemoveBook_Click;
            // 
            // Update
            // 
            Update.Location = new Point(557, 37);
            Update.Name = "Update";
            Update.Size = new Size(88, 43);
            Update.TabIndex = 2;
            Update.Text = "Cập nhật";
            Update.UseVisualStyleBackColor = true;
            Update.Click += UpdateBook_Click;
            // 
            // AddBook
            // 
            AddBook.Location = new Point(654, 37);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(88, 43);
            AddBook.TabIndex = 2;
            AddBook.Text = "Thêm";
            AddBook.UseVisualStyleBackColor = true;
            AddBook.Click += AddBook_Click;
            // 
            // txtPublishYear
            // 
            txtPublishYear.Location = new Point(302, 69);
            txtPublishYear.Name = "txtPublishYear";
            txtPublishYear.Size = new Size(105, 23);
            txtPublishYear.TabIndex = 1;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(302, 26);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(105, 23);
            txtAuthor.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 72);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 0;
            label4.Text = "Năm xuất bản:";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(91, 68);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(105, 23);
            txtPublisher.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 53);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 0;
            label5.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 29);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Tác giả:";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(91, 26);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(105, 23);
            txtBookName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 71);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 0;
            label2.Text = "Nhà xuất bản:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên sách:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button4);
            groupBox5.Controls.Add(textBox4);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(listBook);
            groupBox5.Location = new Point(19, 125);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(843, 376);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách Sách";
            // 
            // button4
            // 
            button4.Location = new Point(743, 20);
            button4.Name = "button4";
            button4.Size = new Size(88, 31);
            button4.TabIndex = 5;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(76, 25);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(657, 23);
            textBox4.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 28);
            label14.Name = "label14";
            label14.Size = new Size(57, 15);
            label14.TabIndex = 3;
            label14.Text = "Tìm sách:";
            // 
            // listBook
            // 
            listBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBook.Location = new Point(13, 57);
            listBook.Name = "listBook";
            listBook.Size = new Size(818, 311);
            listBook.TabIndex = 1;
            listBook.CellMouseClick += listBook_CellMouseClick;
            // 
            // ReaderManagePage
            // 
            ReaderManagePage.Controls.Add(listReader);
            ReaderManagePage.Controls.Add(groupBox2);
            ReaderManagePage.Controls.Add(groupBox3);
            ReaderManagePage.Location = new Point(4, 24);
            ReaderManagePage.Name = "ReaderManagePage";
            ReaderManagePage.Padding = new Padding(3);
            ReaderManagePage.Size = new Size(875, 510);
            ReaderManagePage.TabIndex = 1;
            ReaderManagePage.Text = "Quản lí độc giả";
            ReaderManagePage.UseVisualStyleBackColor = true;
            // 
            // listReader
            // 
            listReader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            listReader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listReader.Location = new Point(28, 154);
            listReader.Name = "listReader";
            listReader.Size = new Size(818, 341);
            listReader.TabIndex = 3;
            listReader.CellMouseClick += listReader_CellMouseClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdateReader);
            groupBox2.Controls.Add(btnRemoveReader);
            groupBox2.Controls.Add(btnAddReader);
            groupBox2.Controls.Add(txtReaderPhone);
            groupBox2.Controls.Add(txtReaderEmail);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtReaderName);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(15, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(844, 73);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin độc giả";
            // 
            // btnUpdateReader
            // 
            btnUpdateReader.Location = new Point(552, 18);
            btnUpdateReader.Name = "btnUpdateReader";
            btnUpdateReader.Size = new Size(88, 43);
            btnUpdateReader.TabIndex = 2;
            btnUpdateReader.Text = "Cập nhật";
            btnUpdateReader.UseVisualStyleBackColor = true;
            btnUpdateReader.Click += btnUpdateReader_Click;
            // 
            // btnRemoveReader
            // 
            btnRemoveReader.Location = new Point(740, 18);
            btnRemoveReader.Name = "btnRemoveReader";
            btnRemoveReader.Size = new Size(88, 43);
            btnRemoveReader.TabIndex = 2;
            btnRemoveReader.Text = "Xoá";
            btnRemoveReader.UseVisualStyleBackColor = true;
            btnRemoveReader.Click += btnRemoveReader_Click;
            // 
            // btnAddReader
            // 
            btnAddReader.Location = new Point(646, 18);
            btnAddReader.Name = "btnAddReader";
            btnAddReader.Size = new Size(88, 43);
            btnAddReader.TabIndex = 2;
            btnAddReader.Text = "Thêm";
            btnAddReader.UseVisualStyleBackColor = true;
            btnAddReader.Click += btnAddReader_Click;
            // 
            // txtReaderPhone
            // 
            txtReaderPhone.Location = new Point(437, 29);
            txtReaderPhone.Name = "txtReaderPhone";
            txtReaderPhone.Size = new Size(105, 23);
            txtReaderPhone.TabIndex = 1;
            // 
            // txtReaderEmail
            // 
            txtReaderEmail.Location = new Point(247, 26);
            txtReaderEmail.Name = "txtReaderEmail";
            txtReaderEmail.Size = new Size(105, 23);
            txtReaderEmail.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(393, 32);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 0;
            label6.Text = "SĐT:";
            // 
            // txtReaderName
            // 
            txtReaderName.Location = new Point(58, 26);
            txtReaderName.Name = "txtReaderName";
            txtReaderName.Size = new Size(105, 23);
            txtReaderName.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(195, 29);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 0;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 29);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 0;
            label10.Text = "Tên:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(15, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(844, 419);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách độc giả";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(743, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(645, 23);
            textBox2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 31);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 0;
            label7.Text = "Tìm độc giả:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 537);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            tabControl1.ResumeLayout(false);
            BorrowManagePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listBorrow).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            BookManagePage.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBookQuantity).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listBook).EndInit();
            ReaderManagePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listReader).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage BookManagePage;
        private TabPage ReaderManagePage;
        private DataGridView listBook;
        private GroupBox groupBox1;
        private TextBox txtAuthor;
        private TextBox txtPublisher;
        private Label label3;
        private TextBox txtBookName;
        private Label label2;
        private Label label1;
        private Button AddBook;
        private TextBox txtPublishYear;
        private Label label4;
        private NumericUpDown txtBookQuantity;
        private Label label5;
        private Button RemoveBook;
        private Button Update;
        private DataGridView listReader;
        private GroupBox groupBox2;
        private Button btnAddReader;
        private TextBox txtReaderEmail;
        private Label label8;
        private TextBox txtReaderName;
        private Label label9;
        private Label label10;
        private TabPage BorrowManagePage;
        private TextBox txtReaderPhone;
        private Label label6;
        private GroupBox groupBox3;
        private Button btnSearch;
        private TextBox textBox2;
        private Label label7;
        private BindingSource bindingSource1;
        private Button btnUpdateReader;
        private Button btnRemoveReader;
        private GroupBox groupBox4;
        private Button btnReturn;
        private Button btnBorrow;
        private DateTimePicker datePckrReturnDate;
        private DateTimePicker datePckrBorrowDate;
        private Label label12;
        private TextBox txtReader;
        private Label label11;
        private DataGridView listBorrow;
        private Button btnBookSelect;
        private TextBox txtBorrowBook;
        private Label label13;
        private GroupBox groupBox5;
        private Button button4;
        private TextBox textBox4;
        private Label label14;
    }
}