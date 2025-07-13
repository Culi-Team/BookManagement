using BookManagement._3.Models;
using BookManagement._4.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement._1.Forms
{
    public partial class MainForm : Form
    {
        private JsonRepository<Book> _bookRepo = new JsonRepository<Book>(AppPaths.BooksFile);

        public MainForm()
        {
            InitializeComponent();
            LoadBooksToGrid();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            var newBook = new Book
            {
                Title = txtBookName.Text,
                Author = txtAuthor.Text,
                Publisher = txtPublisher.Text,
                Year = int.Parse(txtPublishYear.Text),
                Quantity = int.Parse(txtBookQuantity.Text),
            };
            _bookRepo.Add(newBook);
            LoadBooksToGrid();
        }
        private void LoadBooksToGrid()
        {
            var books = _bookRepo.Load();

            listBook.DataSource = books;

            listBook.Columns["Id"].HeaderText = "Mã Sách";
            listBook.Columns["Title"].HeaderText = "Tên Sách";
            listBook.Columns["Author"].HeaderText = "Tác Giả";
            listBook.Columns["Publisher"].HeaderText = "NXB";
            listBook.Columns["Year"].HeaderText = "Năm";
            listBook.Columns["Quantity"].HeaderText = "Số Lượng";
        }
    }
}
