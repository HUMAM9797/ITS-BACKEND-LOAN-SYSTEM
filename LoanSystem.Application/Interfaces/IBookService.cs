using LoanSystem.Application.DTOs;

namespace LoanSystem.Application.Interfaces
{
    public interface IBookService
    {
        Task<int> CreateBookAsync(CreateBookRequest request);
        Task<bool> BookExistsAsync(int bookId);
    }
}
