using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TextEditor.Models
{
    public class Document
    {
        // This section for Document
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        // This section for connecting Document to an User
        [Required]
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser? User { get; set; }
    }
}
