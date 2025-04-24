
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TP09_2211104016.Models;

namespace tpmodul9_2211104016.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        //private static List<Mahasiswa> data = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Muhammad Idham Cholid", Nim = "2211104016" },
            new Mahasiswa { Nama = "Aufa", Nim = "1302000002" },
            new Mahasiswa { Nama = "Edgar", Nim = "1234567890" },
            new Mahasiswa { Nama = "Alam", Nim = "1234567890" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return mahasiswaList;
        }

     
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan.");

            return mahasiswaList[index];
        }

        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa mhs)
        {
            mahasiswaList.Add(mhs);
            return Ok("Mahasiswa berhasil ditambahkan.");
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan.");

            mahasiswaList.RemoveAt(index);
            return Ok("Mahasiswa berhasil dihapus.");
        }
    }
}
