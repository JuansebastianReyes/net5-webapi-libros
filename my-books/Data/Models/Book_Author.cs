using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Models
{
    public class Book_Author
    {

        //Tabla de Rompimiento entre Book & Author
        public int Id { get; set; }

        //Propiedades de la tabla Book
        public int BookId { get; set; }
        public Book Book { get; set; }

        //Propiedades de la tabla Author
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
