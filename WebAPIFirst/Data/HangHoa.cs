using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIFirst.Data
{
    // Entities
    [Table("HangHoa")]
    public class HangHoa
    {

        [Key]
        public Guid MaHangHoa { get; set; }
        [Required]
        [MaxLength(155)]
        public string TenHangHoa { get; set; }
        public string MoTa { get; set; }
        [Range(0, double.MaxValue)]
        public double DonGia { get; set; }
        public byte GiamGia { get; set; }

        public int? MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; }
    }
}
