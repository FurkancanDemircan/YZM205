using LibraryAPI.Datas;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BorrowController : ControllerBase
{
    private readonly AppDbContext _context;

    public BorrowController(AppDbContext context)
    {
        _context = context;
    }

    // BORROW
    [HttpPost("borrow")]
    public async Task<IActionResult> Borrow(int userId, int bookId)
    {
        var book = await _context.Books.FindAsync(bookId);
        if (book == null) return NotFound("Book not found.");
        if (!book.IsAvailable) return BadRequest("Book is already borrowed.");

        book.IsAvailable = false;

        var record = new BorrowRecord
        {
            UserId = userId,
            BookId = bookId,
            BorrowedAt = DateTime.Now
        };

        _context.BorrowRecords.Add(record);
        await _context.SaveChangesAsync();

        return Ok(record);
    }

    // RETURN
    [HttpPost("return")]
    public async Task<IActionResult> Return(int userId, int bookId)
    {
        var record = await _context.BorrowRecords
            .Where(r => r.UserId == userId && r.BookId == bookId && r.ReturnedAt == null)
            .FirstOrDefaultAsync();

        if (record == null)
            return NotFound("No active borrow record found.");

        record.ReturnedAt = DateTime.Now;

        var book = await _context.Books.FindAsync(bookId);
        if (book != null) book.IsAvailable = true;

        await _context.SaveChangesAsync();

        return Ok(record);
    }
}
