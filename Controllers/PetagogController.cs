using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetagogetdheDepartamenti.data;
using PetagogetdheDepartamenti.data.Dto.Petagoget;
using PetagogetdheDepartamenti.data.Models;

namespace PetagogetdheDepartamenti.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetagogController : ControllerBase
    {
        private AppDbContext _appDbContext;

        public PetagogController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        [HttpGet("MerrTeGjithePetagoget")]
        public IActionResult MerrTeGjithePetagoget()
        {
            var GjithePetagoget = _appDbContext.Petagoget.ToList();
            return Ok(GjithePetagoget);
        }


        [HttpGet("MerrPetagogunMeId/{id}")]
        public IActionResult MerPetagogMeId(int id)
        {
            var Petagog = _appDbContext.Petagoget.FirstOrDefault(x => x.Id == id);
            return Ok($"Petagogu me id = {id} u morr me sukses!");
        }

        [HttpPost("ShtoPetagogun")]
        public IActionResult ShtoPetagogun([FromBody] PostPetagog payload)
        {

            Petagog newPetagog = new Petagog()
            {

                Emer = payload.Emer,
                Mbiemer = payload.Mbiemer,
                DEP = DateTime.UtcNow.AddYears(-20),


                DepartamentId = payload.DepartamentId
            };

            _appDbContext.Petagoget.Add(newPetagog);
            _appDbContext.SaveChanges();

            return Ok("Profili i petagogut u krijua me sukses!");
        }

        [HttpPut("ModifikoPetagogun")]
        public IActionResult ModifikoPetagogun([FromBody] PutPetagog payload, int id)
        {

            var Petagog = _appDbContext.Petagoget.FirstOrDefault(x => x.Id == id);
            if (Petagog == null)
                return NotFound();



            Petagog.Emer = payload.Emer;
            Petagog.Mbiemer = payload.Mbiemer;
            Petagog.DEP = DateTime.UtcNow.AddYears(-20);



            Petagog.DepartamentId = payload.DepartamentId;


            _appDbContext.Petagoget.Update(Petagog);
            _appDbContext.SaveChanges();

            return Ok("Petagogu u modifikua me sukses!");
        }

        [HttpDelete("HiqPetagog/{id}")]
        public IActionResult HiqPetagog(int id)
        {

            var Petagog = _appDbContext.Petagoget.FirstOrDefault(x => x.Id == id);
            if (Petagog == null)
                return NotFound();


            _appDbContext.Petagoget.Remove(Petagog);
            _appDbContext.SaveChanges();

            return Ok($"Profili i petagogut me id = {id} u fshi me sukses!");
        }
    }
}
