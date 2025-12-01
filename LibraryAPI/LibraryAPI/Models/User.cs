using System.Text.Json.Serialization;

namespace LibraryAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public ICollection<BorrowRecord>? BorrowRecords { get; set; }
    }
}
