using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Models
{
    internal class Book
    {
        // Id, Title, ISBN, AuthorId

        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int AuthorId { get; set; }

        // Navigation Properties
        public Author Author { get; set; }
        public List<Loan> Loans { get; set; }
    }
}
