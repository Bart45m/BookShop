using Rental.Models;

namespace Rental.ViewModels
{
    public class AuthorViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public AuthorViewModel() { }

        public AuthorViewModel(Author author) 
        { 
            FirstName = author.FirstName;
            LastName = author.LastName;
        }
    }
}
