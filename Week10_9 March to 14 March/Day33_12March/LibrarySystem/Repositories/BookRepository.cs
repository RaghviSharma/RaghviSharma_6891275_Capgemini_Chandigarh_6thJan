using LibrarySystem.Models;

public class BookRepository : IBookRepository
{
	private List<Book> books = new List<Book>
	{
		new Book { Id = 1, Title = "C# Basics", Author = "John Smith" },
		new Book { Id = 2, Title = "ASP.NET Core", Author = "David Brown" }
	};

	public List<Book> GetAllBooks()
	{
		return books;
	}

	public Book GetBookById(int id)
	{
		return books.FirstOrDefault(b => b.Id == id);
	}
}