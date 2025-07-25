﻿using BookManagement._2.Controls;
using BookManagement._3.Models;
using BookManagement._4.Helpers;
using BookManagement.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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
        //private JsonRepository<Book> _bookRepo = new JsonRepository<Book>(AppPaths.BooksFile);
        //private JsonRepository<Reader> _readerRepo = new JsonRepository<Reader>(AppPaths.ReadersFile);
        //private JsonRepository<Borrowing> _borrowRepo = new JsonRepository<Borrowing>(AppPaths.BorrowingsFile);
        private IRepository<Book> _bookRepository = new Repository<Book>(Program.BookManagementDb);
        private IRepository<Reader> _readerRepository = new Repository<Reader>(Program.BookManagementDb);
        private IRepository<Borrowing> _borrowingRepository = new Repository<Borrowing>(Program.BookManagementDb);
        private int bookIdBrow;
        private int readerIdBrow;
        public MainForm()
        {
            InitializeComponent();
            LoadBooksToGrid(_bookRepository.AsQueryable().ToList());
            LoadReaderToGrid(_readerRepository.AsQueryable().ToList());
            LoadBorrowToGrid();
        }
        private void LoadBooksToGrid(List<Book> books)
        {
            listBook.DataSource = books;

            listBook.Columns["Id"].HeaderText = "Mã Sách";
            listBook.Columns["Title"].HeaderText = "Tên Sách";
            listBook.Columns["Author"].HeaderText = "Tác Giả";
            listBook.Columns["Publisher"].HeaderText = "NXB";
            listBook.Columns["Year"].HeaderText = "Năm";
            listBook.Columns["Quantity"].HeaderText = "Số Lượng";
        }
        private void LoadReaderToGrid(List<Reader> readers)
        {
            listReader.DataSource = readers;

            listReader.Columns["Id"].HeaderText = "ID người mượn";
            listReader.Columns["Name"].HeaderText = "Tên người mượn";
            listReader.Columns["Email"].HeaderText = "Mail người mượn";
            listReader.Columns["Phone"].HeaderText = "SĐT người mượn";

        }

        /*private void LoadBorrowToGrid()
        {
            var borrows = _borrowRepo.Load();

            listBorrow.DataSource = borrows;

            listBorrow.Columns["Id"].HeaderText = "ID";
            listBorrow.Columns["BookID"].HeaderText = "ID Sách";
            listBorrow.Columns["ReaderID"].HeaderText = "ID độc giả";
            listBorrow.Columns["BorrowDate"].HeaderText = "Ngày mượn";
            listBorrow.Columns["DueDate"].HeaderText = "Số ngày mượn";
            listBorrow.Columns["ReturnDate"].HeaderText = "Ngày trả";
            listBorrow.Columns["ReturnDate"].HeaderText = "Ngày Trả";
            listBorrow.Columns["QualityBrrow"].HeaderText = "Số Lượng";
        }*/
        private void LoadBorrowToGrid()
        {
            // Lấy dữ liệu gốc
            //var borrows = _borrowRepo.Load();
            var borrows = _borrowingRepository.AsQueryable().ToList();
            //var books = _bookRepo.Load();
            var books = _bookRepository.AsQueryable().ToList();
            //var readers = _readerRepo.Load();
            var readers = _readerRepository.AsQueryable().ToList();
            // Map thành danh sách ViewModel
            var borrowViewModels = borrows
                .OrderByDescending(b => b.BorrowDate)
                .Select(b => new BorrowingViewModel
                {
                    Id = b.Id,
                    BookTitle = books.FirstOrDefault(book => book.Id == b.BookID)?.Title ?? "(Không tìm thấy)",
                    ReaderName = readers.FirstOrDefault(r => r.Id == b.ReaderID)?.Name ?? "(Không tìm thấy)",
                    BorrowDate = b.BorrowDate.Date,
                    DueDate = b.DueDate.Date,
                    ReturnDate = b.ReturnDate != null ? b.ReturnDate.Value.Date : b.ReturnDate,
                    QuantityBorrow = b.QualityBrrow
                }).ToList();

            // Gán DataSource
            listBorrow.DataSource = borrowViewModels;

            // Đặt header
            listBorrow.Columns["Id"].HeaderText = "Mã Phiếu";
            listBorrow.Columns["BookTitle"].HeaderText = "Tên Sách";
            listBorrow.Columns["ReaderName"].HeaderText = "Độc Giả";
            listBorrow.Columns["BorrowDate"].HeaderText = "Ngày Mượn";
            listBorrow.Columns["DueDate"].HeaderText = "Hạn Trả";
            listBorrow.Columns["ReturnDate"].HeaderText = "Ngày Trả";
            listBorrow.Columns["QuantityBorrow"].HeaderText = "Số Lượng";
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
            _bookRepository.AddAsync(newBook);
            LoadBooksToGrid(_bookRepository.AsQueryable().ToList());
        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            var selectedBook = (Book)listBook.CurrentRow.DataBoundItem;

            var existBook = _bookRepository.AsQueryable().FirstOrDefault(x => x.Id == selectedBook.Id);
            if(existBook != null)
            {
                existBook.Title = txtBookName.Text;
                existBook.Publisher = txtPublisher.Text;
                existBook.Author = txtAuthor.Text;
                existBook.Year = int.Parse(txtPublishYear.Text);
                existBook.Quantity = int.Parse(txtBookQuantity.Text);
            }

            _bookRepository.UpdateAsync(existBook);
            LoadBooksToGrid(_bookRepository.AsQueryable().ToList());
        }

        private void RemoveBook_Click(object sender, EventArgs e)
        {
            var selectedBook = (Book)listBook.CurrentRow.DataBoundItem;

            var deleteBook = _bookRepository.AsQueryable().FirstOrDefault(x => x.Id == selectedBook.Id);

            _bookRepository.DeleteAsync(deleteBook);
            LoadBooksToGrid(_bookRepository.AsQueryable().ToList());
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
            //_readerRepo.Add(newReader);
            _readerRepository.AddAsync(newReader);
            LoadReaderToGrid(_readerRepository.AsQueryable().ToList());
        }

        private void btnUpdateReader_Click(object sender, EventArgs e)
        {
            var selectedReader = (Reader)listReader.CurrentRow.DataBoundItem;

            var existReader = _readerRepository.AsQueryable().FirstOrDefault(x => x.Id == selectedReader.Id);

            if(existReader != null)
            {
                existReader.Name = txtReaderName.Text;
                existReader.Email = txtReaderEmail.Text;
                existReader.Phone = txtReaderPhone.Text;
            }

            _readerRepository.UpdateAsync(existReader);
            LoadReaderToGrid(_readerRepository.AsQueryable().ToList());
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

            _readerRepository.DeleteAsync(selectedReader);
            LoadReaderToGrid(_readerRepository.AsQueryable().ToList());
        }

        public void BorrowBook(int bookId, int readerId, int quantityBorrow, DateTime borrowDate, DateTime dueDate)
        {
            // Tìm sách
            var book = _bookRepository.AsQueryable().FirstOrDefault(b => b.Id == bookId);
            if (book == null)
            {
                MessageBox.Show("Không tìm thấy sách.");
                return;
            }

            if (quantityBorrow <= 0)
            {
                MessageBox.Show("Số lượng mượn phải lớn hơn 0.");
                return;
            }

            if (quantityBorrow > book.Quantity)
            {
                MessageBox.Show("Số lượng sách không đủ.");
                return;
            }

            // Tạo bản ghi mượn
            _borrowingRepository.AddAsync(new Borrowing
            {
                BookID = bookId,
                ReaderID = readerId,
                BorrowDate = borrowDate,
                DueDate = dueDate,
                ReturnDate = null, // Chưa trả
                QualityBrrow = quantityBorrow
            });

            // Giảm số lượng sách tồn kho
            book.Quantity -= quantityBorrow;
            _bookRepository.UpdateAsync(book);

            MessageBox.Show("Mượn sách thành công.");
        }

        private void btnBookSelect_Click(object sender, EventArgs e)
        {
            BookListPopupForm bookListPopupForm = new BookListPopupForm();

            if (bookListPopupForm.ShowDialog() == DialogResult.OK)
            {
                txtBorrowBook.Text = bookListPopupForm.SelectedBook.Title;
                bookIdBrow = bookListPopupForm.SelectedBook.Id;
            }
        }

        private void txtReader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ReaderListPopupForm readerListPopupForm = new ReaderListPopupForm();

            if (readerListPopupForm.ShowDialog() == DialogResult.OK)
            {
                txtReader.Text = readerListPopupForm.SelectedReader.Name;
                readerIdBrow = readerListPopupForm.SelectedReader.Id;
            }
        }
        public void ReturnBook(int borrowingId)
        {
            // Tìm bản ghi mượn
            var borrowing = _borrowingRepository.AsQueryable().FirstOrDefault(x => x.Id == borrowingId);
            if (borrowing == null)
            {
                MessageBox.Show("Không tìm thấy phiếu mượn.");
                return;
            }

            // Kiểm tra đã trả chưa
            if (borrowing.ReturnDate.HasValue)
            {
                MessageBox.Show("Phiếu mượn này đã được trả trước đó.");
                return;
            }

            // Cập nhật ngày trả
            borrowing.ReturnDate = DateTime.Now;

            // Tăng lại số lượng sách tồn kho
            var book = _bookRepository.AsQueryable().FirstOrDefault(x => x.Id == borrowing.BookID);
            if (book != null)
            {
                book.Quantity += borrowing.QualityBrrow;
                _bookRepository.UpdateAsync(book);
            }

            // Cập nhật phiếu mượn
            _borrowingRepository.UpdateAsync(borrowing);

            MessageBox.Show("Trả sách thành công.");
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowBook(bookIdBrow, readerIdBrow, int.Parse(numericBorrowQuantity.Text), datePckrBorrowDate.Value, datePckrDueDate.Value);
            LoadBorrowToGrid();
            LoadBooksToGrid(_bookRepository.AsQueryable().ToList());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var selectedBrow = (BorrowingViewModel)listBorrow.CurrentRow.DataBoundItem;
            ReturnBook(selectedBrow.Id);
            LoadBorrowToGrid();
            LoadBooksToGrid(_bookRepository.AsQueryable().ToList());
        }

        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            List<Book> bookFindList = new List<Book>();

            bookFindList = _bookRepository.AsQueryable().Where(b => b.Title.Contains(txtBookSearch.Text)).ToList();
            LoadBooksToGrid(bookFindList);
        }

        private void txtReaderSearch_TextChanged(object sender, EventArgs e)
        {
            List<Reader> readerFindList = new List<Reader>();

            readerFindList = _readerRepository.AsQueryable().Where(r => r.Name.Contains(txtReaderSearch.Text)).ToList();
            LoadReaderToGrid(readerFindList);
        }
    }
}