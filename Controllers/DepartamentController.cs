using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetagogetdheDepartamenti.data;
using PetagogetdheDepartamenti.data.Dto.Departament;
using PetagogetdheDepartamenti.data.Models;
using System;

namespace PetagogetdheDepartamenti.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentController : ControllerBase
    {
        private AppDbContext _appDbContext;
        public DepartamentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }



        [HttpGet("MerrTeGjithDepartamentet")]
        public IActionResult MerrTeGjitheDepartamentet()
        {
            var GjithDepartamentet = _appDbContext.Departamentet.ToList();

            return Ok(GjithDepartamentet);
        }


        [HttpGet("MerrDepartamentMeId/{id}")]
        public IActionResult MerrDepartamentMeId(int id)
        {
            var Departament = _appDbContext.Departamentet.FirstOrDefault(x => x.Id == id);

            if (Departament == null)
            {
                return NotFound();
            }

            return Ok(Departament);
        }

        [HttpPost("KrijoDepartament")]
        public IActionResult KrijoDepartament([FromBody] PostDepartament payload)
        {
            Departament newDepartament = new Departament()
            {
                Godina =payload.Godina,
                EmriD = payload.EmriD,
                Numri = payload.Numri,
                DateCreated = DateTime.UtcNow

            };

            _appDbContext.Departamentet.Add(newDepartament);
            _appDbContext.SaveChanges();

            return Ok("Departamenti u krijua me sukses!");
        }

        [HttpPut("ModifikoDepartamentin")]
        public IActionResult ModifikoDepartamentin([FromBody] PutDepartament payload, int id)
        {

            var Departament = _appDbContext.Departamentet.FirstOrDefault(x => x.Id == id);


            if (Departament == null)
                return NotFound();

            Departament.EmriD = payload.EmriD;
            Departament.Numri = payload.Numri;
            Departament.Godina = payload.Godina;


            _appDbContext.Departamentet.Update(Departament);
            _appDbContext.SaveChanges();

            return Ok();
        }

        [HttpDelete("FshiDepartament/{id}")]
        public IActionResult DeleteDepartament(int id)
        {
            var Departament = _appDbContext.Departamentet.FirstOrDefault(x => x.Id == id);

            if (Departament == null)
                return NotFound();

            _appDbContext.Departamentet.Remove(Departament);
            _appDbContext.SaveChanges();

            return Ok($"Departamenti me id = {id} u fshi me sukses!");
        }
    }
}
