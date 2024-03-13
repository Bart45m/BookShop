using Rental.ViewModels;

namespace Rental.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Price { get; set; }

        public int Bookstand { get; set; }

        public int Shelf { get; set; }

        public ICollection<Author> Authors { get; set; } = new List<Author>();

        public ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

        public Book() { }
        public Book(BookViewModel bookViewModel)
        {
            Id = bookViewModel.Id;
            Title = bookViewModel.Title;
            Price = bookViewModel.Price;
            Bookstand = bookViewModel.Bookstand;
            Shelf = bookViewModel.Shelf;
            Authors = bookViewModel.Authors.Select(x => new Author(x, bookViewModel.Id)).ToList();
        }
    }
}
