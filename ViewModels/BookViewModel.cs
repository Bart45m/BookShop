using Rental.Data;
using Rental.Models;

namespace Rental.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Price { get; set; }

        public int Bookstand { get; set; }

        public int Shelf { get; set; }

        public ICollection<AuthorViewModel> Authors { get; set; }

        public BookViewModel() { }

        public BookViewModel(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Price = book.Price;
            Bookstand = book.Bookstand;
            Shelf = book.Shelf;
            Authors = book.Authors.Select(x => new AuthorViewModel(x)).ToList();
        }
    }
}
