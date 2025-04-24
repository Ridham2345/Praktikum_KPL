
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TP09_2211104016.Models;

namespace tpmodul9_2211104016.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static readonly List<Mahasiswa> mahasiswaList = new()
        {
            new Mahasiswa { Nama = "Idham", Nim = "2211104016" },
            new Mahasiswa { Nama = "Aufa", Nim = "1302000002" },
            new Mahasiswa { Nama = "Edgar", Nim = "1234567890" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return Ok(mahasiswaList);
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan.");

            return Ok(mahasiswaList[index]);
        }

        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa mhs)
        {
            mahasiswaList.Add(mhs);
            return Ok(new { message = "Mahasiswa ditambahkan", data = mhs });
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan.");

            var deleted = mahasiswaList[index];
            mahasiswaList.RemoveAt(index);
            return Ok(new { message = "Mahasiswa dihapus", data = deleted });
        }
    }
}
