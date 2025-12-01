using System.Text.Json.Serialization;

namespace LibraryAPI.Models
{
    public class BorrowRecord
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int BookId { get; set; }

        public DateTime BorrowedAt { get; set; }
        public DateTime? ReturnedAt { get; set; }

        [JsonIgnore]
        public User? User { get; set; }
        [JsonIgnore]
        public Book? Book { get; set; }
    }
}
