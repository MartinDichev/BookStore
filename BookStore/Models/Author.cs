using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int AuthorId { get; set; }
        public virtual Author? AuthorName { get; set; }
        public List<Book> BooksList { get; set; }
        public List<Genre> GenreList { get; set; }

        public Author()
        {
            BooksList = new List<Book>();
            GenreList = new List<Genre>();
        }
    }
}
