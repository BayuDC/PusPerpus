using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PusPerpus.Models;

namespace PusPerpus.Views {
    public partial class MainForm : Form {

        private readonly Database _db;

        private FormCreate _formCreate;
        private FormUpdate _formUpdate;
        public MainForm() {
            InitializeComponent();
            _db = new Database();
            _formCreate = new FormCreate(_db, FormLoad);
            _formUpdate = new FormUpdate(_db, FormLoad);
        }

        private void FormLoad(object sender, EventArgs e) {
            DgvBooks.DataSource = (
                from book in _db.Books
                join genre in _db.Genres on book.GenreId equals genre.Id
                select new { book.Id, book.Name, book.Author, Genre = genre.Name }
            ).ToList();
        }

        private void BtnAddClick(object sender, EventArgs e) {
            if (_formCreate.IsDisposed) {
                _formCreate = new FormCreate(_db, FormLoad);
            }

            _formUpdate.Close();
            _formCreate.Show();
        }

        private void BtnUpdateClick(object sender, EventArgs e) {
            if (_formUpdate.IsDisposed) {
                _formUpdate = new FormUpdate(_db, FormLoad);
            }

            _formUpdate.BookId = Convert.ToInt32(DgvBooks.SelectedRows[0].Cells[0].Value);
            _formCreate.Close();
            _formUpdate.Show();
        }

        private void BtnDeleteClick(object sender, EventArgs e) {
            var result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            var bookId = Convert.ToInt32(DgvBooks.SelectedRows[0].Cells[0].Value);

            _db.Books.Remove(_db.Books.Find(bookId));
            _db.SaveChanges();

            FormLoad(null, null);
        }
    }
}
