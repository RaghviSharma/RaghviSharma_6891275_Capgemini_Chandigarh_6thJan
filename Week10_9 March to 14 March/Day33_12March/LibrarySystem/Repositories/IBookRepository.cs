using LibrarySystem.Models;

public interface IBookRepository
{
	List<Book> GetAllBooks();
	Book GetBookById(int id);
}