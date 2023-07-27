namespace WebAPIFirst.Models
{
    // thiết kế lớp view model
    public class HangHoaVM
    {
         public string TenHangHoa { get; set; }
         public double DonGia { get; set; }
    }
    public class HangHoa : HangHoaVM 
    {  
        public Guid MaHangHoa { get; set; }
    }
    
}
