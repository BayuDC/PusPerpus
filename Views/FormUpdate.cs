using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PusPerpus.Models;

namespace PusPerpus.Views {
    public partial class FormUpdate : Form {
        private readonly Database _db;
        private readonly EventHandler _cb;

        private Book _book;
        public int BookId { get; set; }
        public FormUpdate(Database db, EventHandler cb) {
            InitializeComponent();
            _db = db;
            _cb = cb;
        }

        private void FormLoad(object sender, EventArgs e) {
            CmbGenre.DataSource = (from genre in _db.Genres select genre.Name).ToList();
            CmbGenre.SelectedItem = null;


            _book = _db.Books.Find(BookId);
            _book.Genre = _db.Genres.Find(_book.GenreId);

            TxtName.Text = _book.Name;
            TxtAuthor.Text = _book.Author;
            CmbGenre.SelectedItem = _book.Genre.Name;
        }

        private void BtnUpdateClick(object sender, EventArgs e) {
            _book.Name = TxtName.Text;
            _book.Author = TxtAuthor.Text;
            _book.Genre = _db.Genres.First(genre => genre.Name == CmbGenre.Text);

            _db.SaveChanges();
            _cb(null, null);
            this.Close();
        }
    }
}
