using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PusPerpus.Views {
    public partial class MainForm : Form {

        private readonly Database _db;

        private FormCreate _formCreate;
        public MainForm() {
            InitializeComponent();
            _db = new Database();
            _formCreate = new FormCreate(_db, FormLoad);
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
            _formCreate.Show();
        }
    }
}
