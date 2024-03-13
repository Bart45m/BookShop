using Rental.ViewModels;

namespace Rental.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; } = null!;

        public Author() { }

        public Author(AuthorViewModel author, int bookId)
        {
            FirstName = author.FirstName;
            LastName = author.LastName;
            BookId = bookId;
        }
    }
}
