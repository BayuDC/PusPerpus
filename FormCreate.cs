using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PusPerpus.Models;

namespace PusPerpus {
    public partial class FormCreate : Form {

        private readonly Database _db;
        private readonly EventHandler _cb;
        public FormCreate(Database db, EventHandler cb) {
            InitializeComponent();
            _db = db;
            _cb = cb;
        }

        private void FormLoad(object sender, EventArgs e) {
            CmbGenre.DataSource = (from genre in _db.Genres select genre.Name).ToList();
            CmbGenre.SelectedItem = null;
        }

        private void BtnAddClick(object sender, EventArgs e) {
            var book = new Book {
                Name = TxtName.Text,
                Author = TxtAuthor.Text,
                Genre = _db.Genres.First(genre => genre.Name == CmbGenre.Text)
            };
            _db.Books.Add(book);
            _db.SaveChanges();

            _cb(null, null);
            this.Close();
        }
    }
}
