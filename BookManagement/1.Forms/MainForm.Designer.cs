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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
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
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listBook).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBookQuantity).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(881, 541);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBook);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(873, 513);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Book Manager";
            tabPage1.UseVisualStyleBackColor = true;
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
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(873, 513);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Reader Manager";
            tabPage2.UseVisualStyleBackColor = true;
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
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listBook).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBookQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
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
    }
}