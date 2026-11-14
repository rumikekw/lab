using System.ComponentModel.DataAnnotations;

namespace duktur.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Başlıq daxil edilməlidir")]
        [StringLength(120, ErrorMessage = "Başlıq maksimum 120 simvol ola bilər")]
        public string Title { get; set; } = "";

        [Required(ErrorMessage = "Təsvir daxil edilməlidir")]
        public string Description { get; set; } = "";

        [Required(ErrorMessage = "Kateqoriya seçilməlidir")]
        public string Category { get; set; } = "";

        public string Priority { get; set; } = "Normal";
        public string Status { get; set; } = "New";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}