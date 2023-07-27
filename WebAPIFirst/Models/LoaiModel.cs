using System.ComponentModel.DataAnnotations;

namespace WebAPIFirst.Models
{
    public class LoaiModel
    {
        [Required]
        [MaxLength(55)]
        public string TenLoai { get; set; }
    }
}
