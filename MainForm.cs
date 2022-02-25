using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PusPerpus {
    public partial class MainForm : Form {

        private readonly Database _db;
        public MainForm() {
            InitializeComponent();
            _db = new Database();
        }

        private void FormLoad(object sender, EventArgs e) {
            DgvBooks.DataSource = (
                from book in _db.Books 
                join genre in _db.Genres on book.GenreId equals genre.Id
                select new { book.Id, book.Name, book.Author, Genre = genre.Name }
            ).ToList();
        }
    }
}
