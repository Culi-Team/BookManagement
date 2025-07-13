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
        private JsonRepository<Reader> _readerRepo = new JsonRepository<Reader>(AppPaths.ReadersFile);

        public MainForm()
        {
            InitializeComponent();
            LoadBooksToGrid();
            LoadReaderToGrid();
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
        private void LoadReaderToGrid()
        {
            var readers = _readerRepo.Load();

            listReader.DataSource = readers;

            listReader.Columns["Id"].HeaderText = "ID người mượn";
            listReader.Columns["Name"].HeaderText = "Tên người mượn";
            listReader.Columns["Email"].HeaderText = "Mail người mượn";
            listReader.Columns["Phone"].HeaderText = "Phone người mượn";

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

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            var selectedBook = (Book)listBook.CurrentRow.DataBoundItem;

            var updateBook = new Book
            {
                Id = selectedBook.Id,
                Title = txtBookName.Text,
                Author = txtAuthor.Text,
                Publisher = txtPublisher.Text,
                Year = int.Parse(txtPublishYear.Text),
                Quantity = int.Parse(txtBookQuantity.Text),
            };

            _bookRepo.Update(updateBook);
            LoadBooksToGrid();
        }

        private void RemoveBook_Click(object sender, EventArgs e)
        {
            var selectedBook = (Book)listBook.CurrentRow.DataBoundItem;

            _bookRepo.Delete(selectedBook.Id);
            LoadBooksToGrid();
        }

        private void listBook_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedBook = (Book)listBook.CurrentRow.DataBoundItem;

            txtBookName.Text = selectedBook.Title;
            txtAuthor.Text = selectedBook.Author;
            txtPublisher.Text = selectedBook.Publisher;
            txtPublishYear.Text = selectedBook.Year.ToString();
            txtBookQuantity.Value = selectedBook.Quantity;
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            var newReader = new Reader
            {
                Name = txtReaderName.Text,
                Email = txtReaderEmail.Text,
                Phone = txtReaderPhone.Text,
            };
            _readerRepo.Add(newReader);
            LoadReaderToGrid();
        }

        private void btnUpdateReader_Click(object sender, EventArgs e)
        {
            var selectedReader = (Reader)listReader.CurrentRow.DataBoundItem;

            var updateReader = new Reader
            {
                Id = selectedReader.Id,
                Name = txtReaderName.Text,
                Email = txtReaderEmail.Text,
                Phone = txtReaderPhone.Text,
            };

            _readerRepo.Update(updateReader);
            LoadReaderToGrid();
        }

        private void listReader_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedReader = (Reader)listReader.CurrentRow.DataBoundItem;

            txtReaderName.Text = selectedReader.Name;
            txtReaderEmail.Text = selectedReader.Email;
            txtReaderPhone.Text = selectedReader.Phone;
        }

        private void btnRemoveReader_Click(object sender, EventArgs e)
        {
            var selectedReader = (Reader)listReader.CurrentRow.DataBoundItem;

            _readerRepo.Delete(selectedReader.Id);
            LoadReaderToGrid();
        }
    }
}
