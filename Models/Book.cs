using System;
using System.Collections.Generic;

#nullable disable

namespace PusPerpus.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
