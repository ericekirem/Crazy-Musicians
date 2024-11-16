using Crazy_Musicians.Data;
using Crazy_Musicians.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Crazy_Musicians.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicianController : ControllerBase
    {
        private readonly MusicianRepository _repository;

        public MusicianController()
        {
            _repository = new MusicianRepository();
        }

        // GET: api/musician
        [HttpGet]
        public ActionResult<IEnumerable<Musician>> GetAllMusicians()
        {
            return Ok(_repository.GetAllMusicians());
        }

        // GET: api/musician/5
        [HttpGet("{id}")]
        public ActionResult<Musician> GetMusicianById(int id)
        {
            var musician = _repository.GetMusicianById(id);
            if (musician == null)
                return NotFound();
            return Ok(musician);
        }

        // POST: api/musician
        [HttpPost]
        public ActionResult CreateMusician([FromBody] Musician musician)
        {
            if (musician == null)
                return BadRequest();
            _repository.AddMusician(musician);
            return CreatedAtAction(nameof(GetMusicianById), new { id = musician.Id }, musician);
        }

        // PUT: api/musician/5
        [HttpPut("{id}")]
        public ActionResult UpdateMusician(int id, [FromBody] Musician musician)
        {
            if (id != musician.Id)
                return BadRequest();
            _repository.UpdateMusician(musician);
            return NoContent();
        }

        // PATCH: api/musician/5
        [HttpPatch("{id}")]
        public ActionResult UpdatePartialMusician(int id, [FromBody] JsonPatchDocument<Musician> patchDocument)
        {
            var musician = _repository.GetMusicianById(id);
            if (musician == null)
                return NotFound();
            patchDocument.ApplyTo(musician);
            _repository.UpdateMusician(musician);
            return NoContent();
        }

        // DELETE: api/musician/5
        [HttpDelete("{id}")]
        public ActionResult DeleteMusician(int id)
        {
            var musician = _repository.GetMusicianById(id);
            if (musician == null)
                return NotFound();
            _repository.DeleteMusician(id);
            return NoContent();
        }

        // GET: api/musician/search
        [HttpGet("search")]
        public ActionResult<IEnumerable<Musician>> SearchMusicians([FromQuery] string query)
        {
            var musicians = _repository.SearchMusicians(query);
            return Ok(musicians);
        }
    }
}
