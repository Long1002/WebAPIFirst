using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIFirst.Data;
using WebAPIFirst.Models;

namespace WebAPIFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiController : ControllerBase
    {
        private readonly MyDbContext _context;

        public LoaiController(MyDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsLoai = _context.Loais.ToList();
            return Ok(dsLoai);
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var loai = _context.Loais.SingleOrDefault(l => l.MaLoai == id);
            if (loai != null)
                return Ok(loai);
            else
                return NotFound();
        }
        [HttpPost]
        public IActionResult CreateNew(LoaiModel loaiModel)
        {
            try
            {
                var loai = new Loai()
                {
                    TenLoai = loaiModel.TenLoai
                };
                _context.Add(loai);
                _context.SaveChanges();
                return Ok(loai);
            }
            catch 
            {
                return BadRequest();
            }
        }
        [HttpPut("id")]
        public IActionResult UpdateLoaiById(int id , LoaiModel loaiModel)
        {
            var loai = _context.Loais.SingleOrDefault(l => l.MaLoai == id);
            if (loai != null)
            {
                loai.TenLoai = loaiModel.TenLoai;
                _context.SaveChanges();
                return Ok(loai);
            }
            else
                return NotFound();
        }
    }
}
