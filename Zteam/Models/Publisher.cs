using System.ComponentModel.DataAnnotations;

namespace Zteam.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        [Required(ErrorMessage = "จำเป็นต้องใส่ชื่อ ผู้จัดจำหน่าย")]
        [MaxLength(100, ErrorMessage = "ต้องมีขนาดไม่เกิน 100 ตัวอักษร")]
        public string PublisherName { get; set; }

        public List<Game> GamesPublished { get; set; }

    }
}
