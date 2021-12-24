using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBlazor_AspNet.Models
{
    public class BookBlazor
    {

        public int Id { get; set; }
        public string bookName { get; set; }
        public double price { get; set; }
        public bool stock { get; set; }

        public List<BookType> bookType { get; set; }

    }
}
