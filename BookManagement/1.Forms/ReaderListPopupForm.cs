using BookManagement._2.Controls;
using BookManagement._3.Models;
using BookManagement._4.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement._1.Forms
{
    public partial class ReaderListPopupForm : Form
    {
        private JsonRepository<Reader> _readerRepo = new JsonRepository<Reader>(AppPaths.ReadersFile);
        public Reader SelectedReader { get; set; }

        public ReaderListPopupForm()
        {
            InitializeComponent();
            LoadReadersToGrid();
        }

        private void LoadReadersToGrid()
        {
            var readers = _readerRepo.Load();

            listReader.DataSource = readers;

            listReader.Columns["Id"].HeaderText = "ID";
            listReader.Columns["Name"].HeaderText = "Tên độc giả";
            listReader.Columns["Email"].HeaderText = "Mail độc giả";
            listReader.Columns["Phone"].HeaderText = "SĐT độc giả";
        }

        private void readerBook_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedReader = (Reader)listReader.CurrentRow.DataBoundItem;
            SelectedReader = selectedReader;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
