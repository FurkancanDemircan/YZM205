using System.Text.Json.Serialization;

namespace LibraryAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsAvailable { get; set; }

        public Book()
        {
            IsAvailable = true;
        }

        [JsonIgnore]
        public ICollection<BorrowRecord>? BorrowRecords { get; set; }
    }
}
