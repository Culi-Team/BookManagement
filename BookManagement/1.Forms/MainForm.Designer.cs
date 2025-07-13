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
            BookManagePage = new TabPage();
            listBook = new DataGridView();
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
            BorrowManagePage = new TabPage();
            bindingSource1 = new BindingSource(components);
            tabControl1.SuspendLayout();
            BookManagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listBook).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBookQuantity).BeginInit();
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
            // BookManagePage
            // 
            BookManagePage.Controls.Add(listBook);
            BookManagePage.Controls.Add(groupBox1);
            BookManagePage.Location = new Point(4, 24);
            BookManagePage.Name = "BookManagePage";
            BookManagePage.Padding = new Padding(3);
            BookManagePage.Size = new Size(875, 510);
            BookManagePage.TabIndex = 0;
            BookManagePage.Text = "Book Manager";
            BookManagePage.UseVisualStyleBackColor = true;
            // 
            // listBook
            // 
            listBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBook.Location = new Point(15, 119);
            listBook.Name = "listBook";
            listBook.Size = new Size(844, 382);
            listBook.TabIndex = 1;
            listBook.CellMouseClick += listBook_CellMouseClick;
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
            groupBox1.Location = new Point(15, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(844, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Information";
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
            RemoveBook.Text = "Remove Book";
            RemoveBook.UseVisualStyleBackColor = true;
            RemoveBook.Click += RemoveBook_Click;
            // 
            // Update
            // 
            Update.Location = new Point(554, 37);
            Update.Name = "Update";
            Update.Size = new Size(88, 43);
            Update.TabIndex = 2;
            Update.Text = "Update Book";
            Update.UseVisualStyleBackColor = true;
            Update.Click += UpdateBook_Click;
            // 
            // AddBook
            // 
            AddBook.Location = new Point(652, 37);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(88, 43);
            AddBook.TabIndex = 2;
            AddBook.Text = "Add Book";
            AddBook.UseVisualStyleBackColor = true;
            AddBook.Click += AddBook_Click;
            // 
            // txtPublishYear
            // 
            txtPublishYear.Location = new Point(287, 69);
            txtPublishYear.Name = "txtPublishYear";
            txtPublishYear.Size = new Size(105, 23);
            txtPublishYear.TabIndex = 1;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(287, 26);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(105, 23);
            txtAuthor.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 72);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 0;
            label4.Text = "Publish year";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(82, 68);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(105, 23);
            txtPublisher.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 53);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 0;
            label5.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 29);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Author:";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(82, 26);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(105, 23);
            txtBookName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 0;
            label2.Text = "Publisher";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Book name:";
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
            ReaderManagePage.Text = "Reader Manager";
            ReaderManagePage.UseVisualStyleBackColor = true;
            // 
            // listReader
            // 
            listReader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            listReader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listReader.Location = new Point(39, 154);
            listReader.Name = "listReader";
            listReader.Size = new Size(803, 341);
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
            groupBox2.Text = "Reader Information";
            // 
            // btnUpdateReader
            // 
            btnUpdateReader.Location = new Point(552, 18);
            btnUpdateReader.Name = "btnUpdateReader";
            btnUpdateReader.Size = new Size(88, 43);
            btnUpdateReader.TabIndex = 2;
            btnUpdateReader.Text = "Update Reader";
            btnUpdateReader.UseVisualStyleBackColor = true;
            btnUpdateReader.Click += btnUpdateReader_Click;
            // 
            // btnRemoveReader
            // 
            btnRemoveReader.Location = new Point(740, 18);
            btnRemoveReader.Name = "btnRemoveReader";
            btnRemoveReader.Size = new Size(88, 43);
            btnRemoveReader.TabIndex = 2;
            btnRemoveReader.Text = "Remove Reader";
            btnRemoveReader.UseVisualStyleBackColor = true;
            btnRemoveReader.Click += btnRemoveReader_Click;
            // 
            // btnAddReader
            // 
            btnAddReader.Location = new Point(646, 18);
            btnAddReader.Name = "btnAddReader";
            btnAddReader.Size = new Size(88, 43);
            btnAddReader.TabIndex = 2;
            btnAddReader.Text = "Add Reader";
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
            label6.Location = new Point(385, 32);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 0;
            label6.Text = "Phone:";
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
            label10.Location = new Point(6, 29);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 0;
            label10.Text = "Name:";
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
            groupBox3.Text = "Reader Manager";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(739, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(657, 23);
            textBox2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 31);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 0;
            label7.Text = "Search:";
            // 
            // BorrowManagePage
            // 
            BorrowManagePage.Location = new Point(4, 24);
            BorrowManagePage.Name = "BorrowManagePage";
            BorrowManagePage.Padding = new Padding(3);
            BorrowManagePage.Size = new Size(875, 510);
            BorrowManagePage.TabIndex = 2;
            BorrowManagePage.Text = "Borrow Managerment";
            BorrowManagePage.UseVisualStyleBackColor = true;
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
            BookManagePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listBook).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBookQuantity).EndInit();
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
    }
}